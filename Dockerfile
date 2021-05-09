FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /DockerSource

COPY Recommendations/bin/Release/net5.0/. .
ENTRYPOINT ["dotnet", "Recommendations.dll"]