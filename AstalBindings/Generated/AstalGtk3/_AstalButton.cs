namespace Astal.Bindings.AstalGtk3
{
    public unsafe partial struct _AstalButton
    {
        [NativeTypeName("GtkButton")]
        public _GtkButton parent_instance;

        [NativeTypeName("AstalButtonPrivate *")]
        public _AstalButtonPrivate* priv;
    }
}
