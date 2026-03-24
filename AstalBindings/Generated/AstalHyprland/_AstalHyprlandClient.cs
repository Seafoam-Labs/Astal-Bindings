namespace Astal.Bindings.AstalHyprland
{
    public unsafe partial struct _AstalHyprlandClient
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalHyprlandClientPrivate *")]
        public _AstalHyprlandClientPrivate* priv;
    }
}
