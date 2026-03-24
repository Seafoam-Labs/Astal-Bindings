namespace Astal.Bindings.AstalIO
{
    public unsafe partial struct _AstalIODaemonClass
    {
        [NativeTypeName("GApplicationClass")]
        public _GApplicationClass parent_class;

        [NativeTypeName("void (*)(AstalIODaemon *, const gchar *, GSocketConnection *, GError **)")]
        public delegate* unmanaged[Cdecl]<_AstalIODaemon*, sbyte*, _GSocketConnection*, _GError**, void> request;
    }
}
