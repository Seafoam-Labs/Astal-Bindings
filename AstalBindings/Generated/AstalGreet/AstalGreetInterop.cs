using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalGreet
{
    public static unsafe partial class AstalGreetInterop
    {
        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_greet_login([NativeTypeName("const gchar *")] sbyte* username, [NativeTypeName("const gchar *")] sbyte* password, [NativeTypeName("const gchar *")] sbyte* cmd, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_greet_login_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_greet_login_with_env([NativeTypeName("const gchar *")] sbyte* username, [NativeTypeName("const gchar *")] sbyte* password, [NativeTypeName("const gchar *")] sbyte* cmd, [NativeTypeName("gchar **")] sbyte** env, [NativeTypeName("gint")] int env_length1, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_greet_login_with_env_finish([NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_request_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_greet_request_send([NativeTypeName("AstalGreetRequest *")] _AstalGreetRequest* self, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_response_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetResponse *")]
        public static extern _AstalGreetResponse* astal_greet_request_send_finish([NativeTypeName("AstalGreetRequest *")] _AstalGreetRequest* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetRequest *")]
        public static extern _AstalGreetRequest* astal_greet_request_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_greet_request_get_type_name([NativeTypeName("AstalGreetRequest *")] _AstalGreetRequest* self);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_create_session_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetCreateSession *")]
        public static extern _AstalGreetCreateSession* astal_greet_create_session_new([NativeTypeName("const gchar *")] sbyte* username);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetCreateSession *")]
        public static extern _AstalGreetCreateSession* astal_greet_create_session_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("const gchar *")] sbyte* username);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_greet_create_session_get_username([NativeTypeName("AstalGreetCreateSession *")] _AstalGreetCreateSession* self);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_greet_create_session_set_username([NativeTypeName("AstalGreetCreateSession *")] _AstalGreetCreateSession* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_post_auth_messsage_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetPostAuthMesssage *")]
        public static extern _AstalGreetPostAuthMesssage* astal_greet_post_auth_messsage_new([NativeTypeName("const gchar *")] sbyte* response);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetPostAuthMesssage *")]
        public static extern _AstalGreetPostAuthMesssage* astal_greet_post_auth_messsage_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("const gchar *")] sbyte* response);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_greet_post_auth_messsage_get_response([NativeTypeName("AstalGreetPostAuthMesssage *")] _AstalGreetPostAuthMesssage* self);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_greet_post_auth_messsage_set_response([NativeTypeName("AstalGreetPostAuthMesssage *")] _AstalGreetPostAuthMesssage* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_start_session_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetStartSession *")]
        public static extern _AstalGreetStartSession* astal_greet_start_session_new([NativeTypeName("gchar **")] sbyte** cmd, [NativeTypeName("gint")] int cmd_length1, [NativeTypeName("gchar **")] sbyte** env, [NativeTypeName("gint")] int env_length1);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetStartSession *")]
        public static extern _AstalGreetStartSession* astal_greet_start_session_construct([NativeTypeName("GType")] nuint object_type, [NativeTypeName("gchar **")] sbyte** cmd, [NativeTypeName("gint")] int cmd_length1, [NativeTypeName("gchar **")] sbyte** env, [NativeTypeName("gint")] int env_length1);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_greet_start_session_get_cmd([NativeTypeName("AstalGreetStartSession *")] _AstalGreetStartSession* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_greet_start_session_set_cmd([NativeTypeName("AstalGreetStartSession *")] _AstalGreetStartSession* self, [NativeTypeName("gchar **")] sbyte** value, [NativeTypeName("gint")] int value_length1);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_greet_start_session_get_env([NativeTypeName("AstalGreetStartSession *")] _AstalGreetStartSession* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_greet_start_session_set_env([NativeTypeName("AstalGreetStartSession *")] _AstalGreetStartSession* self, [NativeTypeName("gchar **")] sbyte** value, [NativeTypeName("gint")] int value_length1);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_cancel_session_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetCancelSession *")]
        public static extern _AstalGreetCancelSession* astal_greet_cancel_session_new();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetCancelSession *")]
        public static extern _AstalGreetCancelSession* astal_greet_cancel_session_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalGreetResponse *")]
        public static extern _AstalGreetResponse* astal_greet_response_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_success_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_error_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_error_type_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalGreetErrorType astal_greet_error_get_error_type([NativeTypeName("AstalGreetError *")] _AstalGreetError* self);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_greet_error_get_description([NativeTypeName("AstalGreetError *")] _AstalGreetError* self);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_auth_message_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_greet_auth_message_type_get_type();

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalGreetAuthMessageType astal_greet_auth_message_get_message_type([NativeTypeName("AstalGreetAuthMessage *")] _AstalGreetAuthMessage* self);

        [DllImport("libastal-greet-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_greet_auth_message_get_message([NativeTypeName("AstalGreetAuthMessage *")] _AstalGreetAuthMessage* self);

        [NativeTypeName("#define ASTAL_GREET_MAJOR_VERSION 0")]
        public const int ASTAL_GREET_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_GREET_MINOR_VERSION 1")]
        public const int ASTAL_GREET_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_GREET_MICRO_VERSION 0")]
        public const int ASTAL_GREET_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_GREET_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_GREET_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_GREET_TYPE_REQUEST (astal_greet_request_get_type ())")]
        public static readonly nuint ASTAL_GREET_TYPE_REQUEST = (astal_greet_request_get_type());

        [NativeTypeName("#define ASTAL_GREET_TYPE_RESPONSE (astal_greet_response_get_type ())")]
        public static readonly nuint ASTAL_GREET_TYPE_RESPONSE = (astal_greet_response_get_type());

        [NativeTypeName("#define ASTAL_GREET_TYPE_CREATE_SESSION (astal_greet_create_session_get_type ())")]
        public static readonly nuint ASTAL_GREET_TYPE_CREATE_SESSION = (astal_greet_create_session_get_type());

        [NativeTypeName("#define ASTAL_GREET_TYPE_POST_AUTH_MESSSAGE (astal_greet_post_auth_messsage_get_type ())")]
        public static readonly nuint ASTAL_GREET_TYPE_POST_AUTH_MESSSAGE = (astal_greet_post_auth_messsage_get_type());

        [NativeTypeName("#define ASTAL_GREET_TYPE_START_SESSION (astal_greet_start_session_get_type ())")]
        public static readonly nuint ASTAL_GREET_TYPE_START_SESSION = (astal_greet_start_session_get_type());

        [NativeTypeName("#define ASTAL_GREET_TYPE_CANCEL_SESSION (astal_greet_cancel_session_get_type ())")]
        public static readonly nuint ASTAL_GREET_TYPE_CANCEL_SESSION = (astal_greet_cancel_session_get_type());

        [NativeTypeName("#define ASTAL_GREET_TYPE_SUCCESS (astal_greet_success_get_type ())")]
        public static readonly nuint ASTAL_GREET_TYPE_SUCCESS = (astal_greet_success_get_type());

        [NativeTypeName("#define ASTAL_GREET_TYPE_ERROR (astal_greet_error_get_type ())")]
        public static readonly nuint ASTAL_GREET_TYPE_ERROR = (astal_greet_error_get_type());

        [NativeTypeName("#define ASTAL_GREET_ERROR_TYPE_TYPE (astal_greet_error_type_get_type ())")]
        public static readonly nuint ASTAL_GREET_ERROR_TYPE_TYPE = (astal_greet_error_type_get_type());

        [NativeTypeName("#define ASTAL_GREET_TYPE_AUTH_MESSAGE (astal_greet_auth_message_get_type ())")]
        public static readonly nuint ASTAL_GREET_TYPE_AUTH_MESSAGE = (astal_greet_auth_message_get_type());

        [NativeTypeName("#define ASTAL_GREET_AUTH_MESSAGE_TYPE_TYPE (astal_greet_auth_message_type_get_type ())")]
        public static readonly nuint ASTAL_GREET_AUTH_MESSAGE_TYPE_TYPE = (astal_greet_auth_message_type_get_type());
    }
}
