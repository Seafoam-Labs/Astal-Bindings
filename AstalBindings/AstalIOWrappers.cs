using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalIO
{
    public unsafe class Process : GObjectWrapper
    {
        internal Process(_AstalIOProcess* handle, bool owned = true) : base(handle, owned) { }

        public static Process Subprocess(string cmd)
        {
            IntPtr nativeCmd = Marshal.StringToHGlobalAnsi(cmd);
            try
            {
                var handle = AstalIOInterop.astal_io_process_subprocess((sbyte*)nativeCmd, null);
                return new Process(handle);
            }
            finally
            {
                Marshal.FreeHGlobal(nativeCmd);
            }
        }

        public static string? Exec(string cmd)
        {
            IntPtr nativeCmd = Marshal.StringToHGlobalAnsi(cmd);
            try
            {
                return MarshalStringOwned(AstalIOInterop.astal_io_process_exec((sbyte*)nativeCmd, null));
            }
            finally
            {
                Marshal.FreeHGlobal(nativeCmd);
            }
        }

        public void Kill() => AstalIOInterop.astal_io_process_kill((_AstalIOProcess*)Handle);
        public void Signal(int signalNum) => AstalIOInterop.astal_io_process_signal((_AstalIOProcess*)Handle, signalNum);
        
        public void Write(string input)
        {
            IntPtr nativeIn = Marshal.StringToHGlobalAnsi(input);
            try { AstalIOInterop.astal_io_process_write((_AstalIOProcess*)Handle, (sbyte*)nativeIn, null); }
            finally { Marshal.FreeHGlobal(nativeIn); }
        }
    }

    public unsafe class Time : GObjectWrapper
    {
        internal Time(_AstalIOTime* handle, bool owned = true) : base(handle, owned) { }

        public void Cancel() => AstalIOInterop.astal_io_time_cancel((_AstalIOTime*)Handle);
    }
}
