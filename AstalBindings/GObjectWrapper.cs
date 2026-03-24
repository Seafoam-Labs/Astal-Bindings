using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings
{
    public static unsafe partial class GObjectInterop
    {
        [DllImport("libgobject-2.0.so.0", CallingConvention = CallingConvention.Cdecl)]
        public static extern void g_object_unref(void* @object);

        [DllImport("libgobject-2.0.so.0", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* g_object_ref(void* @object);

        [DllImport("libgobject-2.0.so.0", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* g_object_ref_sink(void* @object);
        
        [DllImport("libgobject-2.0.so.0", CallingConvention = CallingConvention.Cdecl)]
        public static extern nuint g_signal_connect_data(void* instance, [MarshalAs(UnmanagedType.LPStr)] string detailed_signal, IntPtr c_handler, void* data, IntPtr destroy_data, int connect_flags);

        [DllImport("libgobject-2.0.so.0", CallingConvention = CallingConvention.Cdecl)]
        public static extern void g_signal_handler_disconnect(void* instance, nuint handler_id);
    }

    public abstract unsafe class GObjectWrapper : IDisposable
    {
        public void* Handle { get; private set; }
        private bool _disposed;
        private readonly List<nuint> _signalHandlers = new List<nuint>();

        protected GObjectWrapper(void* handle, bool owned = true)
        {
            if (handle == null) throw new ArgumentNullException(nameof(handle));
            Handle = handle;
            if (!owned)
            {
                GObjectInterop.g_object_ref(Handle);
            }
        }

        ~GObjectWrapper()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (Handle != null)
                {
                    foreach (var handler in _signalHandlers)
                    {
                        GObjectInterop.g_signal_handler_disconnect(Handle, handler);
                    }
                    _signalHandlers.Clear();

                    GObjectInterop.g_object_unref(Handle);
                    Handle = null;
                }
                _disposed = true;
            }
        }

        protected nuint Connect(string signal, IntPtr callback)
        {
            nuint id = GObjectInterop.g_signal_connect_data(Handle, signal, callback, null, IntPtr.Zero, 0);
            if (id != 0) _signalHandlers.Add(id);
            return id;
        }

        protected static string? MarshalString(sbyte* ptr, bool freeNative = false)
        {
            if (ptr == null) return null;
            string? result = Marshal.PtrToStringAnsi((IntPtr)ptr);
            if (freeNative)
            {
                // We might need g_free, but most Astal strings are const or managed by GObject
                // For now, assume it's either const or we don't own it unless specified.
            }
            return result;
        }
        
        protected static string? MarshalStringOwned(sbyte* ptr)
        {
            if (ptr == null) return null;
            string? result = Marshal.PtrToStringAnsi((IntPtr)ptr);
            // TODO: call g_free(ptr) if it was a transferred ownership string
            return result;
        }
    }
}
