namespace Astal.Bindings.AstalTray
{
    [NativeTypeName("unsigned int")]
    public enum AstalTrayStatus : uint
    {
        ASTAL_TRAY_STATUS_PASSIVE,
        ASTAL_TRAY_STATUS_ACTIVE,
        ASTAL_TRAY_STATUS_NEEDS_ATTENTION,
    }
}
