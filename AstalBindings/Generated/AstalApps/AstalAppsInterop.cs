using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalApps
{
    public static unsafe partial class AstalAppsInterop
    {
        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_apps_application_get_type();

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_apps_application_get_key([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self, [NativeTypeName("const gchar *")] sbyte* key);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_apps_application_launch([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_apps_score_get_type();

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalAppsScore *")]
        public static extern _AstalAppsScore* astal_apps_score_dup([NativeTypeName("const AstalAppsScore *")] _AstalAppsScore* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_score_free([NativeTypeName("AstalAppsScore *")] _AstalAppsScore* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_application_fuzzy_match([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self, [NativeTypeName("const gchar *")] sbyte* term, [NativeTypeName("AstalAppsScore *")] _AstalAppsScore* result);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_application_exact_match([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self, [NativeTypeName("const gchar *")] sbyte* term, [NativeTypeName("AstalAppsScore *")] _AstalAppsScore* result);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GDesktopAppInfo *")]
        public static extern _GDesktopAppInfo* astal_apps_application_get_app([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_application_set_app([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self, [NativeTypeName("GDesktopAppInfo *")] _GDesktopAppInfo* value);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_apps_application_get_frequency([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_application_set_frequency([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_apps_application_get_name([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_apps_application_get_entry([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_apps_application_get_description([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_apps_application_get_wm_class([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_apps_application_get_executable([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_apps_application_get_icon_name([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_apps_application_get_keywords([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_apps_application_get_categories([NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_apps_apps_get_type();

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_apps_apps_fuzzy_score([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("const gchar *")] sbyte* search, [NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* a);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_apps_apps_exact_score([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("const gchar *")] sbyte* search, [NativeTypeName("AstalAppsApplication *")] _AstalAppsApplication* a);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_apps_apps_fuzzy_query([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("const gchar *")] sbyte* search);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_apps_apps_exact_query([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("const gchar *")] sbyte* search);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_apps_reload([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalAppsApps *")]
        public static extern _AstalAppsApps* astal_apps_apps_new();

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalAppsApps *")]
        public static extern _AstalAppsApps* astal_apps_apps_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_apps_apps_get_show_hidden([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_apps_set_show_hidden([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_apps_apps_get_list([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_apps_apps_get_min_score([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_apps_set_min_score([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_apps_apps_get_name_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_apps_set_name_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_apps_apps_get_entry_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_apps_set_entry_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_apps_apps_get_executable_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_apps_set_executable_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_apps_apps_get_description_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_apps_set_description_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_apps_apps_get_keywords_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_apps_set_keywords_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_apps_apps_get_categories_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self);

        [DllImport("libastal-apps-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_apps_apps_set_categories_multiplier([NativeTypeName("AstalAppsApps *")] _AstalAppsApps* self, [NativeTypeName("gdouble")] double value);

        [NativeTypeName("#define ASTAL_APPS_MAJOR_VERSION 0")]
        public const int ASTAL_APPS_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_APPS_MINOR_VERSION 1")]
        public const int ASTAL_APPS_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_APPS_MICRO_VERSION 0")]
        public const int ASTAL_APPS_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_APPS_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_APPS_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_APPS_TYPE_APPLICATION (astal_apps_application_get_type ())")]
        public static readonly nuint ASTAL_APPS_TYPE_APPLICATION = (astal_apps_application_get_type());

        [NativeTypeName("#define ASTAL_APPS_TYPE_SCORE (astal_apps_score_get_type ())")]
        public static readonly nuint ASTAL_APPS_TYPE_SCORE = (astal_apps_score_get_type());

        [NativeTypeName("#define ASTAL_APPS_TYPE_APPS (astal_apps_apps_get_type ())")]
        public static readonly nuint ASTAL_APPS_TYPE_APPS = (astal_apps_apps_get_type());
    }
}
