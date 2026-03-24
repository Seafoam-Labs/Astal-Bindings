using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalMpris
{
    public unsafe class Player : GObjectWrapper
    {
        internal Player(_AstalMprisPlayer* handle, bool owned = true) : base(handle, owned) { }

        public string? BusName => MarshalString(AstalMprisInterop.astal_mpris_player_get_bus_name((_AstalMprisPlayer*)Handle));
        public bool Available => AstalMprisInterop.astal_mpris_player_get_available((_AstalMprisPlayer*)Handle) != 0;
        public bool CanQuit => AstalMprisInterop.astal_mpris_player_get_can_quit((_AstalMprisPlayer*)Handle) != 0;
        public bool Fullscreen => AstalMprisInterop.astal_mpris_player_get_fullscreen((_AstalMprisPlayer*)Handle) != 0;
        public bool CanSetFullscreen => AstalMprisInterop.astal_mpris_player_get_can_set_fullscreen((_AstalMprisPlayer*)Handle) != 0;
        public bool CanRaise => AstalMprisInterop.astal_mpris_player_get_can_raise((_AstalMprisPlayer*)Handle) != 0;
        public string? Identity => MarshalString(AstalMprisInterop.astal_mpris_player_get_identity((_AstalMprisPlayer*)Handle));
        public string? Entry => MarshalString(AstalMprisInterop.astal_mpris_player_get_entry((_AstalMprisPlayer*)Handle));
        
        public AstalMprisLoop LoopStatus
        {
            get => AstalMprisInterop.astal_mpris_player_get_loop_status((_AstalMprisPlayer*)Handle);
            set => AstalMprisInterop.astal_mpris_player_set_loop_status((_AstalMprisPlayer*)Handle, value);
        }

        public AstalMprisShuffle ShuffleStatus
        {
            get => AstalMprisInterop.astal_mpris_player_get_shuffle_status((_AstalMprisPlayer*)Handle);
            set => AstalMprisInterop.astal_mpris_player_set_shuffle_status((_AstalMprisPlayer*)Handle, value);
        }

        public double Rate
        {
            get => AstalMprisInterop.astal_mpris_player_get_rate((_AstalMprisPlayer*)Handle);
            set => AstalMprisInterop.astal_mpris_player_set_rate((_AstalMprisPlayer*)Handle, value);
        }

        public double Volume
        {
            get => AstalMprisInterop.astal_mpris_player_get_volume((_AstalMprisPlayer*)Handle);
            set => AstalMprisInterop.astal_mpris_player_set_volume((_AstalMprisPlayer*)Handle, value);
        }

        public double Position
        {
            get => AstalMprisInterop.astal_mpris_player_get_position((_AstalMprisPlayer*)Handle);
            set => AstalMprisInterop.astal_mpris_player_set_position((_AstalMprisPlayer*)Handle, value);
        }

        public AstalMprisPlaybackStatus PlaybackStatus => AstalMprisInterop.astal_mpris_player_get_playback_status((_AstalMprisPlayer*)Handle);
        public double MinimumRate => AstalMprisInterop.astal_mpris_player_get_minimum_rate((_AstalMprisPlayer*)Handle);
        public double MaximumRate => AstalMprisInterop.astal_mpris_player_get_maximum_rate((_AstalMprisPlayer*)Handle);
        public bool CanGoNext => AstalMprisInterop.astal_mpris_player_get_can_go_next((_AstalMprisPlayer*)Handle) != 0;
        public bool CanGoPrevious => AstalMprisInterop.astal_mpris_player_get_can_go_previous((_AstalMprisPlayer*)Handle) != 0;
        public bool CanPlay => AstalMprisInterop.astal_mpris_player_get_can_play((_AstalMprisPlayer*)Handle) != 0;
        public bool CanPause => AstalMprisInterop.astal_mpris_player_get_can_pause((_AstalMprisPlayer*)Handle) != 0;
        public bool CanSeek => AstalMprisInterop.astal_mpris_player_get_can_seek((_AstalMprisPlayer*)Handle) != 0;
        public bool CanControl => AstalMprisInterop.astal_mpris_player_get_can_control((_AstalMprisPlayer*)Handle) != 0;
        
        public string? Trackid => MarshalString(AstalMprisInterop.astal_mpris_player_get_trackid((_AstalMprisPlayer*)Handle));
        public double Length => AstalMprisInterop.astal_mpris_player_get_length((_AstalMprisPlayer*)Handle);
        public string? ArtUrl => MarshalString(AstalMprisInterop.astal_mpris_player_get_art_url((_AstalMprisPlayer*)Handle));
        public string? Album => MarshalString(AstalMprisInterop.astal_mpris_player_get_album((_AstalMprisPlayer*)Handle));
        public string? AlbumArtist => MarshalString(AstalMprisInterop.astal_mpris_player_get_album_artist((_AstalMprisPlayer*)Handle));
        public string? Artist => MarshalString(AstalMprisInterop.astal_mpris_player_get_artist((_AstalMprisPlayer*)Handle));
        public string? Lyrics => MarshalString(AstalMprisInterop.astal_mpris_player_get_lyrics((_AstalMprisPlayer*)Handle));
        public string? Title => MarshalString(AstalMprisInterop.astal_mpris_player_get_title((_AstalMprisPlayer*)Handle));
        public string? Composer => MarshalString(AstalMprisInterop.astal_mpris_player_get_composer((_AstalMprisPlayer*)Handle));
        public string? Comments => MarshalString(AstalMprisInterop.astal_mpris_player_get_comments((_AstalMprisPlayer*)Handle));
        public string? CoverArt => MarshalString(AstalMprisInterop.astal_mpris_player_get_cover_art((_AstalMprisPlayer*)Handle));

        public void Raise() => AstalMprisInterop.astal_mpris_player_raise((_AstalMprisPlayer*)Handle);
        public void Quit() => AstalMprisInterop.astal_mpris_player_quit((_AstalMprisPlayer*)Handle);
        public void ToggleFullscreen() => AstalMprisInterop.astal_mpris_player_toggle_fullscreen((_AstalMprisPlayer*)Handle);
        public void Next() => AstalMprisInterop.astal_mpris_player_next((_AstalMprisPlayer*)Handle);
        public void Previous() => AstalMprisInterop.astal_mpris_player_previous((_AstalMprisPlayer*)Handle);
        public void Pause() => AstalMprisInterop.astal_mpris_player_pause((_AstalMprisPlayer*)Handle);
        public void PlayPause() => AstalMprisInterop.astal_mpris_player_play_pause((_AstalMprisPlayer*)Handle);
        public void Stop() => AstalMprisInterop.astal_mpris_player_stop((_AstalMprisPlayer*)Handle);
        public void Play() => AstalMprisInterop.astal_mpris_player_play((_AstalMprisPlayer*)Handle);
        
        public void OpenUri(string uri)
        {
            IntPtr nativeUri = Marshal.StringToHGlobalAnsi(uri);
            try
            {
                AstalMprisInterop.astal_mpris_player_open_uri((_AstalMprisPlayer*)Handle, (sbyte*)nativeUri);
            }
            finally
            {
                Marshal.FreeHGlobal(nativeUri);
            }
        }
    }

    public unsafe class Mpris : GObjectWrapper
    {
        public static Mpris Default => new Mpris(AstalMprisInterop.astal_mpris_get_default(), owned: false);

        public Mpris() : base(AstalMprisInterop.astal_mpris_mpris_new()) { }
        internal Mpris(_AstalMprisMpris* handle, bool owned = true) : base(handle, owned) { }

        public List<Player> Players
        {
            get
            {
                var list = new List<Player>();
                _GList* gList = AstalMprisInterop.astal_mpris_mpris_get_players((_AstalMprisMpris*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new Player((_AstalMprisPlayer*)data, owned: false));
                }
                return list;
            }
        }

        // Helpers
        [StructLayout(LayoutKind.Sequential)]
        struct GListInternal { public void* data; public GListInternal* next; public GListInternal* prev; }
        private static void* GetData(_GList* list) => ((GListInternal*)list)->data;
        private static _GList* GetNext(_GList* list) => (_GList*)((GListInternal*)list)->next;
    }
}
