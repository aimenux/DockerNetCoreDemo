#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["App_02/App_02.csproj", "App_02/"]
RUN dotnet restore "App_02/App_02.csproj"
COPY . .
WORKDIR "/src/App_02"
RUN dotnet build "App_02.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "App_02.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "App_02.dll"]