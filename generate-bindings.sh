#!/bin/bash
set +e
export PATH="$PATH:/home/zoey/.dotnet/tools"
export LD_LIBRARY_PATH="/home/zoey/.dotnet/tools/.store/clangsharppinvokegenerator/21.1.8.3/clangsharppinvokegenerator.linux-x64/21.1.8.3/tools/any/linux-x64:${LD_LIBRARY_PATH:-}"

PROJECT_ROOT="/home/zoey/RiderProjects/AstalBindings"
OUTPUT_DIR="$PROJECT_ROOT/AstalBindings/Generated"
REPO="$PROJECT_ROOT/astal-repo/lib"

mkdir -p "$OUTPUT_DIR"

# Collect include directories from pkg-config
GLIB_INCLUDES=""
for flag in $(pkg-config --cflags glib-2.0 gobject-2.0 gio-2.0 gio-unix-2.0 2>/dev/null); do
    case "$flag" in
        -I*) GLIB_INCLUDES="$GLIB_INCLUDES -I ${flag#-I}" ;;
    esac
done

# Map: header_path:library_name:so_name
LIBS=(
    "$REPO/astal/io/build/astal-io.h:AstalIO:libastal-io-0.1.so"
    "$REPO/apps/build/astal-apps.h:AstalApps:libastal-apps-0.1.so"
    "$REPO/astal/gtk3/build/src/astal.h:AstalGtk3:libastal-3.so"
    "$REPO/astal/gtk4/build/src/astal-4.h:AstalGtk4:libastal-4.so"
    "$REPO/auth/build/include/astal-auth.h:AstalAuth:libastal-auth-0.1.so"
    "$REPO/battery/build/astal-battery.h:AstalBattery:libastal-battery-0.1.so"
    "$REPO/bluetooth/build/astal-bluetooth.h:AstalBluetooth:libastal-bluetooth-0.1.so"
    "$REPO/greet/build/astal-greet.h:AstalGreet:libastal-greet-0.1.so"
    "$REPO/hyprland/build/astal-hyprland.h:AstalHyprland:libastal-hyprland-0.1.so"
    "$REPO/mpris/build/astal-mpris.h:AstalMpris:libastal-mpris-0.1.so"
    "$REPO/network/build/astal-network.h:AstalNetwork:libastal-network-0.1.so"
    "$REPO/notifd/build/astal-notifd.h:AstalNotifd:libastal-notifd-0.1.so"
    "$REPO/powerprofiles/build/astal-power-profiles.h:AstalPowerProfiles:libastal-power-profiles-0.1.so"
    "$REPO/river/build/astal-river.h:AstalRiver:libastal-river-0.1.so"
    "$REPO/tray/build/astal-tray.h:AstalTray:libastal-tray-0.1.so"
    "$REPO/wireplumber/build/include/astal-wp.h:AstalWp:libastal-wireplumber-0.1.so"
)

for entry in "${LIBS[@]}"; do
    IFS=':' read -r HEADER NAME SONAME <<< "$entry"
    
    if [ ! -f "$HEADER" ]; then
        echo "SKIP: $HEADER not found"
        continue
    fi

    echo "=== Generating $NAME from $HEADER ==="
    OUTDIR="$OUTPUT_DIR/$NAME"
    mkdir -p "$OUTDIR"

    EXTRA_INCLUDES=""
    case "$NAME" in
        AstalGtk3)
            for flag in $(pkg-config --cflags gtk+-3.0 2>/dev/null); do
                case "$flag" in -I*) EXTRA_INCLUDES="$EXTRA_INCLUDES -I ${flag#-I}" ;; esac
            done
            ;;
        AstalGtk4)
            for flag in $(pkg-config --cflags gtk4 2>/dev/null); do
                case "$flag" in -I*) EXTRA_INCLUDES="$EXTRA_INCLUDES -I ${flag#-I}" ;; esac
            done
            ;;
        AstalTray)
            for flag in $(pkg-config --cflags gdk-pixbuf-2.0 2>/dev/null); do
                case "$flag" in -I*) EXTRA_INCLUDES="$EXTRA_INCLUDES -I ${flag#-I}" ;; esac
            done
            ;;
        AstalNetwork)
            for flag in $(pkg-config --cflags libnm 2>/dev/null); do
                case "$flag" in -I*) EXTRA_INCLUDES="$EXTRA_INCLUDES -I ${flag#-I}" ;; esac
            done
            ;;
    esac

    ClangSharpPInvokeGenerator \
        -f "$HEADER" \
        -n "Astal.Bindings.$NAME" \
        -l "$SONAME" \
        -m "${NAME}Interop" \
        -o "$OUTDIR" \
        -x c \
        -c latest-codegen generate-macro-bindings multi-file unix-types exclude-funcs-with-body \
        -D VALA_EXTERN=extern \
        -D G_BEGIN_DECLS= \
        -D G_END_DECLS= \
        -t "$HEADER" \
        -I /usr/lib/clang/22/include \
        $GLIB_INCLUDES \
        $EXTRA_INCLUDES \
        2>&1

    echo "--- Done: $NAME ---"
    echo ""
done

echo "All bindings generated in $OUTPUT_DIR"
