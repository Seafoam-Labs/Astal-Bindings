namespace Astal.Bindings.AstalHyprland
{
    public unsafe partial struct _AstalHyprlandMonitor
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalHyprlandMonitorPrivate *")]
        public _AstalHyprlandMonitorPrivate* priv;
    }
}
