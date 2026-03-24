using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalNetwork
{
    public unsafe class Network : GObjectWrapper
    {
        public static Network Default => new Network(AstalNetworkInterop.astal_network_get_default(), owned: false);

        public Network() : base(AstalNetworkInterop.astal_network_network_new()) { }
        internal Network(_AstalNetworkNetwork* handle, bool owned = true) : base(handle, owned) { }

        public Wifi Wifi => new Wifi(AstalNetworkInterop.astal_network_network_get_wifi((_AstalNetworkNetwork*)Handle), owned: false);
        public Wired Wired => new Wired(AstalNetworkInterop.astal_network_network_get_wired((_AstalNetworkNetwork*)Handle), owned: false);
        public AstalNetworkPrimary Primary => AstalNetworkInterop.astal_network_network_get_primary((_AstalNetworkNetwork*)Handle);
        public AstalNetworkConnectivity Connectivity => AstalNetworkInterop.astal_network_network_get_connectivity((_AstalNetworkNetwork*)Handle);
        public AstalNetworkState State => AstalNetworkInterop.astal_network_network_get_state((_AstalNetworkNetwork*)Handle);
    }

    public unsafe class Wifi : GObjectWrapper
    {
        internal Wifi(_AstalNetworkWifi* handle, bool owned = true) : base(handle, owned) { }

        public bool Enabled
        {
            get => AstalNetworkInterop.astal_network_wifi_get_enabled((_AstalNetworkWifi*)Handle) != 0;
            set => AstalNetworkInterop.astal_network_wifi_set_enabled((_AstalNetworkWifi*)Handle, value ? 1 : 0);
        }

        public string? Ssid => MarshalString(AstalNetworkInterop.astal_network_wifi_get_ssid((_AstalNetworkWifi*)Handle));
        public byte Strength => AstalNetworkInterop.astal_network_wifi_get_strength((_AstalNetworkWifi*)Handle);
        public uint Bandwidth => AstalNetworkInterop.astal_network_wifi_get_bandwidth((_AstalNetworkWifi*)Handle);
        public uint Frequency => AstalNetworkInterop.astal_network_wifi_get_frequency((_AstalNetworkWifi*)Handle);
        public AstalNetworkInternet Internet => AstalNetworkInterop.astal_network_wifi_get_internet((_AstalNetworkWifi*)Handle);
        public AstalNetworkDeviceState State => AstalNetworkInterop.astal_network_wifi_get_state((_AstalNetworkWifi*)Handle);
        public string? IconName => MarshalString(AstalNetworkInterop.astal_network_wifi_get_icon_name((_AstalNetworkWifi*)Handle));
        public bool IsHotspot => AstalNetworkInterop.astal_network_wifi_get_is_hotspot((_AstalNetworkWifi*)Handle) != 0;
        public bool Scanning => AstalNetworkInterop.astal_network_wifi_get_scanning((_AstalNetworkWifi*)Handle) != 0;

        public void Scan() => AstalNetworkInterop.astal_network_wifi_scan((_AstalNetworkWifi*)Handle);

        private delegate void ChangedDelegate(void* self, void* data);
        private ChangedDelegate? _onChanged;
        private nuint _changedHandlerId;

        public event Action? Changed
        {
            add
            {
                if (_onChanged == null)
                {
                    _onChanged = (self, data) => _changedAction?.Invoke();
                    Connect("changed", Marshal.GetFunctionPointerForDelegate(_onChanged));
                }
                _changedAction += value;
            }
            remove
            {
                _changedAction -= value;
            }
        }
        private Action? _changedAction;

        public List<AccessPoint> AccessPoints
        {
            get
            {
                var list = new List<AccessPoint>();
                _GList* gList = AstalNetworkInterop.astal_network_wifi_get_access_points((_AstalNetworkWifi*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new AccessPoint((_AstalNetworkAccessPoint*)data, owned: false));
                }
                return list;
            }
        }

        // Helpers
        [StructLayout(LayoutKind.Sequential)]
        struct GListInternal { public void* data; public GListInternal* next; public GListInternal* prev; }
        private static void* GetData(_GList* list) => ((GListInternal*)list)->data;
        private static _GList* GetNext(_GList* list) => (_GList*)((GListInternal*)list)->next;
    }

    public unsafe class Wired : GObjectWrapper
    {
        internal Wired(_AstalNetworkWired* handle, bool owned = true) : base(handle, owned) { }

        public uint Speed => AstalNetworkInterop.astal_network_wired_get_speed((_AstalNetworkWired*)Handle);
        public AstalNetworkInternet Internet => AstalNetworkInterop.astal_network_wired_get_internet((_AstalNetworkWired*)Handle);
        public AstalNetworkDeviceState State => AstalNetworkInterop.astal_network_wired_get_state((_AstalNetworkWired*)Handle);
        public string? IconName => MarshalString(AstalNetworkInterop.astal_network_wired_get_icon_name((_AstalNetworkWired*)Handle));
    }

    public unsafe class AccessPoint : GObjectWrapper
    {
        internal AccessPoint(_AstalNetworkAccessPoint* handle, bool owned = true) : base(handle, owned) { }

        public string? Ssid => MarshalString(AstalNetworkInterop.astal_network_access_point_get_ssid((_AstalNetworkAccessPoint*)Handle));
        public byte Strength => AstalNetworkInterop.astal_network_access_point_get_strength((_AstalNetworkAccessPoint*)Handle);
        public uint Bandwidth => AstalNetworkInterop.astal_network_access_point_get_bandwidth((_AstalNetworkAccessPoint*)Handle);
        public uint Frequency => AstalNetworkInterop.astal_network_access_point_get_frequency((_AstalNetworkAccessPoint*)Handle);
        public string? Bssid => MarshalStringOwned(AstalNetworkInterop.astal_network_access_point_get_bssid((_AstalNetworkAccessPoint*)Handle));
        public string? IconName => MarshalString(AstalNetworkInterop.astal_network_access_point_get_icon_name((_AstalNetworkAccessPoint*)Handle));
    }
}
