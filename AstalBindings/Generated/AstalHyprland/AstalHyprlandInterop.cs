using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalHyprland
{
    public static unsafe partial class AstalHyprlandInterop
    {
        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_hyprland_client_get_type();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_client_kill([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_client_focus([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_hyprland_workspace_get_type();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_client_move_to([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self, [NativeTypeName("AstalHyprlandWorkspace *")] _AstalHyprlandWorkspace* ws);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_client_toggle_floating([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandClient *")]
        public static extern _AstalHyprlandClient* astal_hyprland_client_new();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandClient *")]
        public static extern _AstalHyprlandClient* astal_hyprland_client_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_client_get_address([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_client_get_mapped([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_client_get_hidden([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_client_get_x([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_client_get_y([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_client_get_width([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_client_get_height([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_client_get_workspace([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_client_get_floating([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_hyprland_monitor_get_type();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandMonitor *")]
        public static extern _AstalHyprlandMonitor* astal_hyprland_client_get_monitor([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_client_get_class([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_client_get_title([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_client_get_initial_class([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_client_get_initial_title([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_hyprland_client_get_pid([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_client_get_xwayland([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_client_get_pinned([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_hyprland_fullscreen_get_type();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalHyprlandFullscreen astal_hyprland_client_get_fullscreen([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalHyprlandFullscreen astal_hyprland_client_get_fullscreen_client([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_client_get_swallowing([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_client_get_focus_history_id([NativeTypeName("AstalHyprlandClient *")] _AstalHyprlandClient* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_hyprland_hyprland_get_type();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandHyprland *")]
        public static extern _AstalHyprlandHyprland* astal_hyprland_get_default();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandHyprland *")]
        public static extern _AstalHyprlandHyprland* astal_hyprland_hyprland_get_default();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandMonitor *")]
        public static extern _AstalHyprlandMonitor* astal_hyprland_hyprland_get_monitor([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("gint")] int id);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_hyprland_get_workspace([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("gint")] int id);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandClient *")]
        public static extern _AstalHyprlandClient* astal_hyprland_hyprland_get_client([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("const gchar *")] sbyte* address);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandMonitor *")]
        public static extern _AstalHyprlandMonitor* astal_hyprland_hyprland_get_monitor_by_name([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("const gchar *")] sbyte* name);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_hyprland_get_workspace_by_name([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("const gchar *")] sbyte* name);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_hyprland_hyprland_message([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("const gchar *")] sbyte* message);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_hyprland_message_async([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("const gchar *")] sbyte* message, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_hyprland_hyprland_message_finish([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_hyprland_dispatch([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("const gchar *")] sbyte* dispatcher, [NativeTypeName("const gchar *")] sbyte* args);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_hyprland_move_cursor([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("gint")] int x, [NativeTypeName("gint")] int y);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_hyprland_sync_monitors([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_hyprland_sync_monitors_finish([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_hyprland_sync_workspaces([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_hyprland_sync_workspaces_finish([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_hyprland_sync_clients([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_hyprland_sync_clients_finish([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandHyprland *")]
        public static extern _AstalHyprlandHyprland* astal_hyprland_hyprland_new();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandHyprland *")]
        public static extern _AstalHyprlandHyprland* astal_hyprland_hyprland_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_hyprland_hyprland_get_monitors([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_hyprland_hyprland_get_workspaces([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_hyprland_hyprland_get_clients([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_hyprland_get_focused_workspace([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandMonitor *")]
        public static extern _AstalHyprlandMonitor* astal_hyprland_hyprland_get_focused_monitor([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandClient *")]
        public static extern _AstalHyprlandClient* astal_hyprland_hyprland_get_focused_client([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_hyprland_bind_get_type();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_hyprland_hyprland_get_binds([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_hyprland_position_get_type();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandPosition *")]
        public static extern _AstalHyprlandPosition* astal_hyprland_hyprland_get_cursor_position([NativeTypeName("AstalHyprlandHyprland *")] _AstalHyprlandHyprland* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_hyprland_monitor_transform_get_type();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_monitor_focus([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandMonitor *")]
        public static extern _AstalHyprlandMonitor* astal_hyprland_monitor_new();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandMonitor *")]
        public static extern _AstalHyprlandMonitor* astal_hyprland_monitor_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_monitor_get_id([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_monitor_get_name([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_monitor_get_description([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_monitor_get_make([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_monitor_get_model([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_monitor_get_serial([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_monitor_get_width([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_monitor_get_height([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_hyprland_monitor_get_refresh_rate([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_monitor_get_x([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_monitor_get_y([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_monitor_get_active_workspace([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_monitor_get_special_workspace([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_monitor_get_reserved_top([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_monitor_get_reserved_bottom([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_monitor_get_reserved_left([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_monitor_get_reserved_right([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_hyprland_monitor_get_scale([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalHyprlandMonitorTransform astal_hyprland_monitor_get_transform([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_monitor_get_focused([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_monitor_get_dpms_status([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_monitor_get_vrr([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_monitor_get_actively_tearing([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_monitor_get_disabled([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_monitor_get_current_format([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GArray *")]
        public static extern _GArray* astal_hyprland_monitor_get_available_modes([NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandBind *")]
        public static extern _AstalHyprlandBind* astal_hyprland_bind_new();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandBind *")]
        public static extern _AstalHyprlandBind* astal_hyprland_bind_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_bind_get_locked([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_locked([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_bind_get_mouse([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_mouse([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_bind_get_release([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_release([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_bind_get_repeat([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_repeat([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_bind_get_long_press([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_long_press([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_bind_get_non_consuming([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_non_consuming([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_bind_get_has_description([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_has_description([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint64")]
        public static extern nint astal_hyprland_bind_get_modmask([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_modmask([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gint64")] nint value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_bind_get_submap([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_submap([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_bind_get_key([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_key([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint64")]
        public static extern nint astal_hyprland_bind_get_keycode([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_keycode([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gint64")] nint value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_bind_get_catch_all([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_catch_all([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_bind_get_description([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_description([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_bind_get_dispatcher([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_dispatcher([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_bind_get_arg([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_bind_set_arg([NativeTypeName("AstalHyprlandBind *")] _AstalHyprlandBind* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandPosition *")]
        public static extern _AstalHyprlandPosition* astal_hyprland_position_new();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandPosition *")]
        public static extern _AstalHyprlandPosition* astal_hyprland_position_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_position_get_x([NativeTypeName("AstalHyprlandPosition *")] _AstalHyprlandPosition* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_position_set_x([NativeTypeName("AstalHyprlandPosition *")] _AstalHyprlandPosition* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_position_get_y([NativeTypeName("AstalHyprlandPosition *")] _AstalHyprlandPosition* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_position_set_y([NativeTypeName("AstalHyprlandPosition *")] _AstalHyprlandPosition* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_workspace_new_dummy([NativeTypeName("gint")] int id, [NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* monitor);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_workspace_construct_dummy([NativeTypeName("GType")] nuint object_type, [NativeTypeName("gint")] int id, [NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* monitor);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_workspace_focus([NativeTypeName("AstalHyprlandWorkspace *")] _AstalHyprlandWorkspace* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hyprland_workspace_move_to([NativeTypeName("AstalHyprlandWorkspace *")] _AstalHyprlandWorkspace* self, [NativeTypeName("AstalHyprlandMonitor *")] _AstalHyprlandMonitor* m);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_workspace_new();

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandWorkspace *")]
        public static extern _AstalHyprlandWorkspace* astal_hyprland_workspace_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_hyprland_workspace_get_id([NativeTypeName("AstalHyprlandWorkspace *")] _AstalHyprlandWorkspace* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_hyprland_workspace_get_name([NativeTypeName("AstalHyprlandWorkspace *")] _AstalHyprlandWorkspace* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandMonitor *")]
        public static extern _AstalHyprlandMonitor* astal_hyprland_workspace_get_monitor([NativeTypeName("AstalHyprlandWorkspace *")] _AstalHyprlandWorkspace* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_hyprland_workspace_get_clients([NativeTypeName("AstalHyprlandWorkspace *")] _AstalHyprlandWorkspace* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_hyprland_workspace_get_has_fullscreen([NativeTypeName("AstalHyprlandWorkspace *")] _AstalHyprlandWorkspace* self);

        [DllImport("libastal-hyprland-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHyprlandClient *")]
        public static extern _AstalHyprlandClient* astal_hyprland_workspace_get_last_client([NativeTypeName("AstalHyprlandWorkspace *")] _AstalHyprlandWorkspace* self);

        [NativeTypeName("#define ASTAL_HYPRLAND_MAJOR_VERSION 0")]
        public const int ASTAL_HYPRLAND_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_HYPRLAND_MINOR_VERSION 1")]
        public const int ASTAL_HYPRLAND_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_HYPRLAND_MICRO_VERSION 0")]
        public const int ASTAL_HYPRLAND_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_HYPRLAND_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_HYPRLAND_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_HYPRLAND_TYPE_CLIENT (astal_hyprland_client_get_type ())")]
        public static readonly nuint ASTAL_HYPRLAND_TYPE_CLIENT = (astal_hyprland_client_get_type());

        [NativeTypeName("#define ASTAL_HYPRLAND_TYPE_WORKSPACE (astal_hyprland_workspace_get_type ())")]
        public static readonly nuint ASTAL_HYPRLAND_TYPE_WORKSPACE = (astal_hyprland_workspace_get_type());

        [NativeTypeName("#define ASTAL_HYPRLAND_TYPE_MONITOR (astal_hyprland_monitor_get_type ())")]
        public static readonly nuint ASTAL_HYPRLAND_TYPE_MONITOR = (astal_hyprland_monitor_get_type());

        [NativeTypeName("#define ASTAL_HYPRLAND_TYPE_FULLSCREEN (astal_hyprland_fullscreen_get_type ())")]
        public static readonly nuint ASTAL_HYPRLAND_TYPE_FULLSCREEN = (astal_hyprland_fullscreen_get_type());

        [NativeTypeName("#define ASTAL_HYPRLAND_TYPE_HYPRLAND (astal_hyprland_hyprland_get_type ())")]
        public static readonly nuint ASTAL_HYPRLAND_TYPE_HYPRLAND = (astal_hyprland_hyprland_get_type());

        [NativeTypeName("#define ASTAL_HYPRLAND_TYPE_BIND (astal_hyprland_bind_get_type ())")]
        public static readonly nuint ASTAL_HYPRLAND_TYPE_BIND = (astal_hyprland_bind_get_type());

        [NativeTypeName("#define ASTAL_HYPRLAND_TYPE_POSITION (astal_hyprland_position_get_type ())")]
        public static readonly nuint ASTAL_HYPRLAND_TYPE_POSITION = (astal_hyprland_position_get_type());

        [NativeTypeName("#define ASTAL_HYPRLAND_MONITOR_TYPE_TRANSFORM (astal_hyprland_monitor_transform_get_type ())")]
        public static readonly nuint ASTAL_HYPRLAND_MONITOR_TYPE_TRANSFORM = (astal_hyprland_monitor_transform_get_type());
    }
}
