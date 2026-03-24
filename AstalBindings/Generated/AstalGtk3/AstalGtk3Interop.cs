using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalGtk3
{
    public static unsafe partial class AstalGtk3Interop
    {
        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_box_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBox *")]
        public static extern _AstalBox* astal_box_new([NativeTypeName("gboolean")] int vertical, [NativeTypeName("GList *")] _GList* children);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBox *")]
        public static extern _AstalBox* astal_box_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("gboolean")] int vertical, [NativeTypeName("GList *")] _GList* children);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_box_get_vertical([NativeTypeName("AstalBox *")] _AstalBox* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_box_set_vertical([NativeTypeName("AstalBox *")] _AstalBox* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_box_get_children([NativeTypeName("AstalBox *")] _AstalBox* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_box_set_children([NativeTypeName("AstalBox *")] _AstalBox* self, [NativeTypeName("GList *")] _GList* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWidget *")]
        public static extern _GtkWidget* astal_box_get_child([NativeTypeName("AstalBox *")] _AstalBox* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_box_set_child([NativeTypeName("AstalBox *")] _AstalBox* self, [NativeTypeName("GtkWidget *")] _GtkWidget* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_button_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalButton *")]
        public static extern _AstalButton* astal_button_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalButton *")]
        public static extern _AstalButton* astal_button_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_mouse_button_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_click_event_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalClickEvent *")]
        public static extern _AstalClickEvent* astal_click_event_dup([NativeTypeName("const AstalClickEvent *")] _AstalClickEvent* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_click_event_free([NativeTypeName("AstalClickEvent *")] _AstalClickEvent* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_click_event_init([NativeTypeName("AstalClickEvent *")] _AstalClickEvent* self, [NativeTypeName("GdkEventButton *")] _GdkEventButton* @event);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_hover_event_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalHoverEvent *")]
        public static extern _AstalHoverEvent* astal_hover_event_dup([NativeTypeName("const AstalHoverEvent *")] _AstalHoverEvent* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hover_event_free([NativeTypeName("AstalHoverEvent *")] _AstalHoverEvent* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_hover_event_init([NativeTypeName("AstalHoverEvent *")] _AstalHoverEvent* self, [NativeTypeName("GdkEventCrossing *")] _GdkEventCrossing* @event);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_scroll_event_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalScrollEvent *")]
        public static extern _AstalScrollEvent* astal_scroll_event_dup([NativeTypeName("const AstalScrollEvent *")] _AstalScrollEvent* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_scroll_event_free([NativeTypeName("AstalScrollEvent *")] _AstalScrollEvent* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_scroll_event_init([NativeTypeName("AstalScrollEvent *")] _AstalScrollEvent* self, [NativeTypeName("GdkEventScroll *")] _GdkEventScroll* @event);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_center_box_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalCenterBox *")]
        public static extern _AstalCenterBox* astal_center_box_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalCenterBox *")]
        public static extern _AstalCenterBox* astal_center_box_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_center_box_get_vertical([NativeTypeName("AstalCenterBox *")] _AstalCenterBox* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_center_box_set_vertical([NativeTypeName("AstalCenterBox *")] _AstalCenterBox* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWidget *")]
        public static extern _GtkWidget* astal_center_box_get_start_widget([NativeTypeName("AstalCenterBox *")] _AstalCenterBox* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_center_box_set_start_widget([NativeTypeName("AstalCenterBox *")] _AstalCenterBox* self, [NativeTypeName("GtkWidget *")] _GtkWidget* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWidget *")]
        public static extern _GtkWidget* astal_center_box_get_end_widget([NativeTypeName("AstalCenterBox *")] _AstalCenterBox* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_center_box_set_end_widget([NativeTypeName("AstalCenterBox *")] _AstalCenterBox* self, [NativeTypeName("GtkWidget *")] _GtkWidget* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWidget *")]
        public static extern _GtkWidget* astal_center_box_get_center_widget([NativeTypeName("AstalCenterBox *")] _AstalCenterBox* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_center_box_set_center_widget([NativeTypeName("AstalCenterBox *")] _AstalCenterBox* self, [NativeTypeName("GtkWidget *")] _GtkWidget* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_circular_progress_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalCircularProgress *")]
        public static extern _AstalCircularProgress* astal_circular_progress_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalCircularProgress *")]
        public static extern _AstalCircularProgress* astal_circular_progress_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_circular_progress_get_start_at([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_circular_progress_set_start_at([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_circular_progress_get_end_at([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_circular_progress_set_end_at([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_circular_progress_get_value([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_circular_progress_set_value([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_circular_progress_get_inverted([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_circular_progress_set_inverted([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_circular_progress_get_rounded([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_circular_progress_set_rounded([NativeTypeName("AstalCircularProgress *")] _AstalCircularProgress* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_event_box_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalEventBox *")]
        public static extern _AstalEventBox* astal_event_box_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalEventBox *")]
        public static extern _AstalEventBox* astal_event_box_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_motion_event_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalMotionEvent *")]
        public static extern _AstalMotionEvent* astal_motion_event_dup([NativeTypeName("const AstalMotionEvent *")] _AstalMotionEvent* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_motion_event_free([NativeTypeName("AstalMotionEvent *")] _AstalMotionEvent* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_motion_event_init([NativeTypeName("AstalMotionEvent *")] _AstalMotionEvent* self, [NativeTypeName("GdkEventMotion *")] _GdkEventMotion* @event);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_icon_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkIconInfo *")]
        public static extern _GtkIconInfo* astal_icon_lookup_icon([NativeTypeName("const gchar *")] sbyte* icon);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIcon *")]
        public static extern _AstalIcon* astal_icon_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalIcon *")]
        public static extern _AstalIcon* astal_icon_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GdkPixbuf *")]
        public static extern _GdkPixbuf* astal_icon_get_pixbuf([NativeTypeName("AstalIcon *")] _AstalIcon* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_icon_set_pixbuf([NativeTypeName("AstalIcon *")] _AstalIcon* self, [NativeTypeName("GdkPixbuf *")] _GdkPixbuf* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GIcon *")]
        [Obsolete]
        public static extern _GIcon* astal_icon_get_g_icon([NativeTypeName("AstalIcon *")] _AstalIcon* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void astal_icon_set_g_icon([NativeTypeName("AstalIcon *")] _AstalIcon* self, [NativeTypeName("GIcon *")] _GIcon* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_icon_get_icon([NativeTypeName("AstalIcon *")] _AstalIcon* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_icon_set_icon([NativeTypeName("AstalIcon *")] _AstalIcon* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_label_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalLabel *")]
        public static extern _AstalLabel* astal_label_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalLabel *")]
        public static extern _AstalLabel* astal_label_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_label_get_truncate([NativeTypeName("AstalLabel *")] _AstalLabel* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_label_set_truncate([NativeTypeName("AstalLabel *")] _AstalLabel* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_label_get_justify_fill([NativeTypeName("AstalLabel *")] _AstalLabel* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_label_set_justify_fill([NativeTypeName("AstalLabel *")] _AstalLabel* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_level_bar_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalLevelBar *")]
        public static extern _AstalLevelBar* astal_level_bar_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalLevelBar *")]
        public static extern _AstalLevelBar* astal_level_bar_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_level_bar_get_vertical([NativeTypeName("AstalLevelBar *")] _AstalLevelBar* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_level_bar_set_vertical([NativeTypeName("AstalLevelBar *")] _AstalLevelBar* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_overlay_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_overlay_add_overlay([NativeTypeName("AstalOverlay *")] _AstalOverlay* self, [NativeTypeName("GtkWidget *")] _GtkWidget* widget);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalOverlay *")]
        public static extern _AstalOverlay* astal_overlay_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalOverlay *")]
        public static extern _AstalOverlay* astal_overlay_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_overlay_get_pass_through([NativeTypeName("AstalOverlay *")] _AstalOverlay* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_overlay_set_pass_through([NativeTypeName("AstalOverlay *")] _AstalOverlay* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWidget *")]
        public static extern _GtkWidget* astal_overlay_get_overlay([NativeTypeName("AstalOverlay *")] _AstalOverlay* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_overlay_set_overlay([NativeTypeName("AstalOverlay *")] _AstalOverlay* self, [NativeTypeName("GtkWidget *")] _GtkWidget* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_overlay_get_overlays([NativeTypeName("AstalOverlay *")] _AstalOverlay* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_overlay_set_overlays([NativeTypeName("AstalOverlay *")] _AstalOverlay* self, [NativeTypeName("GList *")] _GList* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWidget *")]
        public static extern _GtkWidget* astal_overlay_get_child([NativeTypeName("AstalOverlay *")] _AstalOverlay* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_overlay_set_child([NativeTypeName("AstalOverlay *")] _AstalOverlay* self, [NativeTypeName("GtkWidget *")] _GtkWidget* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_scrollable_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWidget *")]
        public static extern _GtkWidget* astal_scrollable_get_child([NativeTypeName("AstalScrollable *")] _AstalScrollable* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalScrollable *")]
        public static extern _AstalScrollable* astal_scrollable_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalScrollable *")]
        public static extern _AstalScrollable* astal_scrollable_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern GtkPolicyType astal_scrollable_get_hscroll([NativeTypeName("AstalScrollable *")] _AstalScrollable* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_scrollable_set_hscroll([NativeTypeName("AstalScrollable *")] _AstalScrollable* self, GtkPolicyType value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern GtkPolicyType astal_scrollable_get_vscroll([NativeTypeName("AstalScrollable *")] _AstalScrollable* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_scrollable_set_vscroll([NativeTypeName("AstalScrollable *")] _AstalScrollable* self, GtkPolicyType value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_slider_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalSlider *")]
        public static extern _AstalSlider* astal_slider_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalSlider *")]
        public static extern _AstalSlider* astal_slider_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_slider_get_vertical([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_vertical([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_slider_get_dragging([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_value([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_value([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_min([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_min([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_max([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_max([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_step([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_step([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_slider_get_page([NativeTypeName("AstalSlider *")] _AstalSlider* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_slider_set_page([NativeTypeName("AstalSlider *")] _AstalSlider* self, [NativeTypeName("gdouble")] double value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_stack_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalStack *")]
        public static extern _AstalStack* astal_stack_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalStack *")]
        public static extern _AstalStack* astal_stack_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_stack_get_shown([NativeTypeName("AstalStack *")] _AstalStack* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_stack_set_shown([NativeTypeName("AstalStack *")] _AstalStack* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_stack_get_children([NativeTypeName("AstalStack *")] _AstalStack* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_stack_set_children([NativeTypeName("AstalStack *")] _AstalStack* self, [NativeTypeName("GList *")] _GList* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_widget_set_css([NativeTypeName("GtkWidget *")] _GtkWidget* widget, [NativeTypeName("const gchar *")] sbyte* css);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_widget_get_css([NativeTypeName("GtkWidget *")] _GtkWidget* widget);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_widget_set_class_names([NativeTypeName("GtkWidget *")] _GtkWidget* widget, [NativeTypeName("gchar **")] sbyte** class_names, [NativeTypeName("gint")] int class_names_length1);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_widget_get_class_names([NativeTypeName("GtkWidget *")] _GtkWidget* widget);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_widget_toggle_class_name([NativeTypeName("GtkWidget *")] _GtkWidget* widget, [NativeTypeName("const gchar *")] sbyte* class_name, [NativeTypeName("gboolean")] int condition);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_widget_set_cursor([NativeTypeName("GtkWidget *")] _GtkWidget* widget, [NativeTypeName("const gchar *")] sbyte* cursor);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_widget_get_cursor([NativeTypeName("GtkWidget *")] _GtkWidget* widget);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_widget_set_click_through([NativeTypeName("GtkWidget *")] _GtkWidget* widget, [NativeTypeName("gboolean")] int click_through);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_widget_get_click_through([NativeTypeName("GtkWidget *")] _GtkWidget* widget);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_window_anchor_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_exclusivity_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_layer_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_keymode_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_window_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GdkMonitor *")]
        public static extern _GdkMonitor* astal_window_get_current_monitor([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalWindow *")]
        public static extern _AstalWindow* astal_window_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalWindow *")]
        public static extern _AstalWindow* astal_window_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_window_get_inhibit([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_inhibit([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_window_get_namespace([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_namespace([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalWindowAnchor astal_window_get_anchor([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_anchor([NativeTypeName("AstalWindow *")] _AstalWindow* self, AstalWindowAnchor value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalExclusivity astal_window_get_exclusivity([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_exclusivity([NativeTypeName("AstalWindow *")] _AstalWindow* self, AstalExclusivity value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalLayer astal_window_get_layer([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_layer([NativeTypeName("AstalWindow *")] _AstalWindow* self, AstalLayer value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalKeymode astal_window_get_keymode([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_keymode([NativeTypeName("AstalWindow *")] _AstalWindow* self, AstalKeymode value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GdkMonitor *")]
        public static extern _GdkMonitor* astal_window_get_gdkmonitor([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_gdkmonitor([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("GdkMonitor *")] _GdkMonitor* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_margin_top([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin_top([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_margin_bottom([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin_bottom([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_margin_left([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin_left([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_margin_right([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin_right([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_margin([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_window_get_monitor([NativeTypeName("AstalWindow *")] _AstalWindow* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_window_set_monitor([NativeTypeName("AstalWindow *")] _AstalWindow* self, [NativeTypeName("gint")] int value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_application_get_type();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_application_register_object(void* @object, [NativeTypeName("GDBusConnection *")] _GDBusConnection* connection, [NativeTypeName("const gchar *")] sbyte* path, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_reset_css([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GtkWindow *")]
        public static extern _GtkWindow* astal_application_get_window([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* name);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_apply_css([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* style, [NativeTypeName("gboolean")] int reset);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_add_icons([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* path);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_request([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* request, [NativeTypeName("GSocketConnection *")] _GSocketConnection* conn, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalApplication *")]
        public static extern _AstalApplication* astal_application_new();

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalApplication *")]
        public static extern _AstalApplication* astal_application_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_application_get_monitors([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_application_get_windows([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_application_get_gtk_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_set_gtk_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_application_get_icon_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_set_icon_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_application_get_cursor_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self);

        [DllImport("libastal-3.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_application_set_cursor_theme([NativeTypeName("AstalApplication *")] _AstalApplication* self, [NativeTypeName("const gchar *")] sbyte* value);

        [NativeTypeName("#define ASTAL_MAJOR_VERSION 3")]
        public const int ASTAL_MAJOR_VERSION = 3;

        [NativeTypeName("#define ASTAL_MINOR_VERSION 0")]
        public const int ASTAL_MINOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_MICRO_VERSION 0")]
        public const int ASTAL_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_VERSION \"3.0.0\"")]
        public static ReadOnlySpan<byte> ASTAL_VERSION => "3.0.0"u8;

        [NativeTypeName("#define ASTAL_TYPE_BOX (astal_box_get_type ())")]
        public static readonly nuint ASTAL_TYPE_BOX = (astal_box_get_type());

        [NativeTypeName("#define ASTAL_TYPE_BUTTON (astal_button_get_type ())")]
        public static readonly nuint ASTAL_TYPE_BUTTON = (astal_button_get_type());

        [NativeTypeName("#define ASTAL_TYPE_MOUSE_BUTTON (astal_mouse_button_get_type ())")]
        public static readonly nuint ASTAL_TYPE_MOUSE_BUTTON = (astal_mouse_button_get_type());

        [NativeTypeName("#define ASTAL_TYPE_CLICK_EVENT (astal_click_event_get_type ())")]
        public static readonly nuint ASTAL_TYPE_CLICK_EVENT = (astal_click_event_get_type());

        [NativeTypeName("#define ASTAL_TYPE_HOVER_EVENT (astal_hover_event_get_type ())")]
        public static readonly nuint ASTAL_TYPE_HOVER_EVENT = (astal_hover_event_get_type());

        [NativeTypeName("#define ASTAL_TYPE_SCROLL_EVENT (astal_scroll_event_get_type ())")]
        public static readonly nuint ASTAL_TYPE_SCROLL_EVENT = (astal_scroll_event_get_type());

        [NativeTypeName("#define ASTAL_TYPE_CENTER_BOX (astal_center_box_get_type ())")]
        public static readonly nuint ASTAL_TYPE_CENTER_BOX = (astal_center_box_get_type());

        [NativeTypeName("#define ASTAL_TYPE_CIRCULAR_PROGRESS (astal_circular_progress_get_type ())")]
        public static readonly nuint ASTAL_TYPE_CIRCULAR_PROGRESS = (astal_circular_progress_get_type());

        [NativeTypeName("#define ASTAL_TYPE_EVENT_BOX (astal_event_box_get_type ())")]
        public static readonly nuint ASTAL_TYPE_EVENT_BOX = (astal_event_box_get_type());

        [NativeTypeName("#define ASTAL_TYPE_MOTION_EVENT (astal_motion_event_get_type ())")]
        public static readonly nuint ASTAL_TYPE_MOTION_EVENT = (astal_motion_event_get_type());

        [NativeTypeName("#define ASTAL_TYPE_ICON (astal_icon_get_type ())")]
        public static readonly nuint ASTAL_TYPE_ICON = (astal_icon_get_type());

        [NativeTypeName("#define ASTAL_TYPE_LABEL (astal_label_get_type ())")]
        public static readonly nuint ASTAL_TYPE_LABEL = (astal_label_get_type());

        [NativeTypeName("#define ASTAL_TYPE_LEVEL_BAR (astal_level_bar_get_type ())")]
        public static readonly nuint ASTAL_TYPE_LEVEL_BAR = (astal_level_bar_get_type());

        [NativeTypeName("#define ASTAL_TYPE_OVERLAY (astal_overlay_get_type ())")]
        public static readonly nuint ASTAL_TYPE_OVERLAY = (astal_overlay_get_type());

        [NativeTypeName("#define ASTAL_TYPE_SCROLLABLE (astal_scrollable_get_type ())")]
        public static readonly nuint ASTAL_TYPE_SCROLLABLE = (astal_scrollable_get_type());

        [NativeTypeName("#define ASTAL_TYPE_SLIDER (astal_slider_get_type ())")]
        public static readonly nuint ASTAL_TYPE_SLIDER = (astal_slider_get_type());

        [NativeTypeName("#define ASTAL_TYPE_STACK (astal_stack_get_type ())")]
        public static readonly nuint ASTAL_TYPE_STACK = (astal_stack_get_type());

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
