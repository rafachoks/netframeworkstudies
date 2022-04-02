#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Blinks.Project.API/Blinks.Project.API.csproj", "Blinks.Project.API/"]
RUN dotnet restore "Blinks.Project.API/Blinks.Project.API.csproj"
COPY . .
WORKDIR "/src/Blinks.Project.API"
RUN dotnet build "Blinks.Project.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blinks.Project.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blinks.Project.API.dll"]