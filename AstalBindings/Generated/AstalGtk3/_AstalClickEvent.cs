namespace Astal.Bindings.AstalGtk3
{
    public partial struct _AstalClickEvent
    {
        [NativeTypeName("gboolean")]
        public int release;

        [NativeTypeName("guint")]
        public uint time;

        [NativeTypeName("gdouble")]
        public double x;

        [NativeTypeName("gdouble")]
        public double y;

        public GdkModifierType modifier;

        public AstalMouseButton button;
    }
}
