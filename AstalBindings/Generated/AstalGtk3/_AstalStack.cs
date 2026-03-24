namespace Astal.Bindings.AstalGtk3
{
    public unsafe partial struct _AstalStack
    {
        [NativeTypeName("GtkStack")]
        public _GtkStack parent_instance;

        [NativeTypeName("AstalStackPrivate *")]
        public _AstalStackPrivate* priv;
    }
}
