namespace Astal.Bindings.AstalGtk3
{
    public unsafe partial struct _AstalLabel
    {
        [NativeTypeName("GtkLabel")]
        public _GtkLabel parent_instance;

        [NativeTypeName("AstalLabelPrivate *")]
        public _AstalLabelPrivate* priv;
    }
}
