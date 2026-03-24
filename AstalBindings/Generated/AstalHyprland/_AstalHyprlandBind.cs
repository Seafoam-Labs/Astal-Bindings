namespace Astal.Bindings.AstalHyprland
{
    public unsafe partial struct _AstalHyprlandBind
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalHyprlandBindPrivate *")]
        public _AstalHyprlandBindPrivate* priv;
    }
}
