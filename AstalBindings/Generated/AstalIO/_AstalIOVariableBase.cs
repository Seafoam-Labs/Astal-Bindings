namespace Astal.Bindings.AstalIO
{
    public unsafe partial struct _AstalIOVariableBase
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalIOVariableBasePrivate *")]
        public _AstalIOVariableBasePrivate* priv;
    }
}
