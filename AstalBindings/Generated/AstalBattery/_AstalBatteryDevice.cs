namespace Astal.Bindings.AstalBattery
{
    public unsafe partial struct _AstalBatteryDevice
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalBatteryDevicePrivate *")]
        public _AstalBatteryDevicePrivate* priv;
    }
}
