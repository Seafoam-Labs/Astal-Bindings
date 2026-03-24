using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalPowerProfiles
{
    public unsafe class PowerProfiles : GObjectWrapper
    {
        public static PowerProfiles Default => new PowerProfiles(AstalPowerProfilesInterop.astal_power_profiles_get_default(), owned: false);

        public PowerProfiles() : base(AstalPowerProfilesInterop.astal_power_profiles_power_profiles_new()) { }
        internal PowerProfiles(_AstalPowerProfilesPowerProfiles* handle, bool owned = true) : base(handle, owned) { }

        public string? ActiveProfile
        {
            get => MarshalStringOwned(AstalPowerProfilesInterop.astal_power_profiles_power_profiles_get_active_profile((_AstalPowerProfilesPowerProfiles*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalPowerProfilesInterop.astal_power_profiles_power_profiles_set_active_profile((_AstalPowerProfilesPowerProfiles*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? IconName => MarshalStringOwned(AstalPowerProfilesInterop.astal_power_profiles_power_profiles_get_icon_name((_AstalPowerProfilesPowerProfiles*)Handle));
        public string? PerformanceDegraded => MarshalStringOwned(AstalPowerProfilesInterop.astal_power_profiles_power_profiles_get_performance_degraded((_AstalPowerProfilesPowerProfiles*)Handle));
        public string? Version => MarshalStringOwned(AstalPowerProfilesInterop.astal_power_profiles_power_profiles_get_version((_AstalPowerProfilesPowerProfiles*)Handle));

        public int HoldProfile(string profile, string reason, string applicationId)
        {
            IntPtr nativeProfile = Marshal.StringToHGlobalAnsi(profile);
            IntPtr nativeReason = Marshal.StringToHGlobalAnsi(reason);
            IntPtr nativeAppId = Marshal.StringToHGlobalAnsi(applicationId);
            try
            {
                return AstalPowerProfilesInterop.astal_power_profiles_power_profiles_hold_profile((_AstalPowerProfilesPowerProfiles*)Handle, (sbyte*)nativeProfile, (sbyte*)nativeReason, (sbyte*)nativeAppId);
            }
            finally
            {
                Marshal.FreeHGlobal(nativeProfile);
                Marshal.FreeHGlobal(nativeReason);
                Marshal.FreeHGlobal(nativeAppId);
            }
        }

        public void ReleaseProfile(uint cookie) => AstalPowerProfilesInterop.astal_power_profiles_power_profiles_release_profile((_AstalPowerProfilesPowerProfiles*)Handle, cookie);
    }
}
