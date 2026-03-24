using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalBluetooth
{
    public unsafe class BluetoothDevice : GObjectWrapper
    {
        internal BluetoothDevice(_AstalBluetoothDevice* handle, bool owned = true) : base(handle, owned) { }

        public bool Connected => AstalBluetoothInterop.astal_bluetooth_device_get_connected((_AstalBluetoothDevice*)Handle) != 0;
        public bool LegacyPairing => AstalBluetoothInterop.astal_bluetooth_device_get_legacy_pairing((_AstalBluetoothDevice*)Handle) != 0;
        public bool Paired => AstalBluetoothInterop.astal_bluetooth_device_get_paired((_AstalBluetoothDevice*)Handle) != 0;
        public short Rssi => AstalBluetoothInterop.astal_bluetooth_device_get_rssi((_AstalBluetoothDevice*)Handle);
        public string? AdapterPath => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_device_get_adapter((_AstalBluetoothDevice*)Handle));
        public string? Address => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_device_get_address((_AstalBluetoothDevice*)Handle));
        public string? Icon => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_device_get_icon((_AstalBluetoothDevice*)Handle));
        public string? Modalias => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_device_get_modalias((_AstalBluetoothDevice*)Handle));
        public string? Name => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_device_get_name((_AstalBluetoothDevice*)Handle));
        public ushort Appearance => AstalBluetoothInterop.astal_bluetooth_device_get_appearance((_AstalBluetoothDevice*)Handle);
        public uint Class => AstalBluetoothInterop.astal_bluetooth_device_get_class((_AstalBluetoothDevice*)Handle);
        public bool Connecting => AstalBluetoothInterop.astal_bluetooth_device_get_connecting((_AstalBluetoothDevice*)Handle) != 0;
        public double BatteryPercentage => AstalBluetoothInterop.astal_bluetooth_device_get_battery_percentage((_AstalBluetoothDevice*)Handle);

        public bool Blocked
        {
            get => AstalBluetoothInterop.astal_bluetooth_device_get_blocked((_AstalBluetoothDevice*)Handle) != 0;
            set => AstalBluetoothInterop.astal_bluetooth_device_set_blocked((_AstalBluetoothDevice*)Handle, value ? 1 : 0);
        }

        public bool Trusted
        {
            get => AstalBluetoothInterop.astal_bluetooth_device_get_trusted((_AstalBluetoothDevice*)Handle) != 0;
            set => AstalBluetoothInterop.astal_bluetooth_device_set_trusted((_AstalBluetoothDevice*)Handle, value ? 1 : 0);
        }

        public string? Alias
        {
            get => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_device_get_alias((_AstalBluetoothDevice*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalBluetoothInterop.astal_bluetooth_device_set_alias((_AstalBluetoothDevice*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public void Connect() => AstalBluetoothInterop.astal_bluetooth_device_connect_device((_AstalBluetoothDevice*)Handle, null, null);
        public void Disconnect() => AstalBluetoothInterop.astal_bluetooth_device_disconnect_device((_AstalBluetoothDevice*)Handle, null, null);
        public void Pair() => AstalBluetoothInterop.astal_bluetooth_device_pair((_AstalBluetoothDevice*)Handle, null);
        public void CancelPairing() => AstalBluetoothInterop.astal_bluetooth_device_cancel_pairing((_AstalBluetoothDevice*)Handle, null);
    }

    public unsafe class BluetoothAdapter : GObjectWrapper
    {
        internal BluetoothAdapter(_AstalBluetoothAdapter* handle, bool owned = true) : base(handle, owned) { }

        public bool Discovering => AstalBluetoothInterop.astal_bluetooth_adapter_get_discovering((_AstalBluetoothAdapter*)Handle) != 0;
        public string? Modalias => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_adapter_get_modalias((_AstalBluetoothAdapter*)Handle));
        public string? Name => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_adapter_get_name((_AstalBluetoothAdapter*)Handle));
        public uint Class => AstalBluetoothInterop.astal_bluetooth_adapter_get_class((_AstalBluetoothAdapter*)Handle);
        public string? Address => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_adapter_get_address((_AstalBluetoothAdapter*)Handle));

        public bool Discoverable
        {
            get => AstalBluetoothInterop.astal_bluetooth_adapter_get_discoverable((_AstalBluetoothAdapter*)Handle) != 0;
            set => AstalBluetoothInterop.astal_bluetooth_adapter_set_discoverable((_AstalBluetoothAdapter*)Handle, value ? 1 : 0);
        }

        public bool Pairable
        {
            get => AstalBluetoothInterop.astal_bluetooth_adapter_get_pairable((_AstalBluetoothAdapter*)Handle) != 0;
            set => AstalBluetoothInterop.astal_bluetooth_adapter_set_pairable((_AstalBluetoothAdapter*)Handle, value ? 1 : 0);
        }

        public bool Powered
        {
            get => AstalBluetoothInterop.astal_bluetooth_adapter_get_powered((_AstalBluetoothAdapter*)Handle) != 0;
            set => AstalBluetoothInterop.astal_bluetooth_adapter_set_powered((_AstalBluetoothAdapter*)Handle, value ? 1 : 0);
        }

        public string? Alias
        {
            get => MarshalStringOwned(AstalBluetoothInterop.astal_bluetooth_adapter_get_alias((_AstalBluetoothAdapter*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalBluetoothInterop.astal_bluetooth_adapter_set_alias((_AstalBluetoothAdapter*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public uint DiscoverableTimeout
        {
            get => AstalBluetoothInterop.astal_bluetooth_adapter_get_discoverable_timeout((_AstalBluetoothAdapter*)Handle);
            set => AstalBluetoothInterop.astal_bluetooth_adapter_set_discoverable_timeout((_AstalBluetoothAdapter*)Handle, value);
        }

        public uint PairableTimeout
        {
            get => AstalBluetoothInterop.astal_bluetooth_adapter_get_pairable_timeout((_AstalBluetoothAdapter*)Handle);
            set => AstalBluetoothInterop.astal_bluetooth_adapter_set_pairable_timeout((_AstalBluetoothAdapter*)Handle, value);
        }

        public void StartDiscovery() => AstalBluetoothInterop.astal_bluetooth_adapter_start_discovery((_AstalBluetoothAdapter*)Handle, null);
        public void StopDiscovery() => AstalBluetoothInterop.astal_bluetooth_adapter_stop_discovery((_AstalBluetoothAdapter*)Handle, null);
    }

    public unsafe class Bluetooth : GObjectWrapper
    {
        public static Bluetooth Default => new Bluetooth(AstalBluetoothInterop.astal_bluetooth_get_default(), owned: false);

        public Bluetooth() : base(AstalBluetoothInterop.astal_bluetooth_bluetooth_new()) { }
        internal Bluetooth(_AstalBluetoothBluetooth* handle, bool owned = true) : base(handle, owned) { }

        public bool IsPowered => AstalBluetoothInterop.astal_bluetooth_bluetooth_get_is_powered((_AstalBluetoothBluetooth*)Handle) != 0;
        public bool IsConnected => AstalBluetoothInterop.astal_bluetooth_bluetooth_get_is_connected((_AstalBluetoothBluetooth*)Handle) != 0;
        public BluetoothAdapter Adapter => new BluetoothAdapter(AstalBluetoothInterop.astal_bluetooth_bluetooth_get_adapter((_AstalBluetoothBluetooth*)Handle), owned: false);

        public void Toggle() => AstalBluetoothInterop.astal_bluetooth_bluetooth_toggle((_AstalBluetoothBluetooth*)Handle);

        public List<BluetoothAdapter> Adapters
        {
            get
            {
                var list = new List<BluetoothAdapter>();
                _GList* gList = AstalBluetoothInterop.astal_bluetooth_bluetooth_get_adapters((_AstalBluetoothBluetooth*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new BluetoothAdapter((_AstalBluetoothAdapter*)data, owned: false));
                }
                return list;
            }
        }

        public List<BluetoothDevice> Devices
        {
            get
            {
                var list = new List<BluetoothDevice>();
                _GList* gList = AstalBluetoothInterop.astal_bluetooth_bluetooth_get_devices((_AstalBluetoothBluetooth*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new BluetoothDevice((_AstalBluetoothDevice*)data, owned: false));
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
}
