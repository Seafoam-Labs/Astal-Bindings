using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalIO
{
    public static unsafe partial class AstalIOInterop
    {
        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GQuark")]
        public static extern uint astal_io_app_error_quark();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_io_app_error_get_type();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_io_application_get_type();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_application_quit([NativeTypeName("AstalIOApplication *")] _AstalIOApplication* self, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_application_inspector([NativeTypeName("AstalIOApplication *")] _AstalIOApplication* self, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_application_toggle_window([NativeTypeName("AstalIOApplication *")] _AstalIOApplication* self, [NativeTypeName("const gchar *")] sbyte* window, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_application_acquire_socket([NativeTypeName("AstalIOApplication *")] _AstalIOApplication* self, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_application_request([NativeTypeName("AstalIOApplication *")] _AstalIOApplication* self, [NativeTypeName("const gchar *")] sbyte* request, [NativeTypeName("GSocketConnection *")] _GSocketConnection* conn, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_io_application_get_instance_name([NativeTypeName("AstalIOApplication *")] _AstalIOApplication* self);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_application_set_instance_name([NativeTypeName("AstalIOApplication *")] _AstalIOApplication* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GSocketService *")]
        public static extern _GSocketService* astal_io_acquire_socket([NativeTypeName("AstalIOApplication *")] _AstalIOApplication* app, [NativeTypeName("gchar **")] sbyte** sock, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_io_get_instances();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_quit_instance([NativeTypeName("const gchar *")] sbyte* instance, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_open_inspector([NativeTypeName("const gchar *")] sbyte* instance, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_toggle_window_by_name([NativeTypeName("const gchar *")] sbyte* instance, [NativeTypeName("const gchar *")] sbyte* window, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        [Obsolete]
        public static extern sbyte* astal_io_send_message([NativeTypeName("const gchar *")] sbyte* instance, [NativeTypeName("const gchar *")] sbyte* request, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_io_send_request([NativeTypeName("const gchar *")] sbyte* instance, [NativeTypeName("const gchar *")] sbyte* request, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_read_sock([NativeTypeName("GSocketConnection *")] _GSocketConnection* conn, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_io_read_sock_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_write_sock([NativeTypeName("GSocketConnection *")] _GSocketConnection* conn, [NativeTypeName("const gchar *")] sbyte* response, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_write_sock_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_io_daemon_get_type();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_io_daemon_register_object(void* @object, [NativeTypeName("GDBusConnection *")] _GDBusConnection* connection, [NativeTypeName("const gchar *")] sbyte* path, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_daemon_request([NativeTypeName("AstalIODaemon *")] _AstalIODaemon* self, [NativeTypeName("const gchar *")] sbyte* request, [NativeTypeName("GSocketConnection *")] _GSocketConnection* conn, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIODaemon *")]
        public static extern _AstalIODaemon* astal_io_daemon_new();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIODaemon *")]
        public static extern _AstalIODaemon* astal_io_daemon_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        [Obsolete]
        public static extern sbyte* astal_io_read_file([NativeTypeName("const gchar *")] sbyte* path);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void astal_io_read_file_async([NativeTypeName("const gchar *")] sbyte* path, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        [Obsolete]
        public static extern sbyte* astal_io_read_file_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void astal_io_write_file([NativeTypeName("const gchar *")] sbyte* path, [NativeTypeName("const gchar *")] sbyte* content);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void astal_io_write_file_async([NativeTypeName("const gchar *")] sbyte* path, [NativeTypeName("const gchar *")] sbyte* content, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void astal_io_write_file_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GFileMonitor *")]
        [Obsolete]
        public static extern _GFileMonitor* astal_io_monitor_file([NativeTypeName("const gchar *")] sbyte* path, [NativeTypeName("GClosure *")] _GClosure* callback);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_io_process_get_type();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_process_kill([NativeTypeName("AstalIOProcess *")] _AstalIOProcess* self);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_process_signal([NativeTypeName("AstalIOProcess *")] _AstalIOProcess* self, [NativeTypeName("gint")] int signal_num);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_process_write([NativeTypeName("AstalIOProcess *")] _AstalIOProcess* self, [NativeTypeName("const gchar *")] sbyte* @in, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_process_write_async([NativeTypeName("AstalIOProcess *")] _AstalIOProcess* self, [NativeTypeName("const gchar *")] sbyte* @in, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_process_write_finish([NativeTypeName("AstalIOProcess *")] _AstalIOProcess* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOProcess *")]
        public static extern _AstalIOProcess* astal_io_process_new([NativeTypeName("gchar **")] sbyte** cmd, [NativeTypeName("gint")] int cmd_length1, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOProcess *")]
        public static extern _AstalIOProcess* astal_io_process_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("gchar **")] sbyte** cmd, [NativeTypeName("gint")] int cmd_length1, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOProcess *")]
        public static extern _AstalIOProcess* astal_io_process_subprocessv([NativeTypeName("gchar **")] sbyte** cmd, [NativeTypeName("gint")] int cmd_length1, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOProcess *")]
        public static extern _AstalIOProcess* astal_io_process_subprocess([NativeTypeName("const gchar *")] sbyte* cmd, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_io_process_execv([NativeTypeName("gchar **")] sbyte** cmd, [NativeTypeName("gint")] int cmd_length1, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_io_process_exec([NativeTypeName("const gchar *")] sbyte* cmd, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_process_exec_asyncv([NativeTypeName("gchar **")] sbyte** cmd, [NativeTypeName("gint")] int cmd_length1, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_io_process_exec_asyncv_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_process_exec_async([NativeTypeName("const gchar *")] sbyte* cmd, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_io_process_exec_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_io_process_get_argv([NativeTypeName("AstalIOProcess *")] _AstalIOProcess* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_io_time_get_type();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_new_interval_prio([NativeTypeName("guint")] uint interval, [NativeTypeName("gint")] int prio, [NativeTypeName("GClosure *")] _GClosure* fn);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_construct_interval_prio([NativeTypeName("GType")] nuint object_type, [NativeTypeName("guint")] uint interval, [NativeTypeName("gint")] int prio, [NativeTypeName("GClosure *")] _GClosure* fn);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_new_timeout_prio([NativeTypeName("guint")] uint timeout, [NativeTypeName("gint")] int prio, [NativeTypeName("GClosure *")] _GClosure* fn);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_construct_timeout_prio([NativeTypeName("GType")] nuint object_type, [NativeTypeName("guint")] uint timeout, [NativeTypeName("gint")] int prio, [NativeTypeName("GClosure *")] _GClosure* fn);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_new_idle_prio([NativeTypeName("gint")] int prio, [NativeTypeName("GClosure *")] _GClosure* fn);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_construct_idle_prio([NativeTypeName("GType")] nuint object_type, [NativeTypeName("gint")] int prio, [NativeTypeName("GClosure *")] _GClosure* fn);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_interval([NativeTypeName("guint")] uint interval, [NativeTypeName("GClosure *")] _GClosure* fn);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_timeout([NativeTypeName("guint")] uint timeout, [NativeTypeName("GClosure *")] _GClosure* fn);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_idle([NativeTypeName("GClosure *")] _GClosure* fn);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_time_cancel([NativeTypeName("AstalIOTime *")] _AstalIOTime* self);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_new();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOTime *")]
        public static extern _AstalIOTime* astal_io_time_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_io_variable_base_get_type();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_variable_base_emit_changed([NativeTypeName("AstalIOVariableBase *")] _AstalIOVariableBase* self);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_variable_base_emit_dropped([NativeTypeName("AstalIOVariableBase *")] _AstalIOVariableBase* self);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_variable_base_emit_error([NativeTypeName("AstalIOVariableBase *")] _AstalIOVariableBase* self, [NativeTypeName("const gchar *")] sbyte* err);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOVariableBase *")]
        public static extern _AstalIOVariableBase* astal_io_variable_base_new();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOVariableBase *")]
        public static extern _AstalIOVariableBase* astal_io_variable_base_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_io_variable_get_type();

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOVariable *")]
        public static extern _AstalIOVariable* astal_io_variable_new([NativeTypeName("GValue *")] _GValue* init);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOVariable *")]
        public static extern _AstalIOVariable* astal_io_variable_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("GValue *")] _GValue* init);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOVariable *")]
        public static extern _AstalIOVariable* astal_io_variable_poll([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self, [NativeTypeName("guint")] uint interval, [NativeTypeName("const gchar *")] sbyte* exec, [NativeTypeName("GClosure *")] _GClosure* transform, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOVariable *")]
        public static extern _AstalIOVariable* astal_io_variable_pollv([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self, [NativeTypeName("guint")] uint interval, [NativeTypeName("gchar **")] sbyte** execv, [NativeTypeName("gint")] int execv_length1, [NativeTypeName("GClosure *")] _GClosure* transform, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOVariable *")]
        public static extern _AstalIOVariable* astal_io_variable_pollfn([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self, [NativeTypeName("guint")] uint interval, [NativeTypeName("GClosure *")] _GClosure* fn, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOVariable *")]
        public static extern _AstalIOVariable* astal_io_variable_watch([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self, [NativeTypeName("const gchar *")] sbyte* exec, [NativeTypeName("GClosure *")] _GClosure* transform, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIOVariable *")]
        public static extern _AstalIOVariable* astal_io_variable_watchv([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self, [NativeTypeName("gchar **")] sbyte** execv, [NativeTypeName("gint")] int execv_length1, [NativeTypeName("GClosure *")] _GClosure* transform, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_variable_start_poll([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_variable_start_watch([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_variable_stop_poll([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_variable_stop_watch([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_io_variable_is_polling([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_io_variable_is_watching([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_variable_get_value([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self, [NativeTypeName("GValue *")] _GValue* result);

        [DllImport("libastal-io-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_io_variable_set_value([NativeTypeName("AstalIOVariable *")] _AstalIOVariable* self, [NativeTypeName("GValue *")] _GValue* value);

        [NativeTypeName("#define ASTAL_IO_MAJOR_VERSION 0")]
        public const int ASTAL_IO_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_IO_MINOR_VERSION 1")]
        public const int ASTAL_IO_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_IO_MICRO_VERSION 0")]
        public const int ASTAL_IO_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_IO_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_IO_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_IO_TYPE_APP_ERROR (astal_io_app_error_get_type ())")]
        public static readonly nuint ASTAL_IO_TYPE_APP_ERROR = (astal_io_app_error_get_type());

        [NativeTypeName("#define ASTAL_IO_TYPE_APPLICATION (astal_io_application_get_type ())")]
        public static readonly nuint ASTAL_IO_TYPE_APPLICATION = (astal_io_application_get_type());

        [NativeTypeName("#define ASTAL_IO_TYPE_DAEMON (astal_io_daemon_get_type ())")]
        public static readonly nuint ASTAL_IO_TYPE_DAEMON = (astal_io_daemon_get_type());

        [NativeTypeName("#define ASTAL_IO_TYPE_PROCESS (astal_io_process_get_type ())")]
        public static readonly nuint ASTAL_IO_TYPE_PROCESS = (astal_io_process_get_type());

        [NativeTypeName("#define ASTAL_IO_TYPE_TIME (astal_io_time_get_type ())")]
        public static readonly nuint ASTAL_IO_TYPE_TIME = (astal_io_time_get_type());

        [NativeTypeName("#define ASTAL_IO_TYPE_VARIABLE_BASE (astal_io_variable_base_get_type ())")]
        public static readonly nuint ASTAL_IO_TYPE_VARIABLE_BASE = (astal_io_variable_base_get_type());

        [NativeTypeName("#define ASTAL_IO_TYPE_VARIABLE (astal_io_variable_get_type ())")]
        public static readonly nuint ASTAL_IO_TYPE_VARIABLE = (astal_io_variable_get_type());

        [NativeTypeName("#define ASTAL_IO_APP_ERROR astal_io_app_error_quark ()")]
        public static readonly uint ASTAL_IO_APP_ERROR = astal_io_app_error_quark();
    }
}
