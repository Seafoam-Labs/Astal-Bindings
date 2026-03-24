namespace Astal.Bindings.AstalApps
{
    public unsafe partial struct _AstalAppsApplication
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalAppsApplicationPrivate *")]
        public _AstalAppsApplicationPrivate* priv;
    }
}
