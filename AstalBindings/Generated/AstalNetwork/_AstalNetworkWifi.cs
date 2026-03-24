namespace Astal.Bindings.AstalNetwork
{
    public unsafe partial struct _AstalNetworkWifi
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalNetworkWifiPrivate *")]
        public _AstalNetworkWifiPrivate* priv;
    }
}
