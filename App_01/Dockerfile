#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["App_01/App_01.csproj", "App_01/"]
RUN dotnet restore "App_01/App_01.csproj"
COPY . .
WORKDIR "/src/App_01"
RUN dotnet build "App_01.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "App_01.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "App_01.dll"]