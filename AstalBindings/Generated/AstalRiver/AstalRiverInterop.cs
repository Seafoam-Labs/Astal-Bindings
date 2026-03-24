using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalRiver
{
    public static unsafe partial class AstalRiverInterop
    {
        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_river_is_supported();

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_river_river_get_type();

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverRiver *")]
        public static extern _AstalRiverRiver* astal_river_get_default();

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverRiver *")]
        public static extern _AstalRiverRiver* astal_river_river_get_default();

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_river_output_get_type();

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverOutput *")]
        public static extern _AstalRiverOutput* astal_river_river_find_output_by_wl_output([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self, [NativeTypeName("struct wl_output *")] wl_output* wl_output);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverOutput *")]
        public static extern _AstalRiverOutput* astal_river_river_find_output_by_astal_wl_output([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self, [NativeTypeName("AstalWlOutput *")] _AstalWlOutput* wl_output);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverOutput *")]
        public static extern _AstalRiverOutput* astal_river_river_find_output_by_name([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self, [NativeTypeName("const gchar *")] sbyte* name);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverOutput *")]
        public static extern _AstalRiverOutput* astal_river_river_find_output_by_id([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self, [NativeTypeName("guint32")] uint id);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_river_river_run_command([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self, [NativeTypeName("gchar **")] sbyte** cmd, [NativeTypeName("gint")] int cmd_length1, [NativeTypeName("gchar **")] sbyte** output);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_river_river_run_command_async([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self, [NativeTypeName("gchar **")] sbyte** cmd, [NativeTypeName("gint")] int cmd_length1, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_river_river_run_command_finish([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("gchar **")] sbyte** output);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_river_layout_get_type();

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverLayout *")]
        public static extern _AstalRiverLayout* astal_river_river_new_layout([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self, [NativeTypeName("const gchar *")] sbyte* @namespace);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverRiver *")]
        public static extern _AstalRiverRiver* astal_river_river_new();

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverRiver *")]
        public static extern _AstalRiverRiver* astal_river_river_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_river_river_get_outputs([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverOutput *")]
        public static extern _AstalRiverOutput* astal_river_river_get_focused_output([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_river_river_get_focused_output_name([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_river_river_get_focused_view([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_river_river_get_mode([NativeTypeName("AstalRiverRiver *")] _AstalRiverRiver* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalWlOutput *")]
        public static extern _AstalWlOutput* astal_river_output_get_output([NativeTypeName("AstalRiverOutput *")] _AstalRiverOutput* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_river_output_get_focused_tags([NativeTypeName("AstalRiverOutput *")] _AstalRiverOutput* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_river_output_set_focused_tags([NativeTypeName("AstalRiverOutput *")] _AstalRiverOutput* self, [NativeTypeName("guint")] uint value);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_river_output_get_occupied_tags([NativeTypeName("AstalRiverOutput *")] _AstalRiverOutput* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_river_output_get_urgent_tags([NativeTypeName("AstalRiverOutput *")] _AstalRiverOutput* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_river_output_get_focused_view([NativeTypeName("AstalRiverOutput *")] _AstalRiverOutput* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_river_output_get_layout_name([NativeTypeName("AstalRiverOutput *")] _AstalRiverOutput* self);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_river_layout_demand_result_get_type();

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverLayoutDemandResult *")]
        public static extern _AstalRiverLayoutDemandResult* astal_river_layout_demand_result_new([NativeTypeName("const gchar *")] sbyte* layout_name, [NativeTypeName("GList *")] _GList* rectangles);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalRiverLayoutDemandResult *")]
        public static extern _AstalRiverLayoutDemandResult* astal_river_layout_demand_result_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("const gchar *")] sbyte* layout_name, [NativeTypeName("GList *")] _GList* rectangles);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_river_layout_set_layout_demand_closure([NativeTypeName("AstalRiverLayout *")] _AstalRiverLayout* self, [NativeTypeName("GClosure *")] _GClosure* closure);

        [DllImport("libastal-river-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_river_layout_get_namespace([NativeTypeName("AstalRiverLayout *")] _AstalRiverLayout* self);

        [NativeTypeName("#define ASTAL_RIVER_MAJOR_VERSION 0")]
        public const int ASTAL_RIVER_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_RIVER_MINOR_VERSION 1")]
        public const int ASTAL_RIVER_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_RIVER_MICRO_VERSION 0")]
        public const int ASTAL_RIVER_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_RIVER_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_RIVER_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_RIVER_TYPE_RIVER (astal_river_river_get_type ())")]
        public static readonly nuint ASTAL_RIVER_TYPE_RIVER = (astal_river_river_get_type());

        [NativeTypeName("#define ASTAL_RIVER_TYPE_OUTPUT (astal_river_output_get_type ())")]
        public static readonly nuint ASTAL_RIVER_TYPE_OUTPUT = (astal_river_output_get_type());

        [NativeTypeName("#define ASTAL_RIVER_TYPE_LAYOUT (astal_river_layout_get_type ())")]
        public static readonly nuint ASTAL_RIVER_TYPE_LAYOUT = (astal_river_layout_get_type());

        [NativeTypeName("#define ASTAL_RIVER_TYPE_LAYOUT_DEMAND_RESULT (astal_river_layout_demand_result_get_type ())")]
        public static readonly nuint ASTAL_RIVER_TYPE_LAYOUT_DEMAND_RESULT = (astal_river_layout_demand_result_get_type());
    }
}
