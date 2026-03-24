namespace Astal.Bindings.AstalIO
{
    public unsafe partial struct _AstalIOProcess
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalIOProcessPrivate *")]
        public _AstalIOProcessPrivate* priv;
    }
}
