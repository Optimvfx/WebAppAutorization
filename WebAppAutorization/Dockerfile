FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebAppAutorization/WebAppAutorization.csproj", "WebAppAutorization/"]
RUN dotnet restore "WebAppAutorization/WebAppAutorization.csproj"
COPY . .
WORKDIR "/src/WebAppAutorization"
RUN dotnet build "WebAppAutorization.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebAppAutorization.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAppAutorization.dll"]
