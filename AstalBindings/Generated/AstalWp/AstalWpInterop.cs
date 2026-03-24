using System;

namespace Astal.Bindings.AstalWp
{
    public static partial class AstalWpInterop
    {
        [NativeTypeName("#define ASTAL_WP_MAJOR_VERSION 0")]
        public const int ASTAL_WP_MAJOR_VERSION = 0;

        [NativeTypeName("#define ASTAL_WP_MINOR_VERSION 1")]
        public const int ASTAL_WP_MINOR_VERSION = 1;

        [NativeTypeName("#define ASTAL_WP_MICRO_VERSION 0")]
        public const int ASTAL_WP_MICRO_VERSION = 0;

        [NativeTypeName("#define ASTAL_WP_VERSION \"0.1.0\"")]
        public static ReadOnlySpan<byte> ASTAL_WP_VERSION => "0.1.0"u8;
    }
}
