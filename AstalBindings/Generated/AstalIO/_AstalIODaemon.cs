namespace Astal.Bindings.AstalIO
{
    public unsafe partial struct _AstalIODaemon
    {
        [NativeTypeName("GApplication")]
        public _GApplication parent_instance;

        [NativeTypeName("AstalIODaemonPrivate *")]
        public _AstalIODaemonPrivate* priv;
    }
}
