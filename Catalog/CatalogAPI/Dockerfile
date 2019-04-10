FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CatalogAPI/CatalogAPI.csproj", "CatalogAPI/"]
RUN dotnet restore "CatalogAPI/CatalogAPI.csproj"
COPY . .
WORKDIR "/src/CatalogAPI"
RUN dotnet build "CatalogAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CatalogAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CatalogAPI.dll"]