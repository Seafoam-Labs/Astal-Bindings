namespace Astal.Bindings.AstalNetwork
{
    [NativeTypeName("unsigned int")]
    public enum AstalNetworkConnectivity : uint
    {
        ASTAL_NETWORK_CONNECTIVITY_UNKNOWN,
        ASTAL_NETWORK_CONNECTIVITY_NONE,
        ASTAL_NETWORK_CONNECTIVITY_PORTAL,
        ASTAL_NETWORK_CONNECTIVITY_LIMITED,
        ASTAL_NETWORK_CONNECTIVITY_FULL,
    }
}
