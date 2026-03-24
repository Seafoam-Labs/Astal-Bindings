namespace Astal.Bindings.AstalNotifd
{
    [NativeTypeName("unsigned int")]
    public enum AstalNotifdClosedReason : uint
    {
        ASTAL_NOTIFD_CLOSED_REASON_EXPIRED = 1,
        ASTAL_NOTIFD_CLOSED_REASON_DISMISSED_BY_USER = 2,
        ASTAL_NOTIFD_CLOSED_REASON_CLOSED = 3,
        ASTAL_NOTIFD_CLOSED_REASON_UNDEFINED = 4,
    }
}
