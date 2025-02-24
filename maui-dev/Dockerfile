

FROM mcr.microsoft.com/dotnet/sdk:9.0-preview-jammy

RUN apt update && apt install -y libgtk-3-0 libwebkit2gtk-4.0-37 libx11-dev libgconf2-dev libgl1-mesa-dev xauth && rm -rf /var/lib/apt/lists/*

RUN dotnet workload install maui --skip-manifest-update --source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet9/nuget/v3/index.json