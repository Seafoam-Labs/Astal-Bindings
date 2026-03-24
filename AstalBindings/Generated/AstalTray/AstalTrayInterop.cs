using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalTray
{
    public static unsafe partial class AstalTrayInterop
    {
        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_tray_pixmap_get_type();

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalTrayPixmap *")]
        public static extern _AstalTrayPixmap* astal_tray_pixmap_dup([NativeTypeName("const AstalTrayPixmap *")] _AstalTrayPixmap* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_pixmap_free([NativeTypeName("AstalTrayPixmap *")] _AstalTrayPixmap* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_pixmap_copy([NativeTypeName("const AstalTrayPixmap *")] _AstalTrayPixmap* self, [NativeTypeName("AstalTrayPixmap *")] _AstalTrayPixmap* dest);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_pixmap_destroy([NativeTypeName("AstalTrayPixmap *")] _AstalTrayPixmap* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_tray_tooltip_get_type();

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalTrayTooltip *")]
        public static extern _AstalTrayTooltip* astal_tray_tooltip_dup([NativeTypeName("const AstalTrayTooltip *")] _AstalTrayTooltip* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_tooltip_free([NativeTypeName("AstalTrayTooltip *")] _AstalTrayTooltip* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_tooltip_copy([NativeTypeName("const AstalTrayTooltip *")] _AstalTrayTooltip* self, [NativeTypeName("AstalTrayTooltip *")] _AstalTrayTooltip* dest);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_tooltip_destroy([NativeTypeName("AstalTrayTooltip *")] _AstalTrayTooltip* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_tray_category_get_type();

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalTrayCategory astal_tray_category_from_string([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* astal_tray_category_to_string(AstalTrayCategory value);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_tray_category_to_nick(AstalTrayCategory self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_tray_status_get_type();

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalTrayStatus astal_tray_status_from_string([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* astal_tray_status_to_string(AstalTrayStatus value);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_tray_status_to_nick(AstalTrayStatus self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_tray_tray_item_get_type();

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_tray_item_about_to_show([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_tray_item_activate([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self, [NativeTypeName("gint")] int x, [NativeTypeName("gint")] int y);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_tray_item_secondary_activate([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self, [NativeTypeName("gint")] int x, [NativeTypeName("gint")] int y);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_tray_tray_item_scroll([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self, [NativeTypeName("gint")] int delta, [NativeTypeName("const gchar *")] sbyte* orientation);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_tray_tray_item_to_json_string([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_tray_tray_item_get_title([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalTrayCategory astal_tray_tray_item_get_category([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalTrayStatus astal_tray_tray_item_get_status([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalTrayTooltip *")]
        public static extern _AstalTrayTooltip* astal_tray_tray_item_get_tooltip([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_tray_tray_item_get_tooltip_markup([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_tray_tray_item_get_tooltip_text([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_tray_tray_item_get_id([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_tray_tray_item_get_is_menu([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_tray_tray_item_get_icon_theme_path([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_tray_tray_item_get_icon_name([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GdkPixbuf *")]
        public static extern _GdkPixbuf* astal_tray_tray_item_get_icon_pixbuf([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GIcon *")]
        public static extern _GIcon* astal_tray_tray_item_get_gicon([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_tray_tray_item_get_item_id([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* astal_tray_tray_item_get_menu_path([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GMenuModel *")]
        public static extern _GMenuModel* astal_tray_tray_item_get_menu_model([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GActionGroup *")]
        public static extern _GActionGroup* astal_tray_tray_item_get_action_group([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_tray_tray_get_type();

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalTrayTray *")]
        public static extern _AstalTrayTray* astal_tray_get_default();

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalTrayTray *")]
        public static extern _AstalTrayTray* astal_tray_tray_get_default();

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalTrayTrayItem *")]
        public static extern _AstalTrayTrayItem* astal_tray_tray_get_item([NativeTypeName("AstalTrayTray *")] _AstalTrayTray* self, [NativeTypeName("const gchar *")] sbyte* item_id);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalTrayTray *")]
        public static extern _AstalTrayTray* astal_tray_tray_new();

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalTrayTray *")]
        public static extern _AstalTrayTray* astal_tray_tray_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_tray_tray_get_items([NativeTypeName("AstalTrayTray *")] _AstalTrayTray* self);

        [DllImport("libastal-tray-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GListModel *")]
        public static extern _GListModel* astal_tray_tray_get_items_model([NativeTypeName("AstalTrayTray *")] _AstalTrayTray* self);

        [NativeTypeName("#define ASTAL_TRAY_MAJOR_VERSION 0")]
        public const int ASTAL_TRAY_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_TRAY_MINOR_VERSION 1")]
        public const int ASTAL_TRAY_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_TRAY_MICRO_VERSION 0")]
        public const int ASTAL_TRAY_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_TRAY_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_TRAY_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_TRAY_TYPE_PIXMAP (astal_tray_pixmap_get_type ())")]
        public static readonly nuint ASTAL_TRAY_TYPE_PIXMAP = (astal_tray_pixmap_get_type());

        [NativeTypeName("#define ASTAL_TRAY_TYPE_TOOLTIP (astal_tray_tooltip_get_type ())")]
        public static readonly nuint ASTAL_TRAY_TYPE_TOOLTIP = (astal_tray_tooltip_get_type());

        [NativeTypeName("#define ASTAL_TRAY_TYPE_CATEGORY (astal_tray_category_get_type ())")]
        public static readonly nuint ASTAL_TRAY_TYPE_CATEGORY = (astal_tray_category_get_type());

        [NativeTypeName("#define ASTAL_TRAY_TYPE_STATUS (astal_tray_status_get_type ())")]
        public static readonly nuint ASTAL_TRAY_TYPE_STATUS = (astal_tray_status_get_type());

        [NativeTypeName("#define ASTAL_TRAY_TYPE_TRAY_ITEM (astal_tray_tray_item_get_type ())")]
        public static readonly nuint ASTAL_TRAY_TYPE_TRAY_ITEM = (astal_tray_tray_item_get_type());

        [NativeTypeName("#define ASTAL_TRAY_TYPE_TRAY (astal_tray_tray_get_type ())")]
        public static readonly nuint ASTAL_TRAY_TYPE_TRAY = (astal_tray_tray_get_type());
    }
}
