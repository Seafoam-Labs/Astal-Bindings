namespace Astal.Bindings.AstalNotifd
{
    [NativeTypeName("unsigned int")]
    public enum AstalNotifdUrgency : uint
    {
        ASTAL_NOTIFD_URGENCY_LOW = 0,
        ASTAL_NOTIFD_URGENCY_NORMAL = 1,
        ASTAL_NOTIFD_URGENCY_CRITICAL = 2,
    }
}
