# Enable BuildKit features
# syntax=docker/dockerfile:1.4

FROM mcr.microsoft.com/dotnet/sdk:9.0-preview-jammy AS build

# Install MAUI Linux dependencies
RUN apt-get update && \
    apt-get install -y \
    libgtk-3-0 \
    libwebkit2gtk-4.0-37 \
    libx11-dev \
    libgconf2-dev \
    libgl1-mesa-dev \
    xauth \
    && rm -rf /var/lib/apt/lists/*

# Add MAUI Linux workload manifests
RUN mkdir -p /usr/share/dotnet/sdk-manifests/9.0.100/microsoft.net.sdk.maui && \
    curl -L https://raw.githubusercontent.com/jsuarezruiz/maui-linux/main/WorkloadManifest.json \
    -o /usr/share/dotnet/sdk-manifests/9.0.100/microsoft.net.sdk.maui/WorkloadManifest.json && \
    curl -L https://raw.githubusercontent.com/jsuarezruiz/maui-linux/main/WorkloadManifest.targets \
    -o /usr/share/dotnet/sdk-manifests/9.0.100/microsoft.net.sdk.maui/WorkloadManifest.targets

# Install MAUI workload with Linux support
RUN dotnet workload install maui \
    --skip-manifest-update \
    --source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet9/nuget/v3/index.json \
    --source https://api.nuget.org/v3/index.json \
    --source https://pkgs.dev.azure.com/azure-public/vside/_packaging/xamarin-impl/nuget/v3/index.json

WORKDIR /app