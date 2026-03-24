namespace Astal.Bindings.AstalGreet
{
    public unsafe partial struct _AstalGreetCancelSession
    {
        [NativeTypeName("AstalGreetRequest")]
        public _AstalGreetRequest parent_instance;

        [NativeTypeName("AstalGreetCancelSessionPrivate *")]
        public _AstalGreetCancelSessionPrivate* priv;
    }
}
