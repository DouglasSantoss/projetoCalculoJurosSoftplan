FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 52060
EXPOSE 44397

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CalculaJurosApi/CalculaJurosApi.csproj", "CalculaJurosApi/"]
RUN dotnet restore "CalculaJurosApi/CalculaJurosApi.csproj"
COPY . .
WORKDIR "/src/CalculaJurosApi"
RUN dotnet build "CalculaJurosApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CalculaJurosApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CalculaJurosApi.dll"]