namespace Astal.Bindings.AstalPowerProfiles
{
    public unsafe partial struct _AstalPowerProfilesHold
    {
        [NativeTypeName("gchar *")]
        public sbyte* application_id;

        [NativeTypeName("gchar *")]
        public sbyte* profile;

        [NativeTypeName("gchar *")]
        public sbyte* reason;
    }
}
