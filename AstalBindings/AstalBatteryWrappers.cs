using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalBattery
{
    public unsafe class BatteryDevice : GObjectWrapper
    {
        public static BatteryDevice Default => new BatteryDevice(AstalBatteryInterop.astal_battery_get_default(), owned: false);

        internal BatteryDevice(_AstalBatteryDevice* handle, bool owned = true) : base(handle, owned) { }

        public AstalBatteryType DeviceType => AstalBatteryInterop.astal_battery_device_get_device_type((_AstalBatteryDevice*)Handle);
        public string? NativePath => MarshalStringOwned(AstalBatteryInterop.astal_battery_device_get_native_path((_AstalBatteryDevice*)Handle));
        public string? Vendor => MarshalStringOwned(AstalBatteryInterop.astal_battery_device_get_vendor((_AstalBatteryDevice*)Handle));
        public string? Model => MarshalStringOwned(AstalBatteryInterop.astal_battery_device_get_model((_AstalBatteryDevice*)Handle));
        public string? Serial => MarshalStringOwned(AstalBatteryInterop.astal_battery_device_get_serial((_AstalBatteryDevice*)Handle));
        public nuint UpdateTime => AstalBatteryInterop.astal_battery_device_get_update_time((_AstalBatteryDevice*)Handle);
        public bool PowerSupply => AstalBatteryInterop.astal_battery_device_get_power_supply((_AstalBatteryDevice*)Handle) != 0;
        public bool Online => AstalBatteryInterop.astal_battery_device_get_online((_AstalBatteryDevice*)Handle) != 0;
        public double Energy => AstalBatteryInterop.astal_battery_device_get_energy((_AstalBatteryDevice*)Handle);
        public double EnergyEmpty => AstalBatteryInterop.astal_battery_device_get_energy_empty((_AstalBatteryDevice*)Handle);
        public double EnergyFull => AstalBatteryInterop.astal_battery_device_get_energy_full((_AstalBatteryDevice*)Handle);
        public double EnergyFullDesign => AstalBatteryInterop.astal_battery_device_get_energy_full_design((_AstalBatteryDevice*)Handle);
        public double EnergyRate => AstalBatteryInterop.astal_battery_device_get_energy_rate((_AstalBatteryDevice*)Handle);
        public double Voltage => AstalBatteryInterop.astal_battery_device_get_voltage((_AstalBatteryDevice*)Handle);
        public int ChargeCycles => AstalBatteryInterop.astal_battery_device_get_charge_cycles((_AstalBatteryDevice*)Handle);
        public double Luminosity => AstalBatteryInterop.astal_battery_device_get_luminosity((_AstalBatteryDevice*)Handle);
        public nint TimeToEmpty => AstalBatteryInterop.astal_battery_device_get_time_to_empty((_AstalBatteryDevice*)Handle);
        public nint TimeToFull => AstalBatteryInterop.astal_battery_device_get_time_to_full((_AstalBatteryDevice*)Handle);
        public double Percentage => AstalBatteryInterop.astal_battery_device_get_percentage((_AstalBatteryDevice*)Handle);
        public double Temperature => AstalBatteryInterop.astal_battery_device_get_temperature((_AstalBatteryDevice*)Handle);
        public bool IsPresent => AstalBatteryInterop.astal_battery_device_get_is_present((_AstalBatteryDevice*)Handle) != 0;
        public AstalBatteryState State => AstalBatteryInterop.astal_battery_device_get_state((_AstalBatteryDevice*)Handle);
        public bool IsRechargable => AstalBatteryInterop.astal_battery_device_get_is_rechargable((_AstalBatteryDevice*)Handle) != 0;
        public double Capacity => AstalBatteryInterop.astal_battery_device_get_capacity((_AstalBatteryDevice*)Handle);
        public AstalBatteryTechnology Technology => AstalBatteryInterop.astal_battery_device_get_technology((_AstalBatteryDevice*)Handle);
        public AstalBatteryWarningLevel WarningLevel => AstalBatteryInterop.astal_battery_device_get_warning_level((_AstalBatteryDevice*)Handle);
        public AstalBatteryBatteryLevel BatteryLevel => AstalBatteryInterop.astal_battery_device_get_battery_level((_AstalBatteryDevice*)Handle);
        public string? IconName => MarshalStringOwned(AstalBatteryInterop.astal_battery_device_get_icon_name((_AstalBatteryDevice*)Handle));
        public bool Charging => AstalBatteryInterop.astal_battery_device_get_charging((_AstalBatteryDevice*)Handle) != 0;
        public bool IsBattery => AstalBatteryInterop.astal_battery_device_get_is_battery((_AstalBatteryDevice*)Handle) != 0;
        public string? BatteryIconName => MarshalString(AstalBatteryInterop.astal_battery_device_get_battery_icon_name((_AstalBatteryDevice*)Handle));
        public string? DeviceTypeName => MarshalString(AstalBatteryInterop.astal_battery_device_get_device_type_name((_AstalBatteryDevice*)Handle));
        public string? DeviceTypeIcon => MarshalString(AstalBatteryInterop.astal_battery_device_get_device_type_icon((_AstalBatteryDevice*)Handle));
    }

    public unsafe class UPower : GObjectWrapper
    {
        public UPower() : base(AstalBatteryInterop.astal_battery_upower_new()) { }
        internal UPower(_AstalBatteryUPower* handle, bool owned = true) : base(handle, owned) { }

        public BatteryDevice DisplayDevice => new BatteryDevice(AstalBatteryInterop.astal_battery_upower_get_display_device((_AstalBatteryUPower*)Handle), owned: false);
        public string? DaemonVersion => MarshalStringOwned(AstalBatteryInterop.astal_battery_upower_get_daemon_version((_AstalBatteryUPower*)Handle));
        public bool OnBattery => AstalBatteryInterop.astal_battery_upower_get_on_battery((_AstalBatteryUPower*)Handle) != 0;
        public bool LidIsClosed => AstalBatteryInterop.astal_battery_upower_get_lid_is_closed((_AstalBatteryUPower*)Handle) != 0;
        public bool LidIsPresent => AstalBatteryInterop.astal_battery_upower_get_lid_is_present((_AstalBatteryUPower*)Handle) != 0;
        public string? CriticalAction => MarshalStringOwned(AstalBatteryInterop.astal_battery_upower_get_critical_action((_AstalBatteryUPower*)Handle));

        public List<BatteryDevice> Devices
        {
            get
            {
                var list = new List<BatteryDevice>();
                _GList* gList = AstalBatteryInterop.astal_battery_upower_get_devices((_AstalBatteryUPower*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new BatteryDevice((_AstalBatteryDevice*)data, owned: false));
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
