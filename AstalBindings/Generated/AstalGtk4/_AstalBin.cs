namespace Astal.Bindings.AstalGtk4
{
    public unsafe partial struct _AstalBin
    {
        [NativeTypeName("GtkWidget")]
        public _GtkWidget parent_instance;

        [NativeTypeName("AstalBinPrivate *")]
        public _AstalBinPrivate* priv;
    }
}
