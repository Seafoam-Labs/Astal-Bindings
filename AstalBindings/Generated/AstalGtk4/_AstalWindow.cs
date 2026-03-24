namespace Astal.Bindings.AstalGtk4
{
    public unsafe partial struct _AstalWindow
    {
        [NativeTypeName("GtkWindow")]
        public _GtkWindow parent_instance;

        [NativeTypeName("AstalWindowPrivate *")]
        public _AstalWindowPrivate* priv;
    }
}
