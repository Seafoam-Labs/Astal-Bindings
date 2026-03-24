namespace Astal.Bindings.AstalGtk3
{
    public unsafe partial struct _AstalOverlay
    {
        [NativeTypeName("GtkOverlay")]
        public _GtkOverlay parent_instance;

        [NativeTypeName("AstalOverlayPrivate *")]
        public _AstalOverlayPrivate* priv;
    }
}
