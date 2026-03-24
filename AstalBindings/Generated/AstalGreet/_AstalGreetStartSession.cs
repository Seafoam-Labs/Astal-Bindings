namespace Astal.Bindings.AstalGreet
{
    public unsafe partial struct _AstalGreetStartSession
    {
        [NativeTypeName("AstalGreetRequest")]
        public _AstalGreetRequest parent_instance;

        [NativeTypeName("AstalGreetStartSessionPrivate *")]
        public _AstalGreetStartSessionPrivate* priv;
    }
}
