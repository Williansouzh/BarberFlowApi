# Usar a imagem oficial do .NET SDK para compilar o projeto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar arquivos do projeto e restaurar dependências
COPY *.sln ./
COPY Application/*.csproj Application/
COPY Domain/*.csproj Domain/
COPY Infrastructure/*.csproj Infrastructure/
COPY BarberFlowApi/*.csproj BarberFlowApi/
RUN dotnet restore

# Copiar todo o código e construir a aplicação
COPY . ./
WORKDIR /app/BarberFlowApi
RUN dotnet publish -c Release -o out

# Criar imagem final para execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/BarberFlowApi/out .

# Definir porta e comando de execução
EXPOSE 8080
CMD ["dotnet", "BarberFlowApi.dll"]
