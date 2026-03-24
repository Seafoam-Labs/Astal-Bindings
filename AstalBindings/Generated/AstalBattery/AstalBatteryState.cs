namespace Astal.Bindings.AstalBattery
{
    [NativeTypeName("unsigned int")]
    public enum AstalBatteryState : uint
    {
        ASTAL_BATTERY_STATE_UNKNOWN,
        ASTAL_BATTERY_STATE_CHARGING,
        ASTAL_BATTERY_STATE_DISCHARGING,
        ASTAL_BATTERY_STATE_EMPTY,
        ASTAL_BATTERY_STATE_FULLY_CHARGED,
        ASTAL_BATTERY_STATE_PENDING_CHARGE,
        ASTAL_BATTERY_STATE_PENDING_DISCHARGE,
    }
}
