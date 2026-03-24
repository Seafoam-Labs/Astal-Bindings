using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalAuth
{
    public unsafe class Pam : GObjectWrapper
    {
        internal Pam(_AstalAuthPam* handle, bool owned = true) : base(handle, owned) { }

        public string? Username
        {
            get => MarshalString(AstalAuthInterop.astal_auth_pam_get_username((_AstalAuthPam*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalAuthInterop.astal_auth_pam_set_username((_AstalAuthPam*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? Service
        {
            get => MarshalString(AstalAuthInterop.astal_auth_pam_get_service((_AstalAuthPam*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalAuthInterop.astal_auth_pam_set_service((_AstalAuthPam*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public bool StartAuthenticate() => AstalAuthInterop.astal_auth_pam_start_authenticate((_AstalAuthPam*)Handle) != 0;

        public void SupplySecret(string secret)
        {
            IntPtr nativeSecret = Marshal.StringToHGlobalAnsi(secret);
            try { AstalAuthInterop.astal_auth_pam_supply_secret((_AstalAuthPam*)Handle, (sbyte*)nativeSecret); }
            finally { Marshal.FreeHGlobal(nativeSecret); }
        }
    }
}
