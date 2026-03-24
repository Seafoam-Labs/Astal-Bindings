namespace Astal.Bindings.AstalGtk3
{
    public unsafe partial struct _AstalIcon
    {
        [NativeTypeName("GtkImage")]
        public _GtkImage parent_instance;

        [NativeTypeName("AstalIconPrivate *")]
        public _AstalIconPrivate* priv;
    }
}
