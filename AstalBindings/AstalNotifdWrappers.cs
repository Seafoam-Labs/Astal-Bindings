using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalNotifd
{
    public unsafe class NotificationAction : GObjectWrapper
    {
        internal NotificationAction(_AstalNotifdAction* handle, bool owned = true) : base(handle, owned) { }

        public string? Id
        {
            get => MarshalString(AstalNotifdInterop.astal_notifd_action_get_id((_AstalNotifdAction*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_action_set_id((_AstalNotifdAction*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? Label
        {
            get => MarshalString(AstalNotifdInterop.astal_notifd_action_get_label((_AstalNotifdAction*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_action_set_label((_AstalNotifdAction*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public void Invoke() => AstalNotifdInterop.astal_notifd_action_invoke((_AstalNotifdAction*)Handle);
    }

    public unsafe class Notification : GObjectWrapper
    {
        public Notification() : base(AstalNotifdInterop.astal_notifd_notification_new()) { }
        internal Notification(_AstalNotifdNotification* handle, bool owned = true) : base(handle, owned) { }

        public uint Id
        {
            get => AstalNotifdInterop.astal_notifd_notification_get_id((_AstalNotifdNotification*)Handle);
            set => AstalNotifdInterop.astal_notifd_notification_set_id((_AstalNotifdNotification*)Handle, value);
        }

        public string? AppName
        {
            get => MarshalString(AstalNotifdInterop.astal_notifd_notification_get_app_name((_AstalNotifdNotification*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_notification_set_app_name((_AstalNotifdNotification*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? AppIcon
        {
            get => MarshalString(AstalNotifdInterop.astal_notifd_notification_get_app_icon((_AstalNotifdNotification*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_notification_set_app_icon((_AstalNotifdNotification*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? Summary
        {
            get => MarshalString(AstalNotifdInterop.astal_notifd_notification_get_summary((_AstalNotifdNotification*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_notification_set_summary((_AstalNotifdNotification*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? Body
        {
            get => MarshalString(AstalNotifdInterop.astal_notifd_notification_get_body((_AstalNotifdNotification*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_notification_set_body((_AstalNotifdNotification*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public int ExpireTimeout
        {
            get => AstalNotifdInterop.astal_notifd_notification_get_expire_timeout((_AstalNotifdNotification*)Handle);
            set => AstalNotifdInterop.astal_notifd_notification_set_expire_timeout((_AstalNotifdNotification*)Handle, value);
        }

        public string? Image
        {
            get => MarshalStringOwned(AstalNotifdInterop.astal_notifd_notification_get_image((_AstalNotifdNotification*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_notification_set_image((_AstalNotifdNotification*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public bool ActionIcons
        {
            get => AstalNotifdInterop.astal_notifd_notification_get_action_icons((_AstalNotifdNotification*)Handle) != 0;
            set => AstalNotifdInterop.astal_notifd_notification_set_action_icons((_AstalNotifdNotification*)Handle, value ? 1 : 0);
        }

        public string? Category
        {
            get => MarshalStringOwned(AstalNotifdInterop.astal_notifd_notification_get_category((_AstalNotifdNotification*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_notification_set_category((_AstalNotifdNotification*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? DesktopEntry
        {
            get => MarshalStringOwned(AstalNotifdInterop.astal_notifd_notification_get_desktop_entry((_AstalNotifdNotification*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_notification_set_desktop_entry((_AstalNotifdNotification*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public bool Resident
        {
            get => AstalNotifdInterop.astal_notifd_notification_get_resident((_AstalNotifdNotification*)Handle) != 0;
            set => AstalNotifdInterop.astal_notifd_notification_set_resident((_AstalNotifdNotification*)Handle, value ? 1 : 0);
        }

        public string? SoundFile
        {
            get => MarshalStringOwned(AstalNotifdInterop.astal_notifd_notification_get_sound_file((_AstalNotifdNotification*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_notification_set_sound_file((_AstalNotifdNotification*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public string? SoundName
        {
            get => MarshalStringOwned(AstalNotifdInterop.astal_notifd_notification_get_sound_name((_AstalNotifdNotification*)Handle));
            set
            {
                IntPtr nativeValue = Marshal.StringToHGlobalAnsi(value);
                try { AstalNotifdInterop.astal_notifd_notification_set_sound_name((_AstalNotifdNotification*)Handle, (sbyte*)nativeValue); }
                finally { Marshal.FreeHGlobal(nativeValue); }
            }
        }

        public bool SuppressSound
        {
            get => AstalNotifdInterop.astal_notifd_notification_get_suppress_sound((_AstalNotifdNotification*)Handle) != 0;
            set => AstalNotifdInterop.astal_notifd_notification_set_suppress_sound((_AstalNotifdNotification*)Handle, value ? 1 : 0);
        }

        public bool Transient
        {
            get => AstalNotifdInterop.astal_notifd_notification_get_transient((_AstalNotifdNotification*)Handle) != 0;
            set => AstalNotifdInterop.astal_notifd_notification_set_transient((_AstalNotifdNotification*)Handle, value ? 1 : 0);
        }

        public int X
        {
            get => AstalNotifdInterop.astal_notifd_notification_get_x((_AstalNotifdNotification*)Handle);
            set => AstalNotifdInterop.astal_notifd_notification_set_x((_AstalNotifdNotification*)Handle, value);
        }

        public int Y
        {
            get => AstalNotifdInterop.astal_notifd_notification_get_y((_AstalNotifdNotification*)Handle);
            set => AstalNotifdInterop.astal_notifd_notification_set_y((_AstalNotifdNotification*)Handle, value);
        }

        public AstalNotifdUrgency Urgency
        {
            get => AstalNotifdInterop.astal_notifd_notification_get_urgency((_AstalNotifdNotification*)Handle);
            set => AstalNotifdInterop.astal_notifd_notification_set_urgency((_AstalNotifdNotification*)Handle, value);
        }

        public AstalNotifdState State => AstalNotifdInterop.astal_notifd_notification_get_state((_AstalNotifdNotification*)Handle);
        public nint Time => AstalNotifdInterop.astal_notifd_notification_get_time((_AstalNotifdNotification*)Handle);

        public void Dismiss() => AstalNotifdInterop.astal_notifd_notification_dismiss((_AstalNotifdNotification*)Handle);
        public void Expire() => AstalNotifdInterop.astal_notifd_notification_expire((_AstalNotifdNotification*)Handle);
        public void Invoke(string actionId)
        {
            IntPtr nativeId = Marshal.StringToHGlobalAnsi(actionId);
            try { AstalNotifdInterop.astal_notifd_notification_invoke((_AstalNotifdNotification*)Handle, (sbyte*)nativeId); }
            finally { Marshal.FreeHGlobal(nativeId); }
        }

        public List<NotificationAction> Actions
        {
            get
            {
                var list = new List<NotificationAction>();
                _GList* gList = AstalNotifdInterop.astal_notifd_notification_get_actions((_AstalNotifdNotification*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new NotificationAction((_AstalNotifdAction*)data, owned: false));
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

    public unsafe class Notifd : GObjectWrapper
    {
        public static Notifd Default => new Notifd(AstalNotifdInterop.astal_notifd_get_default(), owned: false);

        public Notifd() : base(AstalNotifdInterop.astal_notifd_notifd_new()) { }
        internal Notifd(_AstalNotifdNotifd* handle, bool owned = true) : base(handle, owned) { }

        public bool IgnoreTimeout
        {
            get => AstalNotifdInterop.astal_notifd_notifd_get_ignore_timeout((_AstalNotifdNotifd*)Handle) != 0;
            set => AstalNotifdInterop.astal_notifd_notifd_set_ignore_timeout((_AstalNotifdNotifd*)Handle, value ? 1 : 0);
        }

        public bool DontDisturb
        {
            get => AstalNotifdInterop.astal_notifd_notifd_get_dont_disturb((_AstalNotifdNotifd*)Handle) != 0;
            set => AstalNotifdInterop.astal_notifd_notifd_set_dont_disturb((_AstalNotifdNotifd*)Handle, value ? 1 : 0);
        }

        public int DefaultTimeout
        {
            get => AstalNotifdInterop.astal_notifd_notifd_get_default_timeout((_AstalNotifdNotifd*)Handle);
            set => AstalNotifdInterop.astal_notifd_notifd_set_default_timeout((_AstalNotifdNotifd*)Handle, value);
        }

        public List<Notification> Notifications
        {
            get
            {
                var list = new List<Notification>();
                _GList* gList = AstalNotifdInterop.astal_notifd_notifd_get_notifications((_AstalNotifdNotifd*)Handle);
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                        list.Add(new Notification((_AstalNotifdNotification*)data, owned: false));
                }
                return list;
            }
        }

        public Notification? GetNotification(uint id)
        {
            var handle = AstalNotifdInterop.astal_notifd_notifd_get_notification((_AstalNotifdNotifd*)Handle, id);
            return handle != null ? new Notification((_AstalNotifdNotification*)handle, owned: false) : null;
        }

        // Helpers
        [StructLayout(LayoutKind.Sequential)]
        struct GListInternal { public void* data; public GListInternal* next; public GListInternal* prev; }
        private static void* GetData(_GList* list) => ((GListInternal*)list)->data;
        private static _GList* GetNext(_GList* list) => (_GList*)((GListInternal*)list)->next;
    }
}
