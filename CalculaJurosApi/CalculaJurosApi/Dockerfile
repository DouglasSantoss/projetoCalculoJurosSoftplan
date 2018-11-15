#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:latest
WORKDIR /src
COPY ["CalculaJurosApi/CalculaJurosApi.csproj", "CalculaJurosApi/"]
RUN dotnet restore "CalculaJurosApi/CalculaJurosApi.csproj"
RUN dotnet build

EXPOSE 5000/tcp

ENV ASPNETCORE_URLS http://*:5000
ENV ASPNETCORE_ENVIRONMENT docker

ENTRYPOINT dotnet run