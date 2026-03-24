namespace Astal.Bindings.AstalGreet
{
    public unsafe partial struct _AstalGreetRequestClass
    {
        [NativeTypeName("GObjectClass")]
        public _GObjectClass parent_class;

        [NativeTypeName("const gchar *(*)(AstalGreetRequest *)")]
        public delegate* unmanaged[Cdecl]<_AstalGreetRequest*, sbyte*> get_type_name;
    }
}
