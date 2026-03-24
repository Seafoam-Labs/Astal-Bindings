using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Astal.Bindings.AstalApps
{
    public unsafe class Application : GObjectWrapper
    {
        internal Application(_AstalAppsApplication* handle, bool owned = true) : base(handle, owned) { }

        public string? Name => MarshalString(AstalAppsInterop.astal_apps_application_get_name((_AstalAppsApplication*)Handle));
        public string? Entry => MarshalString(AstalAppsInterop.astal_apps_application_get_entry((_AstalAppsApplication*)Handle));
        public string? Description => MarshalString(AstalAppsInterop.astal_apps_application_get_description((_AstalAppsApplication*)Handle));
        public string? WmClass => MarshalString(AstalAppsInterop.astal_apps_application_get_wm_class((_AstalAppsApplication*)Handle));
        public string? Executable => MarshalStringOwned(AstalAppsInterop.astal_apps_application_get_executable((_AstalAppsApplication*)Handle));
        public string? IconName => MarshalStringOwned(AstalAppsInterop.astal_apps_application_get_icon_name((_AstalAppsApplication*)Handle));

        public bool Launch() => AstalAppsInterop.astal_apps_application_launch((_AstalAppsApplication*)Handle) != 0;

        public int Frequency
        {
            get => AstalAppsInterop.astal_apps_application_get_frequency((_AstalAppsApplication*)Handle);
            set => AstalAppsInterop.astal_apps_application_set_frequency((_AstalAppsApplication*)Handle, value);
        }
    }

    public unsafe class Apps : GObjectWrapper
    {
        public Apps() : base(AstalAppsInterop.astal_apps_apps_new()) { }
        internal Apps(_AstalAppsApps* handle, bool owned = true) : base(handle, owned) { }

        public List<Application> List
        {
            get
            {
                var list = new List<Application>();
                _GList* gList = AstalAppsInterop.astal_apps_apps_get_list((_AstalAppsApps*)Handle);
                // Simple GList traversal
                for (var curr = gList; curr != null; curr = GetNext(curr))
                {
                    void* data = GetData(curr);
                    if (data != null)
                    {
                        list.Add(new Application((_AstalAppsApplication*)data, owned: false));
                    }
                }
                return list;
            }
        }

        public void Reload() => AstalAppsInterop.astal_apps_apps_reload((_AstalAppsApps*)Handle);

        // Helper methods for GList traversal - these would ideally be in a GList utility
        [StructLayout(LayoutKind.Sequential)]
        struct GListInternal { public void* data; public GListInternal* next; public GListInternal* prev; }
        private static void* GetData(_GList* list) => ((GListInternal*)list)->data;
        private static _GList* GetNext(_GList* list) => (_GList*)((GListInternal*)list)->next;
    }
}
