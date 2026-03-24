using System;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalBluetooth
{
    public static unsafe partial class AstalBluetoothInterop
    {
        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_bluetooth_adapter_get_type();

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_bluetooth_device_get_type();

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_adapter_remove_device([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* device, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_adapter_start_discovery([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_adapter_stop_discovery([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_bluetooth_adapter_get_uuids([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_adapter_get_discovering([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_bluetooth_adapter_get_modalias([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_bluetooth_adapter_get_name([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_bluetooth_adapter_get_class([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_bluetooth_adapter_get_address([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_adapter_get_discoverable([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_adapter_set_discoverable([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_adapter_get_pairable([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_adapter_set_pairable([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_adapter_get_powered([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_adapter_set_powered([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_bluetooth_adapter_get_alias([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_adapter_set_alias([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("const gchar *")] sbyte* value);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_bluetooth_adapter_get_discoverable_timeout([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_adapter_set_discoverable_timeout([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("guint")] uint value);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint")]
        public static extern uint astal_bluetooth_adapter_get_pairable_timeout([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_adapter_set_pairable_timeout([NativeTypeName("AstalBluetoothAdapter *")] _AstalBluetoothAdapter* self, [NativeTypeName("guint")] uint value);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GType")]
        public static extern nuint astal_bluetooth_bluetooth_get_type();

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBluetoothBluetooth *")]
        public static extern _AstalBluetoothBluetooth* astal_bluetooth_get_default();

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBluetoothBluetooth *")]
        public static extern _AstalBluetoothBluetooth* astal_bluetooth_bluetooth_get_default();

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_bluetooth_toggle([NativeTypeName("AstalBluetoothBluetooth *")] _AstalBluetoothBluetooth* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBluetoothBluetooth *")]
        public static extern _AstalBluetoothBluetooth* astal_bluetooth_bluetooth_new();

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBluetoothBluetooth *")]
        public static extern _AstalBluetoothBluetooth* astal_bluetooth_bluetooth_construct([NativeTypeName("GType")] nuint object_type);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_bluetooth_get_is_powered([NativeTypeName("AstalBluetoothBluetooth *")] _AstalBluetoothBluetooth* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_bluetooth_get_is_connected([NativeTypeName("AstalBluetoothBluetooth *")] _AstalBluetoothBluetooth* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AstalBluetoothAdapter *")]
        public static extern _AstalBluetoothAdapter* astal_bluetooth_bluetooth_get_adapter([NativeTypeName("AstalBluetoothBluetooth *")] _AstalBluetoothBluetooth* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_bluetooth_bluetooth_get_adapters([NativeTypeName("AstalBluetoothBluetooth *")] _AstalBluetoothBluetooth* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GList *")]
        public static extern _GList* astal_bluetooth_bluetooth_get_devices([NativeTypeName("AstalBluetoothBluetooth *")] _AstalBluetoothBluetooth* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_connect_device([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_connect_device_finish([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_disconnect_device([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("GAsyncReadyCallback")] delegate* unmanaged[Cdecl]<_GObject*, _GAsyncResult*, void*, void> _callback_, [NativeTypeName("gpointer")] void* _user_data_);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_disconnect_device_finish([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("GAsyncResult *")] _GAsyncResult* _res_, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_connect_profile([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("const gchar *")] sbyte* uuid, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_disconnect_profile([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("const gchar *")] sbyte* uuid, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_pair([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_cancel_pairing([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("GError **")] _GError** error);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar **")]
        public static extern sbyte** astal_bluetooth_device_get_uuids([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("gint *")] int* result_length1);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_device_get_connected([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_device_get_legacy_pairing([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_device_get_paired([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gint16")]
        public static extern short astal_bluetooth_device_get_rssi([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* astal_bluetooth_device_get_adapter([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_bluetooth_device_get_address([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_bluetooth_device_get_icon([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_bluetooth_device_get_modalias([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_bluetooth_device_get_name([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint16")]
        public static extern ushort astal_bluetooth_device_get_appearance([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("guint32")]
        public static extern uint astal_bluetooth_device_get_class([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_device_get_connecting([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_device_get_blocked([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_set_blocked([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gboolean")]
        public static extern int astal_bluetooth_device_get_trusted([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_set_trusted([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("gboolean")] int value);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gdouble")]
        public static extern double astal_bluetooth_device_get_battery_percentage([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("gchar *")]
        public static extern sbyte* astal_bluetooth_device_get_alias([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self);

        [DllImport("libastal-bluetooth-0.1.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void astal_bluetooth_device_set_alias([NativeTypeName("AstalBluetoothDevice *")] _AstalBluetoothDevice* self, [NativeTypeName("const gchar *")] sbyte* value);

        [NativeTypeName("#define ASTAL_BLUETOOTH_MAJOR_VERSION 0")]
        public const int ASTAL_BLUETOOTH_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_BLUETOOTH_MINOR_VERSION 1")]
        public const int ASTAL_BLUETOOTH_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_BLUETOOTH_MICRO_VERSION 0")]
        public const int ASTAL_BLUETOOTH_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_BLUETOOTH_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_BLUETOOTH_VERSION => "0.1.0"u8;

        [NativeTypeName("#define ASTAL_BLUETOOTH_TYPE_ADAPTER (astal_bluetooth_adapter_get_type ())")]
        public static readonly nuint ASTAL_BLUETOOTH_TYPE_ADAPTER = (astal_bluetooth_adapter_get_type());

        [NativeTypeName("#define ASTAL_BLUETOOTH_TYPE_DEVICE (astal_bluetooth_device_get_type ())")]
        public static readonly nuint ASTAL_BLUETOOTH_TYPE_DEVICE = (astal_bluetooth_device_get_type());

        [NativeTypeName("#define ASTAL_BLUETOOTH_TYPE_BLUETOOTH (astal_bluetooth_bluetooth_get_type ())")]
        public static readonly nuint ASTAL_BLUETOOTH_TYPE_BLUETOOTH = (astal_bluetooth_bluetooth_get_type());
    }
}
