namespace Astal.Bindings.AstalTray
{
    public unsafe partial struct _AstalTrayTrayItem
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalTrayTrayItemPrivate *")]
        public _AstalTrayTrayItemPrivate* priv;
    }
}
