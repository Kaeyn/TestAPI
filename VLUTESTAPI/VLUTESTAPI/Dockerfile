FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

#FROM mcr.microsoft.com/dotnet/sdk:3.1-alpine AS build
# Copy everything needed to run the app from the "build" stage.
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#COPY ["VLUTESTAPI.csproj", "./VLUTESTAPI/VLUTESTAPI/"]
#RUN dotnet restore "./VLUTESTAPI.csproj"
#COPY . .
#WORKDIR "/src/."
#RUN dotnet build "VLUTESTAPI.csproj" -c Release -o /app/build

#FROM build AS publish
#RUN dotnet publish "VLUTESTAPI.csproj" -c Release -o /app/publish

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "VLUTESTAPI.dll"]

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["VLUTESTAPI/VLUTESTAPI.csproj", "VLUTESTAPI/"]
RUN dotnet restore "VLUTESTAPI/VLUTESTAPI.csproj"
COPY . .
WORKDIR "/src/VLUTESTAPI"
RUN dotnet build "VLUTESTAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VLUTESTAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VLUTESTAPI.dll"]
