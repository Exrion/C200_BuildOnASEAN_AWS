#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["C200 Web Application/C200 Web Application.csproj", "C200 Web Application/"]
RUN dotnet restore "C200 Web Application/C200 Web Application.csproj"
COPY . .
WORKDIR "/src/C200 Web Application"
RUN dotnet build "C200 Web Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "C200 Web Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "C200 Web Application.dll"]