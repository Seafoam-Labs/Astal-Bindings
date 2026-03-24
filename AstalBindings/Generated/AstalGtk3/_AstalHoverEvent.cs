namespace Astal.Bindings.AstalGtk3
{
    public partial struct _AstalHoverEvent
    {
        [NativeTypeName("gboolean")]
        public int lost;

        [NativeTypeName("guint")]
        public uint time;

        [NativeTypeName("gdouble")]
        public double x;

        [NativeTypeName("gdouble")]
        public double y;

        public GdkModifierType modifier;

        public GdkCrossingMode mode;

        public GdkNotifyType detail;
    }
}
