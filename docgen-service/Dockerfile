#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["docgen-service/docgen-service.csproj", "docgen-service/"]
RUN dotnet restore "docgen-service/docgen-service.csproj"
COPY . .
WORKDIR "/src/docgen-service"
RUN dotnet build "docgen-service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "docgen-service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "docgen-service.dll"]