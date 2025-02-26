# Use a .NET SDK base image
FROM mcr.microsoft.com/dotnet/sdk:9.0

# Install necessary dependencies and tools
RUN apt-get update && apt-get install -y unzip zip git neovim curl wget

# Install MAUI workload (this part might require manual package installation)
# RUN dotnet workload install maui-android (if this works, otherwise manual installation)

# MAUI workload manifests
RUN mkdir -p /usr/share/dotnet/sdk-manifests/9.0.100/microsoft.net.sdk.maui && \
    curl -L https://raw.githubusercontent.com/jsuarezruiz/maui-linux/main/WorkloadManifest.json \
    -o /usr/share/dotnet/sdk-manifests/9.0.100/microsoft.net.sdk.maui/WorkloadManifest.json && \
    curl -L https://raw.githubusercontent.com/jsuarezruiz/maui-linux/main/WorkloadManifest.targets \
    -o /usr/share/dotnet/sdk-manifests/9.0.100/microsoft.net.sdk.maui/WorkloadManifest.targets

# Install workloads
RUN dotnet workload install maui \
    --skip-manifest-update \
    --source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet9/nuget/v3/index.json \
    --source https://pkgs.dev.azure.com/azure-public/vside/_packaging/xamarin-impl/nuget/v3/index.json


# Create a new MAUI app inside the container
WORKDIR /app
RUN dotnet new maui -f net9.0 -o MyMauiApp
WORKDIR /app/MyMauiApp

# Expose a port if needed
EXPOSE 8080

# Run command to start interactive shell
CMD ["bash"]
