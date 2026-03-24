namespace Astal.Bindings.AstalGreet
{
    public unsafe partial struct _AstalGreetAuthMessage
    {
        [NativeTypeName("AstalGreetResponse")]
        public _AstalGreetResponse parent_instance;

        [NativeTypeName("AstalGreetAuthMessagePrivate *")]
        public _AstalGreetAuthMessagePrivate* priv;
    }
}
