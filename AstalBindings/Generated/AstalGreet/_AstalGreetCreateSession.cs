namespace Astal.Bindings.AstalGreet
{
    public unsafe partial struct _AstalGreetCreateSession
    {
        [NativeTypeName("AstalGreetRequest")]
        public _AstalGreetRequest parent_instance;

        [NativeTypeName("AstalGreetCreateSessionPrivate *")]
        public _AstalGreetCreateSessionPrivate* priv;
    }
}
