namespace Astal.Bindings.AstalBluetooth
{
    public unsafe partial struct _AstalBluetoothDevice
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalBluetoothDevicePrivate *")]
        public _AstalBluetoothDevicePrivate* priv;
    }
}
