#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Vuelos.WebApi/Vuelos.WebApi.csproj", "Vuelos.WebApi/"]
COPY ["Vuelos.Infraestructure/Vuelos.Infraestructure.csproj", "Vuelos.Infraestructure/"]
COPY ["Vuelos.Application/Vuelos.Application.csproj", "Vuelos.Application/"]
COPY ["Vuelos.Domain/Vuelos.Domain.csproj", "Vuelos.Domain/"]
COPY ["ShareKernel/ShareKernel.csproj", "ShareKernel/"]
RUN dotnet restore "Vuelos.WebApi/Vuelos.WebApi.csproj"
COPY . .
WORKDIR "/src/Vuelos.WebApi"
RUN dotnet build "Vuelos.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vuelos.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vuelos.WebApi.dll"]