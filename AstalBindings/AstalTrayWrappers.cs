using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalTray
{
    public unsafe class TrayItem : GObjectWrapper
    {
        internal TrayItem(_AstalTrayTrayItem* handle, bool owned = true) : base(handle, owned) { }

        public string? Title => MarshalString(AstalTrayInterop.astal_tray_tray_item_get_title((_AstalTrayTrayItem*)Handle));
        public AstalTrayCategory Category => AstalTrayInterop.astal_tray_tray_item_get_category((_AstalTrayTrayItem*)Handle);
        public AstalTrayStatus Status => AstalTrayInterop.astal_tray_tray_item_get_status((_AstalTrayTrayItem*)Handle);
        public string? Id => MarshalString(AstalTrayInterop.astal_tray_tray_item_get_id((_AstalTrayTrayItem*)Handle));
        public bool IsMenu => AstalTrayInterop.astal_tray_tray_item_get_is_menu((_AstalTrayTrayItem*)Handle) != 0;
        public string? IconThemePath => MarshalString(AstalTrayInterop.astal_tray_tray_item_get_icon_theme_path((_AstalTrayTrayItem*)Handle));
        public string? IconName => MarshalStringOwned(AstalTrayInterop.astal_tray_tray_item_get_icon_name((_AstalTrayTrayItem*)Handle));
        public string? ItemId => MarshalString(AstalTrayInterop.astal_tray_tray_item_get_item_id((_AstalTrayTrayItem*)Handle));
        public string? MenuPath => MarshalString(AstalTrayInterop.astal_tray_tray_item_get_menu_path((_AstalTrayTrayItem*)Handle));
        public string? TooltipMarkup => MarshalStringOwned(AstalTrayInterop.astal_tray_tray_item_get_tooltip_markup((_AstalTrayTrayItem*)Handle));
        public string? TooltipText => MarshalStringOwned(AstalTrayInterop.astal_tray_tray_item_get_tooltip_text((_AstalTrayTrayItem*)Handle));

        public void AboutToShow() => AstalTrayInterop.astal_tray_tray_item_about_to_show((_AstalTrayTrayItem*)Handle);
        public void Activate(int x, int y) => AstalTrayInterop.astal_tray_tray_item_activate((_AstalTrayTrayItem*)Handle, x, y);
        public void SecondaryActivate(int x, int y) => AstalTrayInterop.astal_tray_tray_item_secondary_activate((_AstalTrayTrayItem*)Handle, x, y);
        public void Scroll(int delta, string orientation)
        {
            fixed (char* pOrientation = orientation)
            {
                // Note: orientation is const gchar*, we need ANSI string. MarshalString uses PtrToStringAnsi for reading,
                // but here we need to pass a string to native.
                // For simplicity in this binding project, we might use Marshal.StringToCoTaskMemAnsi or similar if needed,
                // but let's see if we can just use a helper or if it's already handled.
                // Actually, P/Invoke for string parameters in AstalTrayInterop usually handles this if defined correctly.
            }
            // Looking at AstalTrayInterop.astal_tray_tray_item_scroll:
            // public static extern void astal_tray_tray_item_scroll([NativeTypeName("AstalTrayTrayItem *")] _AstalTrayTrayItem* self, [NativeTypeName("gint")] int delta, [NativeTypeName("const gchar *")] sbyte* orientation);
            
            IntPtr nativeOrientation = Marshal.StringToHGlobalAnsi(orientation);
            try
            {
                AstalTrayInterop.astal_tray_tray_item_scroll((_AstalTrayTrayItem*)Handle, delta, (sbyte*)nativeOrientation);
            }
            finally
            {
                Marshal.FreeHGlobal(nativeOrientation);
            }
        }

        private delegate void ChangedDelegate(void* self, void* data);
        private ChangedDelegate? _onChanged;
        private Action? _changedAction;

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
            remove => _changedAction -= value;
        }
    }

    public unsafe class Tray : GObjectWrapper
    {
        public static Tray Default => new Tray(AstalTrayInterop.astal_tray_get_default(), owned: false);

        public Tray() : base(AstalTrayInterop.astal_tray_tray_new()) { }
        internal Tray(_AstalTrayTray* handle, bool owned = true) : base(handle, owned) { }

        public TrayItem? GetItem(string itemId)
        {
            IntPtr nativeId = Marshal.StringToHGlobalAnsi(itemId);
            try
            {
                var handle = AstalTrayInterop.astal_tray_tray_get_item((_AstalTrayTray*)Handle, (sbyte*)nativeId);
                return handle != null ? new TrayItem(handle, owned: false) : null;
            }
            finally
            {
                Marshal.FreeHGlobal(nativeId);
            }
        }

        public List<TrayItem> Items
        {
            get
            {
                var list = new List<TrayItem>();
                _GList* gList = AstalTrayInterop.astal_tray_tray_get_items((_AstalTrayTray*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new TrayItem((_AstalTrayTrayItem*)data, owned: false));
                }
                return list;
            }
        }

        private delegate void ItemAddedDelegate(void* self, sbyte* itemId, void* data);
        private ItemAddedDelegate? _onItemAdded;
        private Action<string>? _itemAddedAction;

        public event Action<string>? ItemAdded
        {
            add
            {
                if (_onItemAdded == null)
                {
                    _onItemAdded = (self, itemId, data) => _itemAddedAction?.Invoke(Marshal.PtrToStringAnsi((IntPtr)itemId) ?? "");
                    Connect("item-added", Marshal.GetFunctionPointerForDelegate(_onItemAdded));
                }
                _itemAddedAction += value;
            }
            remove => _itemAddedAction -= value;
        }

        private delegate void ItemRemovedDelegate(void* self, sbyte* itemId, void* data);
        private ItemRemovedDelegate? _onItemRemoved;
        private Action<string>? _itemRemovedAction;

        public event Action<string>? ItemRemoved
        {
            add
            {
                if (_onItemRemoved == null)
                {
                    _onItemRemoved = (self, itemId, data) => _itemRemovedAction?.Invoke(Marshal.PtrToStringAnsi((IntPtr)itemId) ?? "");
                    Connect("item-removed", Marshal.GetFunctionPointerForDelegate(_onItemRemoved));
                }
                _itemRemovedAction += value;
            }
            remove => _itemRemovedAction -= value;
        }

        // Helpers
        [StructLayout(LayoutKind.Sequential)]
        struct GListInternal { public void* data; public GListInternal* next; public GListInternal* prev; }
        private static void* GetData(_GList* list) => ((GListInternal*)list)->data;
        private static _GList* GetNext(_GList* list) => (_GList*)((GListInternal*)list)->next;
    }
}
