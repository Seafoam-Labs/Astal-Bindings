namespace Astal.Bindings.AstalGtk4
{
    public unsafe partial struct _AstalBox
    {
        [NativeTypeName("GtkBox")]
        public _GtkBox parent_instance;

        [NativeTypeName("AstalBoxPrivate *")]
        public _AstalBoxPrivate* priv;
    }
}
