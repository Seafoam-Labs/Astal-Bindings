namespace Astal.Bindings.AstalBattery
{
    [NativeTypeName("unsigned int")]
    public enum AstalBatteryBatteryLevel : uint
    {
        ASTAL_BATTERY_BATTERY_LEVEL_UNKNOWN,
        ASTAL_BATTERY_BATTERY_LEVEL_NONE,
        ASTAL_BATTERY_BATTERY_LEVEL_LOW,
        ASTAL_BATTERY_BATTERY_LEVEL_CRITICIAL,
        ASTAL_BATTERY_BATTERY_LEVEL_NORMAL,
        ASTAL_BATTERY_BATTERY_LEVEL_HIGH,
        ASTAL_BATTERY_BATTERY_LEVEL_FULL,
    }
}
