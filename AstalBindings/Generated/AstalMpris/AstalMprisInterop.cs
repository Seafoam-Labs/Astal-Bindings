using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalMpris
{
    public static unsafe partial class AstalMprisInterop
    {
        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_mpris_mpris_get_type();

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalMprisMpris *")]
        public static extern _AstalMprisMpris* astal_mpris_get_default();

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalMprisMpris *")]
        public static extern _AstalMprisMpris* astal_mpris_mpris_get_default();

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalMprisMpris *")]
        public static extern _AstalMprisMpris* astal_mpris_mpris_new();

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalMprisMpris *")]
        public static extern _AstalMprisMpris* astal_mpris_mpris_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_mpris_player_get_type();

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_mpris_mpris_get_players([NativeTypeName("AstalMprisMpris *")] _AstalMprisMpris* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_raise([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_quit([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_toggle_fullscreen([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_next([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_previous([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_pause([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_play_pause([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_stop([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_play([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_open_uri([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self, [NativeTypeName("const gchar *")] sbyte* uri);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_loop([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_shuffle([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GVariant *")]
        public static extern _GVariant* astal_mpris_player_get_meta([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self, [NativeTypeName("const gchar *")] sbyte* key);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalMprisPlayer *")]
        public static extern _AstalMprisPlayer* astal_mpris_player_new([NativeTypeName("const gchar *")] sbyte* name);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalMprisPlayer *")]
        public static extern _AstalMprisPlayer* astal_mpris_player_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("const gchar *")] sbyte* name);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_bus_name([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_available([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_can_quit([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_fullscreen([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_can_set_fullscreen([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_can_raise([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_identity([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_entry([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_mpris_player_get_supported_uri_schemes([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_mpris_player_get_supported_mime_types([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_mpris_loop_get_type();

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalMprisLoop astal_mpris_player_get_loop_status([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_set_loop_status([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self, AstalMprisLoop value);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_mpris_shuffle_get_type();

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalMprisShuffle astal_mpris_player_get_shuffle_status([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_set_shuffle_status([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self, AstalMprisShuffle value);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_mpris_player_get_rate([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_set_rate([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_mpris_player_get_volume([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_set_volume([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_mpris_player_get_position([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_mpris_player_set_position([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_mpris_playback_status_get_type();

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalMprisPlaybackStatus astal_mpris_player_get_playback_status([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_mpris_player_get_minimum_rate([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_mpris_player_get_maximum_rate([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_can_go_next([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_can_go_previous([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_can_play([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_can_pause([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_can_seek([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_mpris_player_get_can_control([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GVariant *")]
        public static extern _GVariant* astal_mpris_player_get_metadata([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_trackid([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_mpris_player_get_length([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_art_url([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_album([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_album_artist([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_artist([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_lyrics([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_title([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_composer([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_comments([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [DllImport("libastal-mpris-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_mpris_player_get_cover_art([NativeTypeName("AstalMprisPlayer *")] _AstalMprisPlayer* self);

        [NativeTypeName("#define ASTAL_MPRIS_MAJOR_VERSION 0")]
        public const int ASTAL_MPRIS_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_MPRIS_MINOR_VERSION 1")]
        public const int ASTAL_MPRIS_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_MPRIS_MICRO_VERSION 0")]
        public const int ASTAL_MPRIS_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_MPRIS_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_MPRIS_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_MPRIS_TYPE_MPRIS (astal_mpris_mpris_get_type ())")]
        public static readonly nuint ASTAL_MPRIS_TYPE_MPRIS = (astal_mpris_mpris_get_type());

        [NativeTypeName("#define ASTAL_MPRIS_TYPE_PLAYER (astal_mpris_player_get_type ())")]
        public static readonly nuint ASTAL_MPRIS_TYPE_PLAYER = (astal_mpris_player_get_type());

        [NativeTypeName("#define ASTAL_MPRIS_TYPE_LOOP (astal_mpris_loop_get_type ())")]
        public static readonly nuint ASTAL_MPRIS_TYPE_LOOP = (astal_mpris_loop_get_type());

        [NativeTypeName("#define ASTAL_MPRIS_TYPE_SHUFFLE (astal_mpris_shuffle_get_type ())")]
        public static readonly nuint ASTAL_MPRIS_TYPE_SHUFFLE = (astal_mpris_shuffle_get_type());

        [NativeTypeName("#define ASTAL_MPRIS_TYPE_PLAYBACK_STATUS (astal_mpris_playback_status_get_type ())")]
        public static readonly nuint ASTAL_MPRIS_TYPE_PLAYBACK_STATUS = (astal_mpris_playback_status_get_type());
    }
}
