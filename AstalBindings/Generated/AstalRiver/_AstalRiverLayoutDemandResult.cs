namespace Astal.Bindings.AstalRiver
{
    public unsafe partial struct _AstalRiverLayoutDemandResult
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalRiverLayoutDemandResultPrivate *")]
        public _AstalRiverLayoutDemandResultPrivate* priv;

        [NativeTypeName("gchar *")]
        public sbyte* layout_name;

        [NativeTypeName("GList *")]
        public _GList* rectangles;
    }
}
