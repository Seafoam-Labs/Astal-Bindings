namespace Astal.Bindings.AstalPowerProfiles
{
    public unsafe partial struct _AstalPowerProfilesProfile
    {
        [NativeTypeName("gchar *")]
        public sbyte* profile;

        [NativeTypeName("gchar *")]
        public sbyte* cpu_driver;

        [NativeTypeName("gchar *")]
        public sbyte* platform_driver;

        [NativeTypeName("gchar *")]
        public sbyte* driver;
    }
}
