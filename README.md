# AstalBindings

C# P/Invoke bindings for the [Astal](https://github.com/Aylur/astal) library collection.

## Included Libraries

| Library | Shared Object |
|---------|--------------|
| AstalIO | `libastal-io-0.1.so` |
| AstalApps | `libastal-apps-0.1.so` |
| AstalGtk3 | `libastal-3.so` |
| AstalGtk4 | `libastal-4.so` |
| AstalAuth | `libastal-auth-0.1.so` |
| AstalBattery | `libastal-battery-0.1.so` |
| AstalBluetooth | `libastal-bluetooth-0.1.so` |
| AstalGreet | `libastal-greet-0.1.so` |
| AstalHyprland | `libastal-hyprland-0.1.so` |
| AstalMpris | `libastal-mpris-0.1.so` |
| AstalNetwork | `libastal-network-0.1.so` |
| AstalNotifd | `libastal-notifd-0.1.so` |
| AstalPowerProfiles | `libastal-power-profiles-0.1.so` |
| AstalRiver | `libastal-river-0.1.so` |
| AstalTray | `libastal-tray-0.1.so` |
| AstalWp | `libastal-wireplumber-0.1.so` |

## Installation

```bash
dotnet add package AstalBindings
```

## Prerequisites

The native Astal libraries must be installed on your system.

### Arch Linux (AUR)

Install all Astal libraries using your preferred AUR helper:

```bash
# Using yay
yay -S libastal-meta

# Using paru
paru -S libastal-meta

# Using shelly
shelly aur install libastal-meta
```

For more installation options (Nix, building from source, etc.), see the [Astal documentation](https://github.com/Aylur/astal).

## Regenerating Bindings

To regenerate the bindings from source:

1. Install [ClangSharpPInvokeGenerator](https://github.com/dotnet/ClangSharp):
   ```bash
   dotnet tool install --global ClangSharpPInvokeGenerator
   ```

2. Clone the Astal repo and build headers:
   ```bash
   ./setup.sh
   ```

3. Generate the bindings:
   ```bash
   ./generate-bindings.sh
   ```

## License

[MIT](LICENSE)
