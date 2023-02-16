FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/testing.Web.Host/testing.Web.Host.csproj", "src/testing.Web.Host/"]
COPY ["src/testing.Web.Core/testing.Web.Core.csproj", "src/testing.Web.Core/"]
COPY ["src/testing.Application/testing.Application.csproj", "src/testing.Application/"]
COPY ["src/testing.Core/testing.Core.csproj", "src/testing.Core/"]
COPY ["src/testing.EntityFrameworkCore/testing.EntityFrameworkCore.csproj", "src/testing.EntityFrameworkCore/"]
WORKDIR "/src/src/testing.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/testing.Web.Host", "src/testing.Web.Host"]
COPY ["src/testing.Web.Core", "src/testing.Web.Core"]
COPY ["src/testing.Application", "src/testing.Application"]
COPY ["src/testing.Core", "src/testing.Core"]
COPY ["src/testing.EntityFrameworkCore", "src/testing.EntityFrameworkCore"]
WORKDIR "/src/src/testing.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "testing.Web.Host.dll"]
