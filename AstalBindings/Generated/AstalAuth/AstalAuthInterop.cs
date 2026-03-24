using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalAuth
{
    public static unsafe partial class AstalAuthInterop
    {
        [DllImport("libastal-auth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_auth_pam_get_type();

        [DllImport("libastal-auth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_auth_pam_set_username([NativeTypeName("AstalAuthPam *")] _AstalAuthPam* self, [NativeTypeName("const gchar *")] sbyte* username);

        [DllImport("libastal-auth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_auth_pam_get_username([NativeTypeName("AstalAuthPam *")] _AstalAuthPam* self);

        [DllImport("libastal-auth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_auth_pam_set_service([NativeTypeName("AstalAuthPam *")] _AstalAuthPam* self, [NativeTypeName("const gchar *")] sbyte* service);

        [DllImport("libastal-auth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_auth_pam_get_service([NativeTypeName("AstalAuthPam *")] _AstalAuthPam* self);

        [DllImport("libastal-auth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_auth_pam_start_authenticate([NativeTypeName("AstalAuthPam *")] _AstalAuthPam* self);

        [DllImport("libastal-auth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_auth_pam_supply_secret([NativeTypeName("AstalAuthPam *")] _AstalAuthPam* self, [NativeTypeName("const gchar *")] sbyte* secret);

        [DllImport("libastal-auth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_auth_pam_authenticate([NativeTypeName("const gchar *")] sbyte* password, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> result_callback, [NativeTypeName("gpointer")] void* user_data);

        [DllImport("libastal-auth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gssize")]
        public static extern nint astal_auth_pam_authenticate_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* res, [NativeTypeName("GError **")] _GError** error);

        [NativeTypeName("#define ASTAL_AUTH_MAJOR_VERSION 0")]
        public const int ASTAL_AUTH_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_AUTH_MINOR_VERSION 1")]
        public const int ASTAL_AUTH_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_AUTH_MICRO_VERSION 0")]
        public const int ASTAL_AUTH_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_AUTH_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_AUTH_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_AUTH_TYPE_PAM (astal_auth_pam_get_type())")]
        public static readonly nuint ASTAL_AUTH_TYPE_PAM = (astal_auth_pam_get_type());
    }
}
