# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and project files
COPY ./*.sln ./
COPY ./FormEase.UI/*.csproj ./FormEase.UI/
COPY ./FormEase.Core/*.csproj ./FormEase.Core/
COPY ./FormEase.Infrastructure.PostgreSQL/*.csproj ./FormEase.Infrastructure.PostgreSQL/
COPY ./FormEase.Services/*.csproj ./FormEase.Services/

# Restore dependencies
RUN dotnet restore

# Copy everything else
COPY . .

# Build application
WORKDIR /src/FormEase.UI
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Set environment variables
ENV ASPNETCORE_URLS=http://*:$PORT
ENV ASPNETCORE_ENVIRONMENT=Production

# Run the app
ENTRYPOINT ["dotnet", "FormEase.UI.dll"]
