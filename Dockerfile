FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PhoneEdit.csproj", "./"]
RUN dotnet restore "PhoneEdit.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "PhoneEdit.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PhoneEdit.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PhoneEdit.dll"]