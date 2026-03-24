using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalNetwork
{
    public static unsafe partial class AstalNetworkInterop
    {
        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_network_access_point_get_type();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GPtrArray *")]
        public static extern _GPtrArray* astal_network_access_point_get_connections([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_network_access_point_get_path([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_network_access_point_activate([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self, [NativeTypeName("const gchar *")] sbyte* password, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_network_access_point_activate_finish([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_network_access_point_get_bandwidth([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_network_access_point_get_bssid([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_network_access_point_get_frequency([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint")]
        public static extern int astal_network_access_point_get_last_seen([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_network_access_point_get_max_bitrate([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint8")]
        public static extern byte astal_network_access_point_get_strength([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_network_access_point_get_icon_name([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern NM80211Mode astal_network_access_point_get_mode([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern NM80211ApFlags astal_network_access_point_get_flags([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern NM80211ApSecurityFlags astal_network_access_point_get_rsn_flags([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern NM80211ApSecurityFlags astal_network_access_point_get_wpa_flags([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_network_access_point_get_requires_password([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_network_access_point_get_ssid([NativeTypeName("AstalNetworkAccessPoint *")] _AstalNetworkAccessPoint* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_network_network_get_type();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNetworkNetwork *")]
        public static extern _AstalNetworkNetwork* astal_network_get_default();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNetworkNetwork *")]
        public static extern _AstalNetworkNetwork* astal_network_network_get_default();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNetworkNetwork *")]
        public static extern _AstalNetworkNetwork* astal_network_network_new();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNetworkNetwork *")]
        public static extern _AstalNetworkNetwork* astal_network_network_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("NMClient *")]
        public static extern _NMClient* astal_network_network_get_client([NativeTypeName("AstalNetworkNetwork *")] _AstalNetworkNetwork* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_network_wifi_get_type();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNetworkWifi *")]
        public static extern _AstalNetworkWifi* astal_network_network_get_wifi([NativeTypeName("AstalNetworkNetwork *")] _AstalNetworkNetwork* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_network_wired_get_type();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNetworkWired *")]
        public static extern _AstalNetworkWired* astal_network_network_get_wired([NativeTypeName("AstalNetworkNetwork *")] _AstalNetworkNetwork* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_network_primary_get_type();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNetworkPrimary astal_network_network_get_primary([NativeTypeName("AstalNetworkNetwork *")] _AstalNetworkNetwork* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_network_connectivity_get_type();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNetworkConnectivity astal_network_network_get_connectivity([NativeTypeName("AstalNetworkNetwork *")] _AstalNetworkNetwork* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_network_state_get_type();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNetworkState astal_network_network_get_state([NativeTypeName("AstalNetworkNetwork *")] _AstalNetworkNetwork* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_network_primary_to_string(AstalNetworkPrimary self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNetworkPrimary astal_network_primary_from_connection_type([NativeTypeName("const gchar *")] sbyte* type);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_network_state_to_string(AstalNetworkState self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_network_connectivity_to_string(AstalNetworkConnectivity self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_network_device_state_get_type();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_network_device_state_to_string(AstalNetworkDeviceState self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_network_internet_get_type();

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNetworkInternet astal_network_internet_from_device([NativeTypeName("NMDevice *")] _NMDevice* device);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_network_internet_to_string(AstalNetworkInternet self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_network_wifi_scan([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_network_wifi_deactivate_connection([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_network_wifi_deactivate_connection_finish([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("NMDeviceWifi *")]
        public static extern _NMDeviceWifi* astal_network_wifi_get_device([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_network_wifi_set_device([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self, [NativeTypeName("NMDeviceWifi *")] _NMDeviceWifi* value);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("NMActiveConnection *")]
        public static extern _NMActiveConnection* astal_network_wifi_get_active_connection([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalNetworkAccessPoint *")]
        public static extern _AstalNetworkAccessPoint* astal_network_wifi_get_active_access_point([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_network_wifi_get_access_points([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_network_wifi_get_enabled([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_network_wifi_set_enabled([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNetworkInternet astal_network_wifi_get_internet([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_network_wifi_get_bandwidth([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_network_wifi_get_ssid([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint8")]
        public static extern byte astal_network_wifi_get_strength([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_network_wifi_get_frequency([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNetworkDeviceState astal_network_wifi_get_state([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_network_wifi_get_icon_name([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_network_wifi_get_is_hotspot([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_network_wifi_get_scanning([NativeTypeName("AstalNetworkWifi *")] _AstalNetworkWifi* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("NMDeviceEthernet *")]
        public static extern _NMDeviceEthernet* astal_network_wired_get_device([NativeTypeName("AstalNetworkWired *")] _AstalNetworkWired* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_network_wired_set_device([NativeTypeName("AstalNetworkWired *")] _AstalNetworkWired* self, [NativeTypeName("NMDeviceEthernet *")] _NMDeviceEthernet* value);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_network_wired_get_speed([NativeTypeName("AstalNetworkWired *")] _AstalNetworkWired* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNetworkInternet astal_network_wired_get_internet([NativeTypeName("AstalNetworkWired *")] _AstalNetworkWired* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AstalNetworkDeviceState astal_network_wired_get_state([NativeTypeName("AstalNetworkWired *")] _AstalNetworkWired* self);

        [DllImport("libastal-network-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const gchar *")]
        public static extern sbyte* astal_network_wired_get_icon_name([NativeTypeName("AstalNetworkWired *")] _AstalNetworkWired* self);

        [NativeTypeName("#define ASTAL_NETWORK_MAJOR_VERSION 0")]
        public const int ASTAL_NETWORK_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_NETWORK_MINOR_VERSION 1")]
        public const int ASTAL_NETWORK_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_NETWORK_MICRO_VERSION 0")]
        public const int ASTAL_NETWORK_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_NETWORK_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_NETWORK_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_NETWORK_TYPE_ACCESS_POINT (astal_network_access_point_get_type ())")]
        public static readonly nuint ASTAL_NETWORK_TYPE_ACCESS_POINT = (astal_network_access_point_get_type());

        [NativeTypeName("#define ASTAL_NETWORK_TYPE_NETWORK (astal_network_network_get_type ())")]
        public static readonly nuint ASTAL_NETWORK_TYPE_NETWORK = (astal_network_network_get_type());

        [NativeTypeName("#define ASTAL_NETWORK_TYPE_WIFI (astal_network_wifi_get_type ())")]
        public static readonly nuint ASTAL_NETWORK_TYPE_WIFI = (astal_network_wifi_get_type());

        [NativeTypeName("#define ASTAL_NETWORK_TYPE_WIRED (astal_network_wired_get_type ())")]
        public static readonly nuint ASTAL_NETWORK_TYPE_WIRED = (astal_network_wired_get_type());

        [NativeTypeName("#define ASTAL_NETWORK_TYPE_PRIMARY (astal_network_primary_get_type ())")]
        public static readonly nuint ASTAL_NETWORK_TYPE_PRIMARY = (astal_network_primary_get_type());

        [NativeTypeName("#define ASTAL_NETWORK_TYPE_CONNECTIVITY (astal_network_connectivity_get_type ())")]
        public static readonly nuint ASTAL_NETWORK_TYPE_CONNECTIVITY = (astal_network_connectivity_get_type());

        [NativeTypeName("#define ASTAL_NETWORK_TYPE_STATE (astal_network_state_get_type ())")]
        public static readonly nuint ASTAL_NETWORK_TYPE_STATE = (astal_network_state_get_type());

        [NativeTypeName("#define ASTAL_NETWORK_TYPE_DEVICE_STATE (astal_network_device_state_get_type ())")]
        public static readonly nuint ASTAL_NETWORK_TYPE_DEVICE_STATE = (astal_network_device_state_get_type());

        [NativeTypeName("#define ASTAL_NETWORK_TYPE_INTERNET (astal_network_internet_get_type ())")]
        public static readonly nuint ASTAL_NETWORK_TYPE_INTERNET = (astal_network_internet_get_type());
    }
}
