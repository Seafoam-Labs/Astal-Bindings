namespace Astal.Bindings.AstalGtk3
{
    public unsafe partial struct _AstalLevelBar
    {
        [NativeTypeName("GtkLevelBar")]
        public _GtkLevelBar parent_instance;

        [NativeTypeName("AstalLevelBarPrivate *")]
        public _AstalLevelBarPrivate* priv;
    }
}
