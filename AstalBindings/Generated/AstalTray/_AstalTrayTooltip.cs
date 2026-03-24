namespace Astal.Bindings.AstalTray
{
    public unsafe partial struct _AstalTrayTooltip
    {
        [NativeTypeName("gchar *")]
        public sbyte* icon_name;

        [NativeTypeName("AstalTrayPixmap *")]
        public _AstalTrayPixmap* icon;

        [NativeTypeName("gint")]
        public int icon_length1;

        [NativeTypeName("gchar *")]
        public sbyte* title;

        [NativeTypeName("gchar *")]
        public sbyte* description;
    }
}
