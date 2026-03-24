namespace Astal.Bindings.AstalGtk3
{
    public partial struct _AstalScrollEvent
    {
        [NativeTypeName("guint")]
        public uint time;

        [NativeTypeName("gdouble")]
        public double x;

        [NativeTypeName("gdouble")]
        public double y;

        public GdkModifierType modifier;

        public GdkScrollDirection direction;

        [NativeTypeName("gdouble")]
        public double delta_x;

        [NativeTypeName("gdouble")]
        public double delta_y;
    }
}
