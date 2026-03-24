namespace Astal.Bindings.AstalNetwork
{
    public unsafe partial struct _AstalNetworkAccessPoint
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalNetworkAccessPointPrivate *")]
        public _AstalNetworkAccessPointPrivate* priv;

        [NativeTypeName("NMAccessPoint *")]
        public _NMAccessPoint* ap;
    }
}
