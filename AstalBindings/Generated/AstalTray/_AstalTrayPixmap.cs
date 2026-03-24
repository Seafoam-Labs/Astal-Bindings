namespace Astal.Bindings.AstalTray
{
    public unsafe partial struct _AstalTrayPixmap
    {
        [NativeTypeName("gint")]
        public int width;

        [NativeTypeName("gint")]
        public int height;

        [NativeTypeName("guint8 *")]
        public byte* bytes;

        [NativeTypeName("gint")]
        public int bytes_length1;
    }
}
