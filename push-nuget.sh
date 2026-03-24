#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJECT="$SCRIPT_DIR/AstalBindings/AstalBindings.csproj"

# Configuration
NUGET_SOURCE="${NUGET_SOURCE:-https://api.nuget.org/v3/index.json}"

if [ -z "$NUGET_API_KEY" ]; then
    echo "Error: NUGET_API_KEY environment variable is not set."
    echo "Usage: NUGET_API_KEY=your-key ./push-nuget.sh"
    exit 1
fi

echo "=== Packing AstalBindings ==="
dotnet pack "$PROJECT" -c Release -o "$SCRIPT_DIR/nupkg"

NUPKG=$(find "$SCRIPT_DIR/nupkg" -name "AstalBindings.*.nupkg" | sort -V | tail -1)

if [ -z "$NUPKG" ]; then
    echo "Error: No .nupkg file found after packing."
    exit 1
fi

echo "=== Pushing $NUPKG to $NUGET_SOURCE ==="
dotnet nuget push "$NUPKG" \
    --api-key "$NUGET_API_KEY" \
    --source "$NUGET_SOURCE" \
    --skip-duplicate

echo "=== Done ==="
