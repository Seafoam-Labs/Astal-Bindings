using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalHyprland
{
    public unsafe class Position : GObjectWrapper
    {
        public Position() : base(AstalHyprlandInterop.astal_hyprland_position_new()) { }
        internal Position(_AstalHyprlandPosition* handle, bool owned = true) : base(handle, owned) { }

        public int X
        {
            get => AstalHyprlandInterop.astal_hyprland_position_get_x((_AstalHyprlandPosition*)Handle);
            set => AstalHyprlandInterop.astal_hyprland_position_set_x((_AstalHyprlandPosition*)Handle, value);
        }

        public int Y
        {
            get => AstalHyprlandInterop.astal_hyprland_position_get_y((_AstalHyprlandPosition*)Handle);
            set => AstalHyprlandInterop.astal_hyprland_position_set_y((_AstalHyprlandPosition*)Handle, value);
        }
    }

    public unsafe class Bind : GObjectWrapper
    {
        internal Bind(_AstalHyprlandBind* handle, bool owned = true) : base(handle, owned) { }

        public bool Locked
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_locked((_AstalHyprlandBind*)Handle) != 0;
            set => AstalHyprlandInterop.astal_hyprland_bind_set_locked((_AstalHyprlandBind*)Handle, value ? 1 : 0);
        }

        public bool Mouse
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_mouse((_AstalHyprlandBind*)Handle) != 0;
            set => AstalHyprlandInterop.astal_hyprland_bind_set_mouse((_AstalHyprlandBind*)Handle, value ? 1 : 0);
        }

        public bool Release
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_release((_AstalHyprlandBind*)Handle) != 0;
            set => AstalHyprlandInterop.astal_hyprland_bind_set_release((_AstalHyprlandBind*)Handle, value ? 1 : 0);
        }

        public bool Repeat
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_repeat((_AstalHyprlandBind*)Handle) != 0;
            set => AstalHyprlandInterop.astal_hyprland_bind_set_repeat((_AstalHyprlandBind*)Handle, value ? 1 : 0);
        }

        public bool LongPress
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_long_press((_AstalHyprlandBind*)Handle) != 0;
            set => AstalHyprlandInterop.astal_hyprland_bind_set_long_press((_AstalHyprlandBind*)Handle, value ? 1 : 0);
        }

        public bool NonConsuming
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_non_consuming((_AstalHyprlandBind*)Handle) != 0;
            set => AstalHyprlandInterop.astal_hyprland_bind_set_non_consuming((_AstalHyprlandBind*)Handle, value ? 1 : 0);
        }

        public bool HasDescription
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_has_description((_AstalHyprlandBind*)Handle) != 0;
            set => AstalHyprlandInterop.astal_hyprland_bind_set_has_description((_AstalHyprlandBind*)Handle, value ? 1 : 0);
        }

        public nint Modmask
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_modmask((_AstalHyprlandBind*)Handle);
            set => AstalHyprlandInterop.astal_hyprland_bind_set_modmask((_AstalHyprlandBind*)Handle, value);
        }

        public string? Submap
        {
            get => MarshalString(AstalHyprlandInterop.astal_hyprland_bind_get_submap((_AstalHyprlandBind*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalHyprlandInterop.astal_hyprland_bind_set_submap((_AstalHyprlandBind*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? Key
        {
            get => MarshalString(AstalHyprlandInterop.astal_hyprland_bind_get_key((_AstalHyprlandBind*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalHyprlandInterop.astal_hyprland_bind_set_key((_AstalHyprlandBind*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public nint Keycode
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_keycode((_AstalHyprlandBind*)Handle);
            set => AstalHyprlandInterop.astal_hyprland_bind_set_keycode((_AstalHyprlandBind*)Handle, value);
        }

        public bool CatchAll
        {
            get => AstalHyprlandInterop.astal_hyprland_bind_get_catch_all((_AstalHyprlandBind*)Handle) != 0;
            set => AstalHyprlandInterop.astal_hyprland_bind_set_catch_all((_AstalHyprlandBind*)Handle, value ? 1 : 0);
        }

        public string? Description
        {
            get => MarshalString(AstalHyprlandInterop.astal_hyprland_bind_get_description((_AstalHyprlandBind*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalHyprlandInterop.astal_hyprland_bind_set_description((_AstalHyprlandBind*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? Dispatcher
        {
            get => MarshalString(AstalHyprlandInterop.astal_hyprland_bind_get_dispatcher((_AstalHyprlandBind*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalHyprlandInterop.astal_hyprland_bind_set_dispatcher((_AstalHyprlandBind*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? Arg
        {
            get => MarshalString(AstalHyprlandInterop.astal_hyprland_bind_get_arg((_AstalHyprlandBind*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalHyprlandInterop.astal_hyprland_bind_set_arg((_AstalHyprlandBind*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }
    }

    public unsafe class Workspace : GObjectWrapper
    {
        internal Workspace(_AstalHyprlandWorkspace* handle, bool owned = true) : base(handle, owned) { }

        public int Id => AstalHyprlandInterop.astal_hyprland_workspace_get_id((_AstalHyprlandWorkspace*)Handle);
        public string? Name => MarshalString(AstalHyprlandInterop.astal_hyprland_workspace_get_name((_AstalHyprlandWorkspace*)Handle));
        public Monitor Monitor => new Monitor(AstalHyprlandInterop.astal_hyprland_workspace_get_monitor((_AstalHyprlandWorkspace*)Handle), owned: false);
        public bool HasFullscreen => AstalHyprlandInterop.astal_hyprland_workspace_get_has_fullscreen((_AstalHyprlandWorkspace*)Handle) != 0;
        public Client? LastClient
        {
            get
            {
                var handle = AstalHyprlandInterop.astal_hyprland_workspace_get_last_client((_AstalHyprlandWorkspace*)Handle);
                return handle != null ? new Client(handle, owned: false) : null;
            }
        }

        public void Focus() => AstalHyprlandInterop.astal_hyprland_workspace_focus((_AstalHyprlandWorkspace*)Handle);

        public List<Client> Clients
        {
            get
            {
                var list = new List<Client>();
                _GList* gList = AstalHyprlandInterop.astal_hyprland_workspace_get_clients((_AstalHyprlandWorkspace*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new Client((_AstalHyprlandClient*)data, owned: false));
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

    public unsafe class Monitor : GObjectWrapper
    {
        internal Monitor(_AstalHyprlandMonitor* handle, bool owned = true) : base(handle, owned) { }

        public int Id => AstalHyprlandInterop.astal_hyprland_monitor_get_id((_AstalHyprlandMonitor*)Handle);
        public string? Name => MarshalString(AstalHyprlandInterop.astal_hyprland_monitor_get_name((_AstalHyprlandMonitor*)Handle));
        public string? Description => MarshalString(AstalHyprlandInterop.astal_hyprland_monitor_get_description((_AstalHyprlandMonitor*)Handle));
        public string? Make => MarshalString(AstalHyprlandInterop.astal_hyprland_monitor_get_make((_AstalHyprlandMonitor*)Handle));
        public string? Model => MarshalString(AstalHyprlandInterop.astal_hyprland_monitor_get_model((_AstalHyprlandMonitor*)Handle));
        public string? Serial => MarshalString(AstalHyprlandInterop.astal_hyprland_monitor_get_serial((_AstalHyprlandMonitor*)Handle));
        public int Width => AstalHyprlandInterop.astal_hyprland_monitor_get_width((_AstalHyprlandMonitor*)Handle);
        public int Height => AstalHyprlandInterop.astal_hyprland_monitor_get_height((_AstalHyprlandMonitor*)Handle);
        public double RefreshRate => AstalHyprlandInterop.astal_hyprland_monitor_get_refresh_rate((_AstalHyprlandMonitor*)Handle);
        public int X => AstalHyprlandInterop.astal_hyprland_monitor_get_x((_AstalHyprlandMonitor*)Handle);
        public int Y => AstalHyprlandInterop.astal_hyprland_monitor_get_y((_AstalHyprlandMonitor*)Handle);
        public Workspace ActiveWorkspace => new Workspace(AstalHyprlandInterop.astal_hyprland_monitor_get_active_workspace((_AstalHyprlandMonitor*)Handle), owned: false);
        public Workspace? SpecialWorkspace
        {
            get
            {
                var handle = AstalHyprlandInterop.astal_hyprland_monitor_get_special_workspace((_AstalHyprlandMonitor*)Handle);
                return handle != null ? new Workspace(handle, owned: false) : null;
            }
        }
        public int ReservedTop => AstalHyprlandInterop.astal_hyprland_monitor_get_reserved_top((_AstalHyprlandMonitor*)Handle);
        public int ReservedBottom => AstalHyprlandInterop.astal_hyprland_monitor_get_reserved_bottom((_AstalHyprlandMonitor*)Handle);
        public int ReservedLeft => AstalHyprlandInterop.astal_hyprland_monitor_get_reserved_left((_AstalHyprlandMonitor*)Handle);
        public int ReservedRight => AstalHyprlandInterop.astal_hyprland_monitor_get_reserved_right((_AstalHyprlandMonitor*)Handle);
        public double Scale => AstalHyprlandInterop.astal_hyprland_monitor_get_scale((_AstalHyprlandMonitor*)Handle);
        public AstalHyprlandMonitorTransform Transform => AstalHyprlandInterop.astal_hyprland_monitor_get_transform((_AstalHyprlandMonitor*)Handle);
        public bool Focused => AstalHyprlandInterop.astal_hyprland_monitor_get_focused((_AstalHyprlandMonitor*)Handle) != 0;
        public bool DpmsStatus => AstalHyprlandInterop.astal_hyprland_monitor_get_dpms_status((_AstalHyprlandMonitor*)Handle) != 0;
        public bool Vrr => AstalHyprlandInterop.astal_hyprland_monitor_get_vrr((_AstalHyprlandMonitor*)Handle) != 0;
        public bool ActivelyTearing => AstalHyprlandInterop.astal_hyprland_monitor_get_actively_tearing((_AstalHyprlandMonitor*)Handle) != 0;
        public bool Disabled => AstalHyprlandInterop.astal_hyprland_monitor_get_disabled((_AstalHyprlandMonitor*)Handle) != 0;
        public string? CurrentFormat => MarshalString(AstalHyprlandInterop.astal_hyprland_monitor_get_current_format((_AstalHyprlandMonitor*)Handle));

        public void Focus() => AstalHyprlandInterop.astal_hyprland_monitor_focus((_AstalHyprlandMonitor*)Handle);
    }

    public unsafe class Client : GObjectWrapper
    {
        internal Client(_AstalHyprlandClient* handle, bool owned = true) : base(handle, owned) { }

        public string? Address => MarshalString(AstalHyprlandInterop.astal_hyprland_client_get_address((_AstalHyprlandClient*)Handle));
        public bool Mapped => AstalHyprlandInterop.astal_hyprland_client_get_mapped((_AstalHyprlandClient*)Handle) != 0;
        public bool Hidden => AstalHyprlandInterop.astal_hyprland_client_get_hidden((_AstalHyprlandClient*)Handle) != 0;
        public int X => AstalHyprlandInterop.astal_hyprland_client_get_x((_AstalHyprlandClient*)Handle);
        public int Y => AstalHyprlandInterop.astal_hyprland_client_get_y((_AstalHyprlandClient*)Handle);
        public int Width => AstalHyprlandInterop.astal_hyprland_client_get_width((_AstalHyprlandClient*)Handle);
        public int Height => AstalHyprlandInterop.astal_hyprland_client_get_height((_AstalHyprlandClient*)Handle);
        public Workspace Workspace => new Workspace(AstalHyprlandInterop.astal_hyprland_client_get_workspace((_AstalHyprlandClient*)Handle), owned: false);
        public bool Floating => AstalHyprlandInterop.astal_hyprland_client_get_floating((_AstalHyprlandClient*)Handle) != 0;
        public Monitor Monitor => new Monitor(AstalHyprlandInterop.astal_hyprland_client_get_monitor((_AstalHyprlandClient*)Handle), owned: false);
        public string? Class => MarshalString(AstalHyprlandInterop.astal_hyprland_client_get_class((_AstalHyprlandClient*)Handle));
        public string? Title => MarshalString(AstalHyprlandInterop.astal_hyprland_client_get_title((_AstalHyprlandClient*)Handle));
        public string? InitialClass => MarshalString(AstalHyprlandInterop.astal_hyprland_client_get_initial_class((_AstalHyprlandClient*)Handle));
        public string? InitialTitle => MarshalString(AstalHyprlandInterop.astal_hyprland_client_get_initial_title((_AstalHyprlandClient*)Handle));
        public uint Pid => AstalHyprlandInterop.astal_hyprland_client_get_pid((_AstalHyprlandClient*)Handle);
        public bool Xwayland => AstalHyprlandInterop.astal_hyprland_client_get_xwayland((_AstalHyprlandClient*)Handle) != 0;
        public bool Pinned => AstalHyprlandInterop.astal_hyprland_client_get_pinned((_AstalHyprlandClient*)Handle) != 0;
        public AstalHyprlandFullscreen Fullscreen => AstalHyprlandInterop.astal_hyprland_client_get_fullscreen((_AstalHyprlandClient*)Handle);
        public string? Swallowing => MarshalString(AstalHyprlandInterop.astal_hyprland_client_get_swallowing((_AstalHyprlandClient*)Handle));
        public int FocusHistoryId => AstalHyprlandInterop.astal_hyprland_client_get_focus_history_id((_AstalHyprlandClient*)Handle);

        public void Kill() => AstalHyprlandInterop.astal_hyprland_client_kill((_AstalHyprlandClient*)Handle);
        public void Focus() => AstalHyprlandInterop.astal_hyprland_client_focus((_AstalHyprlandClient*)Handle);
        public void MoveTo(Workspace ws) => AstalHyprlandInterop.astal_hyprland_client_move_to((_AstalHyprlandClient*)Handle, (_AstalHyprlandWorkspace*)ws.Handle);
        public void ToggleFloating() => AstalHyprlandInterop.astal_hyprland_client_toggle_floating((_AstalHyprlandClient*)Handle);
    }

    public unsafe class Hyprland : GObjectWrapper
    {
        public static Hyprland Default => new Hyprland(AstalHyprlandInterop.astal_hyprland_get_default(), owned: false);

        public Hyprland() : base(AstalHyprlandInterop.astal_hyprland_hyprland_new()) { }
        internal Hyprland(_AstalHyprlandHyprland* handle, bool owned = true) : base(handle, owned) { }

        public Workspace FocusedWorkspace => new Workspace(AstalHyprlandInterop.astal_hyprland_hyprland_get_focused_workspace((_AstalHyprlandHyprland*)Handle), owned: false);
        public Monitor FocusedMonitor => new Monitor(AstalHyprlandInterop.astal_hyprland_hyprland_get_focused_monitor((_AstalHyprlandHyprland*)Handle), owned: false);
        public Client? FocusedClient
        {
            get
            {
                var handle = AstalHyprlandInterop.astal_hyprland_hyprland_get_focused_client((_AstalHyprlandHyprland*)Handle);
                return handle != null ? new Client(handle, owned: false) : null;
            }
        }
        public Position CursorPosition => new Position(AstalHyprlandInterop.astal_hyprland_hyprland_get_cursor_position((_AstalHyprlandHyprland*)Handle), owned: false);

        public string? Message(string message)
        {
            IntPtr nativeMsg = Marshal.StringToHGlobalAnsi(message);
            try
            {
                return MarshalStringOwned(AstalHyprlandInterop.astal_hyprland_hyprland_message((_AstalHyprlandHyprland*)Handle, (sbyte*)nativeMsg));
            }
            finally
            {
                Marshal.FreeHGlobal(nativeMsg);
            }
        }

        public void Dispatch(string dispatcher, string args)
        {
            IntPtr nativeDisp = Marshal.StringToHGlobalAnsi(dispatcher);
            IntPtr nativeArgs = Marshal.StringToHGlobalAnsi(args);
            try
            {
                AstalHyprlandInterop.astal_hyprland_hyprland_dispatch((_AstalHyprlandHyprland*)Handle, (sbyte*)nativeDisp, (sbyte*)nativeArgs);
            }
            finally
            {
                Marshal.FreeHGlobal(nativeDisp);
                Marshal.FreeHGlobal(nativeArgs);
            }
        }

        public void MoveCursor(int x, int y) => AstalHyprlandInterop.astal_hyprland_hyprland_move_cursor((_AstalHyprlandHyprland*)Handle, x, y);

        public List<Monitor> Monitors
        {
            get
            {
                var list = new List<Monitor>();
                _GList* gList = AstalHyprlandInterop.astal_hyprland_hyprland_get_monitors((_AstalHyprlandHyprland*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new Monitor((_AstalHyprlandMonitor*)data, owned: false));
                }
                return list;
            }
        }

        public List<Workspace> Workspaces
        {
            get
            {
                var list = new List<Workspace>();
                _GList* gList = AstalHyprlandInterop.astal_hyprland_hyprland_get_workspaces((_AstalHyprlandHyprland*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new Workspace((_AstalHyprlandWorkspace*)data, owned: false));
                }
                return list;
            }
        }

        public List<Client> Clients
        {
            get
            {
                var list = new List<Client>();
                _GList* gList = AstalHyprlandInterop.astal_hyprland_hyprland_get_clients((_AstalHyprlandHyprland*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new Client((_AstalHyprlandClient*)data, owned: false));
                }
                return list;
            }
        }

        public List<Bind> Binds
        {
            get
            {
                var list = new List<Bind>();
                _GList* gList = AstalHyprlandInterop.astal_hyprland_hyprland_get_binds((_AstalHyprlandHyprland*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new Bind((_AstalHyprlandBind*)data, owned: false));
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
