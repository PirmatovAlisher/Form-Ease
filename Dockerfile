# Use SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and projects
COPY ./*.sln ./
COPY ./FormEase.UI/*.csproj ./FormEase.UI/
COPY ./FormEase.Core/*.csproj ./FormEase.Core/
COPY ./FormEase.Infrastructure.PostgreSQL/*.csproj ./FormEase.Infrastructure.PostgreSQL/
COPY ./FormEase.Services/*.csproj ./FormEase.Services/

# Restore NuGet packages
RUN dotnet restore

# Copy everything else
COPY . .

# Build and publish
WORKDIR /src/FormEase.UI
RUN dotnet publish -c Release -o /app/publish

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Render requires this
ENV ASPNETCORE_URLS=http://*:$PORT
ENV DOTNET_RUNNING_IN_CONTAINER=true
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Entry point
ENTRYPOINT ["dotnet", "FormEase.UI.dll"]
