namespace Astal.Bindings.AstalGtk3
{
    public unsafe partial struct _AstalScrollable
    {
        [NativeTypeName("GtkScrolledWindow")]
        public _GtkScrolledWindow parent_instance;

        [NativeTypeName("AstalScrollablePrivate *")]
        public _AstalScrollablePrivate* priv;
    }
}
