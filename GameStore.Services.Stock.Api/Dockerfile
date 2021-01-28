FROM mcr.microsoft.com/dotnet/runtime:3.1 As base
WORKDIR /app
# EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY *.sln .
COPY GameStore.Services.Stock.Api/*.csproj GameStore.Services.Stock.Api/
COPY Application/*.csproj Application/
COPY Domain/*.csproj Domain/
COPY Infrastructure/*.csproj Infrastructure/
RUN dotnet restore 
COPY . .
WORKDIR /src/GameStore.Services.Stock.Api
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet","GameStore.Services.Stock.Api.dll"]