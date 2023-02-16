FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["eTicaret.API/eTicaret.API.csproj", "eTicaret.API/"]
RUN dotnet restore "eTicaret.API/eTicaret.API.csproj"
COPY . .
WORKDIR "/src/eTicaret.API"
RUN dotnet build "eTicaret.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eTicaret.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eTicaret.API.dll"]
