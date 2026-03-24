namespace Astal.Bindings.AstalMpris
{
    public unsafe partial struct _AstalMprisPlayer
    {
        [NativeTypeName("GObject")]
        public _GObject parent_instance;

        [NativeTypeName("AstalMprisPlayerPrivate *")]
        public _AstalMprisPlayerPrivate* priv;
    }
}
