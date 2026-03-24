namespace Astal.Bindings.AstalGreet
{
    public unsafe partial struct _AstalGreetError
    {
        [NativeTypeName("AstalGreetResponse")]
        public _AstalGreetResponse parent_instance;

        [NativeTypeName("AstalGreetErrorPrivate *")]
        public _AstalGreetErrorPrivate* priv;
    }
}
