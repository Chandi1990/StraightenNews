# Use the official ASP.NET Core runtime as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Copy the SSL certificates
COPY certs /https

# Use the SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release

WORKDIR /src
COPY ["Straighten/Straighten.csproj", "Straighten/"]


# Restore the project dependencies
RUN dotnet restore "./Straighten/Straighten.csproj"

# Copy the remaining source code and build the application
COPY . .
WORKDIR "/src/Straighten"
RUN dotnet build "./Straighten.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "./Straighten.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Copy the published application to the final stage image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Straighten.dll"]
