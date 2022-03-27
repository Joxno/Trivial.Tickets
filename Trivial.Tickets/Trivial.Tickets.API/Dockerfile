#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Trivial.Tickets.API/Trivial.Tickets.API.csproj", "Trivial.Tickets.API/"]
RUN dotnet restore "Trivial.Tickets.API/Trivial.Tickets.API.csproj"
COPY . .
WORKDIR "/src/Trivial.Tickets.API"
RUN dotnet build "Trivial.Tickets.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Trivial.Tickets.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Trivial.Tickets.API.dll"]