using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalPowerProfiles
{
    public static unsafe partial class AstalPowerProfilesInterop
    {
        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_power_profiles_power_profiles_get_type();

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalPowerProfilesPowerProfiles *")]
        public static extern _AstalPowerProfilesPowerProfiles* astal_power_profiles_get_default();

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalPowerProfilesPowerProfiles *")]
        public static extern _AstalPowerProfilesPowerProfiles* astal_power_profiles_power_profiles_get_default();

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_power_profiles_power_profiles_hold_profile([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self, [NativeTypeName("const gchar *")] sbyte* profile, [NativeTypeName("const gchar *")] sbyte* reason, [NativeTypeName("const gchar *")] sbyte* application_id);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_power_profiles_power_profiles_release_profile([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self, [NativeTypeName("guint")] uint cookie);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalPowerProfilesPowerProfiles *")]
        public static extern _AstalPowerProfilesPowerProfiles* astal_power_profiles_power_profiles_new();

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalPowerProfilesPowerProfiles *")]
        public static extern _AstalPowerProfilesPowerProfiles* astal_power_profiles_power_profiles_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_power_profiles_power_profiles_get_active_profile([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_power_profiles_power_profiles_set_active_profile([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_power_profiles_power_profiles_get_icon_name([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_power_profiles_power_profiles_get_actions([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_power_profiles_hold_get_type();

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalPowerProfilesHold *")]
        public static extern _AstalPowerProfilesHold* astal_power_profiles_hold_dup([NativeTypeName("const AstalPowerProfilesHold *")] _AstalPowerProfilesHold* self);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_power_profiles_hold_free([NativeTypeName("AstalPowerProfilesHold *")] _AstalPowerProfilesHold* self);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_power_profiles_hold_copy([NativeTypeName("const AstalPowerProfilesHold *")] _AstalPowerProfilesHold* self, [NativeTypeName("AstalPowerProfilesHold *")] _AstalPowerProfilesHold* dest);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_power_profiles_hold_destroy([NativeTypeName("AstalPowerProfilesHold *")] _AstalPowerProfilesHold* self);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalPowerProfilesHold *")]
        public static extern _AstalPowerProfilesHold* astal_power_profiles_power_profiles_get_active_profile_holds([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_power_profiles_power_profiles_get_performance_degraded([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_power_profiles_profile_get_type();

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalPowerProfilesProfile *")]
        public static extern _AstalPowerProfilesProfile* astal_power_profiles_profile_dup([NativeTypeName("const AstalPowerProfilesProfile *")] _AstalPowerProfilesProfile* self);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_power_profiles_profile_free([NativeTypeName("AstalPowerProfilesProfile *")] _AstalPowerProfilesProfile* self);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_power_profiles_profile_copy([NativeTypeName("const AstalPowerProfilesProfile *")] _AstalPowerProfilesProfile* self, [NativeTypeName("AstalPowerProfilesProfile *")] _AstalPowerProfilesProfile* dest);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_power_profiles_profile_destroy([NativeTypeName("AstalPowerProfilesProfile *")] _AstalPowerProfilesProfile* self);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalPowerProfilesProfile *")]
        public static extern _AstalPowerProfilesProfile* astal_power_profiles_power_profiles_get_profiles([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-power-profiles-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_power_profiles_power_profiles_get_version([NativeTypeName("AstalPowerProfilesPowerProfiles *")] _AstalPowerProfilesPowerProfiles* self);

        [NativeTypeName("#define ASTAL_POWER_PROFILES_MAJOR_VERSION 0")]
        public const int ASTAL_POWER_PROFILES_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_POWER_PROFILES_MINOR_VERSION 1")]
        public const int ASTAL_POWER_PROFILES_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_POWER_PROFILES_MICRO_VERSION 0")]
        public const int ASTAL_POWER_PROFILES_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_POWER_PROFILES_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_POWER_PROFILES_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_POWER_PROFILES_TYPE_POWER_PROFILES (astal_power_profiles_power_profiles_get_type ())")]
        public static readonly nuint ASTAL_POWER_PROFILES_TYPE_POWER_PROFILES = (astal_power_profiles_power_profiles_get_type());

        [NativeTypeName("#define ASTAL_POWER_PROFILES_TYPE_HOLD (astal_power_profiles_hold_get_type ())")]
        public static readonly nuint ASTAL_POWER_PROFILES_TYPE_HOLD = (astal_power_profiles_hold_get_type());

        [NativeTypeName("#define ASTAL_POWER_PROFILES_TYPE_PROFILE (astal_power_profiles_profile_get_type ())")]
        public static readonly nuint ASTAL_POWER_PROFILES_TYPE_PROFILE = (astal_power_profiles_profile_get_type());
    }
}
