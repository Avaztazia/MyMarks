FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MyMarks/MyMarks.csproj", "MyMarks/"]
RUN dotnet restore "MyMarks/MyMarks.csproj"
COPY . .
WORKDIR "/src/MyMarks"
RUN dotnet build "MyMarks.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyMarks.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyMarks.dll"]
