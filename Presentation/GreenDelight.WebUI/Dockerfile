# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Presentation/GreenDelight.WebUI/GreenDelight.WebUI.csproj", "Presentation/GreenDelight.WebUI/"]
COPY ["Core/GreenDelight.Apllication/GreenDelight.Application.csproj", "Core/GreenDelight.Apllication/"]
COPY ["Core/GreenDelight.Domain/GreenDelight.Domain.csproj", "Core/GreenDelight.Domain/"]
COPY ["Infrastructure/GreenDelight.Infrastructure/GreenDelight.Infrastructure.csproj", "Infrastructure/GreenDelight.Infrastructure/"]
COPY ["Infrastructure/GreenDelight.Persistence/GreenDelight.Persistence.csproj", "Infrastructure/GreenDelight.Persistence/"]
RUN dotnet restore "./Presentation/GreenDelight.WebUI/GreenDelight.WebUI.csproj"
COPY . .
WORKDIR "/src/Presentation/GreenDelight.WebUI"
RUN dotnet build "./GreenDelight.WebUI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./GreenDelight.WebUI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GreenDelight.WebUI.dll"]