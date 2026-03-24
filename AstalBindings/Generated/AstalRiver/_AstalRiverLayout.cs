namespace Astal.Bindings.AstalRiver
{
    public unsafe partial struct _AstalRiverLayout
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalRiverLayoutPrivate *")]
        public _AstalRiverLayoutPrivate* priv;

        [NativeTypeName("GClosure *")]
        public _GClosure* layout_demand_closure;
    }
}
