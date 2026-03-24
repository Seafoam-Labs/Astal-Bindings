namespace Astal.Bindings.AstalGreet
{
    [NativeTypeName("unsigned int")]
    public enum AstalGreetAuthMessageType : uint
    {
        ASTAL_GREET_AUTH_MESSAGE_TYPE_VISIBLE,
        ASTAL_GREET_AUTH_MESSAGE_TYPE_SECRET,
        ASTAL_GREET_AUTH_MESSAGE_TYPE_INFO,
        ASTAL_GREET_AUTH_MESSAGE_TYPE_ERROR,
    }
}
