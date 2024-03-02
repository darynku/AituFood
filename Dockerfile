FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 44388

ENV ASPNETCORE_URLS=http://+:44388

FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
ARG configuration=Release
WORKDIR /src
COPY ["AituFood.csproj", "./"]
RUN dotnet restore "AituFood.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "AituFood.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "AituFood.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AituFood.dll"]
