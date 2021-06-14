#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /app
COPY . ./
RUN dotnet restore 

COPY . ./
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
EXPOSE 5000


COPY --from=build /app/Portfolio/PortfolioDb.db .
COPY --from=build /app/publish .
#ENTRYPOINT ["dotnet", "Portfolio.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Portfolio.dll