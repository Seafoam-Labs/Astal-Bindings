using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalGtk4
{
    public static unsafe partial class AstalGtk4Interop
    {
        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_bin_get_type();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBin *")]
        public static extern _AstalBin* astal_bin_new();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBin *")]
        public static extern _AstalBin* astal_bin_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWidget *")]
        public static extern _GtkWidget* astal_bin_get_child([NativeTypeName("AstalBin *")] _AstalBin* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bin_set_child([NativeTypeName("AstalBin *")] _AstalBin* self, [NativeTypeName("GtkWidget *")] _GtkWidget* value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_box_get_type();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBox *")]
        public static extern _AstalBox* astal_box_new();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBox *")]
        public static extern _AstalBox* astal_box_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_box_get_vertical([NativeTypeName("AstalBox *")] _AstalBox* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_box_set_vertical([NativeTypeName("AstalBox *")] _AstalBox* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_box_get_children([NativeTypeName("AstalBox *")] _AstalBox* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_box_set_children([NativeTypeName("AstalBox *")] _AstalBox* self, [NativeTypeName("GList *")] _GList* value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWidget *")]
        public static extern _GtkWidget* astal_box_get_child([NativeTypeName("AstalBox *")] _AstalBox* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_box_set_child([NativeTypeName("AstalBox *")] _AstalBox* self, [NativeTypeName("GtkWidget *")] _GtkWidget* value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_slider_get_type();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalSlider *")]
        public static extern _AstalSlider* astal_slider_new();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalSlider *")]
        public static extern _AstalSlider* astal_slider_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_value([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_value([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_min([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_min([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_max([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_max([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_step([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_step([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_page([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_page([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_window_anchor_get_type();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_exclusivity_get_type();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_layer_get_type();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_keymode_get_type();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_window_get_type();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GdkMonitor *")]
        public static extern _GdkMonitor* astal_window_get_current_monitor([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalWindow *")]
        public static extern _AstalWindow* astal_window_new();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalWindow *")]
        public static extern _AstalWindow* astal_window_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_window_get_namespace([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_namespace([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalWindowAnchor astal_window_get_anchor([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_anchor([NativeTypeName("AstalWindow *")] _AstalWindow* self, AstalWindowAnchor value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalExclusivity astal_window_get_exclusivity([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_exclusivity([NativeTypeName("AstalWindow *")] _AstalWindow* self, AstalExclusivity value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalLayer astal_window_get_layer([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_layer([NativeTypeName("AstalWindow *")] _AstalWindow* self, AstalLayer value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalKeymode astal_window_get_keymode([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_keymode([NativeTypeName("AstalWindow *")] _AstalWindow* self, AstalKeymode value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GdkMonitor *")]
        public static extern _GdkMonitor* astal_window_get_gdkmonitor([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_gdkmonitor([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("GdkMonitor *")] _GdkMonitor* value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_margin_top([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin_top([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_margin_bottom([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin_bottom([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_margin_left([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin_left([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_margin_right([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin_right([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_monitor([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_monitor([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_application_get_type();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_application_register_object(void* @object, [NativeTypeName("GDBusConnection *")] _GDBusConnection* connection, [NativeTypeName("const gchar *")] sbyte* path, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_reset_css([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWindow *")]
        public static extern _GtkWindow* astal_application_get_window([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* name);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_apply_css([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* style, [NativeTypeName("gboolean")] int reset);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_add_icons([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* path);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_request([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* request, [NativeTypeName("GSocketConnection *")] _GSocketConnection* conn, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalApplication *")]
        public static extern _AstalApplication* astal_application_new();

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalApplication *")]
        public static extern _AstalApplication* astal_application_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_application_get_monitors([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_application_get_windows([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_application_get_gtk_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_set_gtk_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_application_get_icon_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_set_icon_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_application_get_cursor_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_set_cursor_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* value);

        [NativeTypeName("#define ASTAL_MAJOR_VERSION 4")]
        public const int ASTAL_MAJOR_VERSION = 4;

        [NativeTypeName("#define ASTAL_MINOR_VERSION 0")]
        public const int ASTAL_MINOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_MICRO_VERSION 0")]
        public const int ASTAL_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_VERSION \"4.0.0\"")]
        public static ReadOnlySpan<byte> ASTAL_VERSION => "4.0.0"u8;

        [NativeTypeName("#define ASTAL_TYPE_BIN (astal_bin_get_type ())")]
        public static readonly nuint ASTAL_TYPE_BIN = (astal_bin_get_type());

        [NativeTypeName("#define ASTAL_TYPE_BOX (astal_box_get_type ())")]
        public static readonly nuint ASTAL_TYPE_BOX = (astal_box_get_type());

        [NativeTypeName("#define ASTAL_TYPE_SLIDER (astal_slider_get_type ())")]
        public static readonly nuint ASTAL_TYPE_SLIDER = (astal_slider_get_type());

        [NativeTypeName("#define ASTAL_TYPE_WINDOW_ANCHOR (astal_window_anchor_get_type ())")]
        public static readonly nuint ASTAL_TYPE_WINDOW_ANCHOR = (astal_window_anchor_get_type());

        [NativeTypeName("#define ASTAL_TYPE_EXCLUSIVITY (astal_exclusivity_get_type ())")]
        public static readonly nuint ASTAL_TYPE_EXCLUSIVITY = (astal_exclusivity_get_type());

        [NativeTypeName("#define ASTAL_TYPE_LAYER (astal_layer_get_type ())")]
        public static readonly nuint ASTAL_TYPE_LAYER = (astal_layer_get_type());

        [NativeTypeName("#define ASTAL_TYPE_KEYMODE (astal_keymode_get_type ())")]
        public static readonly nuint ASTAL_TYPE_KEYMODE = (astal_keymode_get_type());

        [NativeTypeName("#define ASTAL_TYPE_WINDOW (astal_window_get_type ())")]
        public static readonly nuint ASTAL_TYPE_WINDOW = (astal_window_get_type());

        [NativeTypeName("#define ASTAL_TYPE_APPLICATION (astal_application_get_type ())")]
        public static readonly nuint ASTAL_TYPE_APPLICATION = (astal_application_get_type());
    }
}
