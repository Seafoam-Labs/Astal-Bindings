#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
REPO_DIR="$SCRIPT_DIR/astal-repo"
REPO_URL="https://github.com/Aylur/astal.git"

# Clone the astal repo if not already present
if [ ! -d "$REPO_DIR" ]; then
    echo "Cloning astal repo..."
    git clone "$REPO_URL" "$REPO_DIR"
else
    echo "astal-repo already exists, pulling latest..."
    git -C "$REPO_DIR" pull --ff-only || echo "Warning: pull failed, using existing checkout"
fi

# Libraries that need meson setup to generate headers
# Each entry is the path relative to astal-repo/lib
LIB_DIRS=(
    astal/io
    astal/gtk3
    astal/gtk4
    apps
    auth
    battery
    bluetooth
    greet
    hyprland
    mpris
    network
    notifd
    powerprofiles
    river
    tray
    wireplumber
)

echo ""
echo "Running meson setup for each library..."

FAILED=()
for lib in "${LIB_DIRS[@]}"; do
    LIB_PATH="$REPO_DIR/lib/$lib"
    if [ ! -f "$LIB_PATH/meson.build" ]; then
        echo "SKIP: $LIB_PATH has no meson.build"
        continue
    fi

    echo "=== Setting up $lib ==="
    if [ -d "$LIB_PATH/build" ]; then
        echo "  build/ already exists, skipping (delete it to regenerate)"
    else
        if meson setup "$LIB_PATH/build" "$LIB_PATH" 2>&1 | tail -5; then
            echo "  OK"
        else
            echo "  FAILED (may be missing dependencies)"
            FAILED+=("$lib")
        fi
    fi
done

echo ""
if [ ${#FAILED[@]} -gt 0 ]; then
    echo "The following libraries failed to configure (install missing deps and re-run):"
    for f in "${FAILED[@]}"; do
        echo "  - $f"
    done
else
    echo "All libraries configured successfully."
fi

echo ""
echo "Setup complete. You can now run: bash generate-bindings.sh"
