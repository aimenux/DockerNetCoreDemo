#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["App_03/App_03.csproj", "App_03/"]
RUN dotnet restore "App_03/App_03.csproj"
COPY . .
WORKDIR "/src/App_03"
RUN dotnet build "App_03.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "App_03.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "App_03.dll"]