namespace Astal.Bindings.AstalNetwork
{
    [NativeTypeName("unsigned int")]
    public enum AstalNetworkState : uint
    {
        ASTAL_NETWORK_STATE_UNKNOWN = 0,
        ASTAL_NETWORK_STATE_ASLEEP = 10,
        ASTAL_NETWORK_STATE_DISCONNECTED = 20,
        ASTAL_NETWORK_STATE_DISCONNECTING = 30,
        ASTAL_NETWORK_STATE_CONNECTING = 40,
        ASTAL_NETWORK_STATE_CONNECTED_LOCAL = 50,
        ASTAL_NETWORK_STATE_CONNECTED_SITE = 60,
        ASTAL_NETWORK_STATE_CONNECTED_GLOBAL = 70,
    }
}
