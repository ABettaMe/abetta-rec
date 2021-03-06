FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /DockerSource

COPY Recommendations/bin/Release/net5.0/. .

# For local uncomment this and comment line 8
# ENTRYPOINT ["dotnet", "Recommendations.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Recommendations.dll