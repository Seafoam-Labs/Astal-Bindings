namespace Astal.Bindings.AstalNotifd
{
    public unsafe partial struct _AstalNotifdNotification
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalNotifdNotificationPrivate *")]
        public _AstalNotifdNotificationPrivate* priv;
    }
}
