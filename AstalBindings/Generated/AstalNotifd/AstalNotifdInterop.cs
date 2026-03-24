using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalNotifd
{
    public static unsafe partial class AstalNotifdInterop
    {
        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_notifd_action_get_type();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdAction *")]
        public static extern _AstalNotifdAction* astal_notifd_action_new([NativeTypeName("const gchar *")] sbyte* id, [NativeTypeName("const gchar *")] sbyte* label);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdAction *")]
        public static extern _AstalNotifdAction* astal_notifd_action_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("const gchar *")] sbyte* id, [NativeTypeName("const gchar *")] sbyte* label);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_action_invoke([NativeTypeName("AstalNotifdAction *")] _AstalNotifdAction* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_notifd_action_get_id([NativeTypeName("AstalNotifdAction *")] _AstalNotifdAction* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_action_set_id([NativeTypeName("AstalNotifdAction *")] _AstalNotifdAction* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_notifd_action_get_label([NativeTypeName("AstalNotifdAction *")] _AstalNotifdAction* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_action_set_label([NativeTypeName("AstalNotifdAction *")] _AstalNotifdAction* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_notifd_urgency_get_type();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_notifd_closed_reason_get_type();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_notifd_state_get_type();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_notifd_notifd_get_type();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdNotifd *")]
        public static extern _AstalNotifdNotifd* astal_notifd_get_default();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdNotifd *")]
        public static extern _AstalNotifdNotifd* astal_notifd_notifd_get_default();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_notifd_notification_get_type();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdNotification *")]
        public static extern _AstalNotifdNotification* astal_notifd_notifd_get_notification([NativeTypeName("AstalNotifdNotifd *")] _AstalNotifdNotifd* self, [NativeTypeName("guint")] uint id);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdNotifd *")]
        public static extern _AstalNotifdNotifd* astal_notifd_notifd_new();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdNotifd *")]
        public static extern _AstalNotifdNotifd* astal_notifd_notifd_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_notifd_notifd_get_ignore_timeout([NativeTypeName("AstalNotifdNotifd *")] _AstalNotifdNotifd* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notifd_set_ignore_timeout([NativeTypeName("AstalNotifdNotifd *")] _AstalNotifdNotifd* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_notifd_notifd_get_dont_disturb([NativeTypeName("AstalNotifdNotifd *")] _AstalNotifdNotifd* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notifd_set_dont_disturb([NativeTypeName("AstalNotifdNotifd *")] _AstalNotifdNotifd* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_notifd_notifd_get_default_timeout([NativeTypeName("AstalNotifdNotifd *")] _AstalNotifdNotifd* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notifd_set_default_timeout([NativeTypeName("AstalNotifdNotifd *")] _AstalNotifdNotifd* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_notifd_notifd_get_notifications([NativeTypeName("AstalNotifdNotifd *")] _AstalNotifdNotifd* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_dismiss([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_expire([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_invoke([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* action_id);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdNotification *")]
        public static extern _AstalNotifdNotification* astal_notifd_notification_add_action([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("AstalNotifdAction *")] _AstalNotifdAction* action);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdNotification *")]
        public static extern _AstalNotifdNotification* astal_notifd_notification_set_hint([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* name, [NativeTypeName("GVariant *")] _GVariant* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GVariant *")]
        public static extern _GVariant* astal_notifd_notification_get_hint([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* name);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdNotification *")]
        public static extern _AstalNotifdNotification* astal_notifd_notification_new();

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNotifdNotification *")]
        public static extern _AstalNotifdNotification* astal_notifd_notification_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNotifdState astal_notifd_notification_get_state([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint64")]
        public static extern nint astal_notifd_notification_get_time([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint32")]
        public static extern uint astal_notifd_notification_get_id([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_id([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("guint32")] uint value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_notifd_notification_get_app_name([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_app_name([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_notifd_notification_get_app_icon([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_app_icon([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_notifd_notification_get_summary([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_summary([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_notifd_notification_get_body([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_body([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint32")]
        public static extern int astal_notifd_notification_get_expire_timeout([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_expire_timeout([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("gint32")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_notifd_notification_get_actions([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GVariant *")]
        public static extern _GVariant* astal_notifd_notification_get_hints([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_notifd_notification_get_image([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_image([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_notifd_notification_get_action_icons([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_action_icons([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_notifd_notification_get_category([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_category([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_notifd_notification_get_desktop_entry([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_desktop_entry([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_notifd_notification_get_resident([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_resident([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_notifd_notification_get_sound_file([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_sound_file([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_notifd_notification_get_sound_name([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_sound_name([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_notifd_notification_get_suppress_sound([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_suppress_sound([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_notifd_notification_get_transient([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_transient([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_notifd_notification_get_x([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_x([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_notifd_notification_get_y([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_y([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNotifdUrgency astal_notifd_notification_get_urgency([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_notification_set_urgency([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* self, AstalNotifdUrgency value);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_send_notification([NativeTypeName("AstalNotifdNotification *")] _AstalNotifdNotification* notification, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-notifd-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_notifd_send_notification_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [NativeTypeName("#define ASTAL_NOTIFD_MAJOR_VERSION 0")]
        public const int ASTAL_NOTIFD_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_NOTIFD_MINOR_VERSION 1")]
        public const int ASTAL_NOTIFD_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_NOTIFD_MICRO_VERSION 0")]
        public const int ASTAL_NOTIFD_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_NOTIFD_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_NOTIFD_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_NOTIFD_TYPE_ACTION (astal_notifd_action_get_type ())")]
        public static readonly nuint ASTAL_NOTIFD_TYPE_ACTION = (astal_notifd_action_get_type());

        [NativeTypeName("#define ASTAL_NOTIFD_TYPE_URGENCY (astal_notifd_urgency_get_type ())")]
        public static readonly nuint ASTAL_NOTIFD_TYPE_URGENCY = (astal_notifd_urgency_get_type());

        [NativeTypeName("#define ASTAL_NOTIFD_TYPE_CLOSED_REASON (astal_notifd_closed_reason_get_type ())")]
        public static readonly nuint ASTAL_NOTIFD_TYPE_CLOSED_REASON = (astal_notifd_closed_reason_get_type());

        [NativeTypeName("#define ASTAL_NOTIFD_TYPE_STATE (astal_notifd_state_get_type ())")]
        public static readonly nuint ASTAL_NOTIFD_TYPE_STATE = (astal_notifd_state_get_type());

        [NativeTypeName("#define ASTAL_NOTIFD_TYPE_NOTIFD (astal_notifd_notifd_get_type ())")]
        public static readonly nuint ASTAL_NOTIFD_TYPE_NOTIFD = (astal_notifd_notifd_get_type());

        [NativeTypeName("#define ASTAL_NOTIFD_TYPE_NOTIFICATION (astal_notifd_notification_get_type ())")]
        public static readonly nuint ASTAL_NOTIFD_TYPE_NOTIFICATION = (astal_notifd_notification_get_type());
    }
}
