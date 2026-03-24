using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalBattery
{
    public static unsafe partial class AstalBatteryInterop
    {
        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_battery_device_get_type();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBatteryDevice *")]
        public static extern _AstalBatteryDevice* astal_battery_get_default();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBatteryDevice *")]
        public static extern _AstalBatteryDevice* astal_battery_device_get_default();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBatteryDevice *")]
        public static extern _AstalBatteryDevice* astal_battery_device_new([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBatteryDevice *")]
        public static extern _AstalBatteryDevice* astal_battery_device_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_battery_type_get_type();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalBatteryType astal_battery_device_get_device_type([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_battery_device_get_native_path([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_battery_device_get_vendor([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_battery_device_get_model([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_battery_device_get_serial([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint64")]
        public static extern nuint astal_battery_device_get_update_time([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_battery_device_get_power_supply([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_battery_device_get_online([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_energy([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_energy_empty([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_energy_full([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_energy_full_design([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_energy_rate([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_voltage([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_battery_device_get_charge_cycles([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_luminosity([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint64")]
        public static extern nint astal_battery_device_get_time_to_empty([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint64")]
        public static extern nint astal_battery_device_get_time_to_full([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_percentage([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_temperature([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_battery_device_get_is_present([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_battery_state_get_type();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalBatteryState astal_battery_device_get_state([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_battery_device_get_is_rechargable([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_battery_device_get_capacity([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_battery_technology_get_type();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalBatteryTechnology astal_battery_device_get_technology([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_battery_warning_level_get_type();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalBatteryWarningLevel astal_battery_device_get_warning_level([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_battery_battery_level_get_type();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalBatteryBatteryLevel astal_battery_device_get_battery_level([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_battery_device_get_icon_name([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_battery_device_get_charging([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_battery_device_get_is_battery([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_battery_device_get_battery_icon_name([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_battery_device_get_device_type_name([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_battery_device_get_device_type_icon([NativeTypeName("AstalBatteryDevice *")] _AstalBatteryDevice* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_battery_upower_get_type();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBatteryUPower *")]
        public static extern _AstalBatteryUPower* astal_battery_upower_new();

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBatteryUPower *")]
        public static extern _AstalBatteryUPower* astal_battery_upower_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_battery_upower_get_devices([NativeTypeName("AstalBatteryUPower *")] _AstalBatteryUPower* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBatteryDevice *")]
        public static extern _AstalBatteryDevice* astal_battery_upower_get_display_device([NativeTypeName("AstalBatteryUPower *")] _AstalBatteryUPower* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_battery_upower_get_daemon_version([NativeTypeName("AstalBatteryUPower *")] _AstalBatteryUPower* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_battery_upower_get_on_battery([NativeTypeName("AstalBatteryUPower *")] _AstalBatteryUPower* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_battery_upower_get_lid_is_closed([NativeTypeName("AstalBatteryUPower *")] _AstalBatteryUPower* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_battery_upower_get_lid_is_present([NativeTypeName("AstalBatteryUPower *")] _AstalBatteryUPower* self);

        [DllImport("libastal-battery-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_battery_upower_get_critical_action([NativeTypeName("AstalBatteryUPower *")] _AstalBatteryUPower* self);

        [NativeTypeName("#define ASTAL_BATTERY_MAJOR_VERSION 0")]
        public const int ASTAL_BATTERY_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_BATTERY_MINOR_VERSION 1")]
        public const int ASTAL_BATTERY_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_BATTERY_MICRO_VERSION 0")]
        public const int ASTAL_BATTERY_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_BATTERY_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_BATTERY_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_BATTERY_TYPE_DEVICE (astal_battery_device_get_type ())")]
        public static readonly nuint ASTAL_BATTERY_TYPE_DEVICE = (astal_battery_device_get_type());

        [NativeTypeName("#define ASTAL_BATTERY_TYPE_TYPE (astal_battery_type_get_type ())")]
        public static readonly nuint ASTAL_BATTERY_TYPE_TYPE = (astal_battery_type_get_type());

        [NativeTypeName("#define ASTAL_BATTERY_TYPE_STATE (astal_battery_state_get_type ())")]
        public static readonly nuint ASTAL_BATTERY_TYPE_STATE = (astal_battery_state_get_type());

        [NativeTypeName("#define ASTAL_BATTERY_TYPE_TECHNOLOGY (astal_battery_technology_get_type ())")]
        public static readonly nuint ASTAL_BATTERY_TYPE_TECHNOLOGY = (astal_battery_technology_get_type());

        [NativeTypeName("#define ASTAL_BATTERY_TYPE_WARNING_LEVEL (astal_battery_warning_level_get_type ())")]
        public static readonly nuint ASTAL_BATTERY_TYPE_WARNING_LEVEL = (astal_battery_warning_level_get_type());

        [NativeTypeName("#define ASTAL_BATTERY_TYPE_BATTERY_LEVEL (astal_battery_battery_level_get_type ())")]
        public static readonly nuint ASTAL_BATTERY_TYPE_BATTERY_LEVEL = (astal_battery_battery_level_get_type());

        [NativeTypeName("#define ASTAL_BATTERY_TYPE_UPOWER (astal_battery_upower_get_type ())")]
        public static readonly nuint ASTAL_BATTERY_TYPE_UPOWER = (astal_battery_upower_get_type());
    }
}
