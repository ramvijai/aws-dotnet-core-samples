#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NETWebAPIDockerDemo/NETWebAPIDockerDemo.csproj", "NETWebAPIDockerDemo/"]
RUN dotnet restore "NETWebAPIDockerDemo/NETWebAPIDockerDemo.csproj"
COPY . .
WORKDIR "/src/NETWebAPIDockerDemo"
RUN dotnet build "NETWebAPIDockerDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NETWebAPIDockerDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NETWebAPIDockerDemo.dll"]