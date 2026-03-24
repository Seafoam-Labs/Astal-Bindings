namespace Astal.Bindings.AstalBluetooth
{
    public unsafe partial struct _AstalBluetoothAdapter
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalBluetoothAdapterPrivate *")]
        public _AstalBluetoothAdapterPrivate* priv;
    }
}
