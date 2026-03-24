namespace Astal.Bindings.AstalIO
{
    public unsafe partial struct _AstalIOApplicationIface
    {
        [NativeTypeName("GTypeInterface")]
        public _GTypeInterface parent_iface;

        [NativeTypeName("void (*)(AstalIOApplication *, GError **)")]
        public delegate* unmanaged[Cdecl]<_AstalIOApplication*, _GError**, void> quit;

        [NativeTypeName("void (*)(AstalIOApplication *, GError **)")]
        public delegate* unmanaged[Cdecl]<_AstalIOApplication*, _GError**, void> inspector;

        [NativeTypeName("void (*)(AstalIOApplication *, const gchar *, GError **)")]
        public delegate* unmanaged[Cdecl]<_AstalIOApplication*, sbyte*, _GError**, void> toggle_window;

        [NativeTypeName("void (*)(AstalIOApplication *, GError **)")]
        public delegate* unmanaged[Cdecl]<_AstalIOApplication*, _GError**, void> acquire_socket;

        [NativeTypeName("void (*)(AstalIOApplication *, const gchar *, GSocketConnection *, GError **)")]
        public delegate* unmanaged[Cdecl]<_AstalIOApplication*, sbyte*, _GSocketConnection*, _GError**, void> request;

        [NativeTypeName("gchar *(*)(AstalIOApplication *)")]
        public delegate* unmanaged[Cdecl]<_AstalIOApplication*, sbyte*> get_instance_name;

        [NativeTypeName("void (*)(AstalIOApplication *, const gchar *)")]
        public delegate* unmanaged[Cdecl]<_AstalIOApplication*, sbyte*, void> set_instance_name;
    }
}
