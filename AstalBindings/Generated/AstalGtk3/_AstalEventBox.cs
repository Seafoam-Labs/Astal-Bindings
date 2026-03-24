namespace Astal.Bindings.AstalGtk3
{
    public unsafe partial struct _AstalEventBox
    {
        [NativeTypeName("GtkEventBox")]
        public _GtkEventBox parent_instance;

        [NativeTypeName("AstalEventBoxPrivate *")]
        public _AstalEventBoxPrivate* priv;
    }
}
