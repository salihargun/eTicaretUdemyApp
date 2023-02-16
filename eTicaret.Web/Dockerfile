FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["eTicaret.Web/eTicaret.Web.csproj", "eTicaret.Web/"]
RUN dotnet restore "eTicaret.Web/eTicaret.Web.csproj"
COPY . .
WORKDIR "/src/eTicaret.Web"
RUN dotnet build "eTicaret.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eTicaret.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eTicaret.Web.dll"]
