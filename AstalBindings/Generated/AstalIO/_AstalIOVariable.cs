namespace Astal.Bindings.AstalIO
{
    public unsafe partial struct _AstalIOVariable
    {
        [NativeTypeName("AstalIOVariableBase")]
        public _AstalIOVariableBase parent_instance;

        [NativeTypeName("AstalIOVariablePrivate *")]
        public _AstalIOVariablePrivate* priv;
    }
}
