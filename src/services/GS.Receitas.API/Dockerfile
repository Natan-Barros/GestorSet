#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/services/GS.Receitas.API/GS.Receitas.API.csproj", "src/services/GS.Receitas.API/"]
RUN dotnet restore "src/services/GS.Receitas.API/GS.Receitas.API.csproj"
COPY . .
WORKDIR "/src/src/services/GS.Receitas.API"
RUN dotnet build "GS.Receitas.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GS.Receitas.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GS.Receitas.API.dll"]