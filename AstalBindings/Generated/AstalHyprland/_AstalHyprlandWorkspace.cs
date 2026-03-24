namespace Astal.Bindings.AstalHyprland
{
    public unsafe partial struct _AstalHyprlandWorkspace
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalHyprlandWorkspacePrivate *")]
        public _AstalHyprlandWorkspacePrivate* priv;

        [NativeTypeName("GList *")]
        public _GList* _clients;
    }
}
