namespace Astal.Bindings.AstalGreet
{
    public unsafe partial struct _AstalGreetRequest
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalGreetRequestPrivate *")]
        public _AstalGreetRequestPrivate* priv;
    }
}
