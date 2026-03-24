namespace Astal.Bindings.AstalBattery
{
    [NativeTypeName("unsigned int")]
    public enum AstalBatteryWarningLevel : uint
    {
        ASTAL_BATTERY_WARNING_LEVEL_UNKNOWN,
        ASTAL_BATTERY_WARNING_LEVEL_NONE,
        ASTAL_BATTERY_WARNING_LEVEL_DISCHARGING,
        ASTAL_BATTERY_WARNING_LEVEL_LOW,
        ASTAL_BATTERY_WARNING_LEVEL_CRITICIAL,
        ASTAL_BATTERY_WARNING_LEVEL_ACTION,
    }
}
