namespace Astal.Bindings.AstalNetwork
{
    public unsafe partial struct _AstalNetworkWired
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalNetworkWiredPrivate *")]
        public _AstalNetworkWiredPrivate* priv;

        [NativeTypeName("NMActiveConnection *")]
        public _NMActiveConnection* connection;
    }
}
