FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AdventOfCode.Console/AdventOfCode.Console.csproj", "AdventOfCode.Console/"]
RUN dotnet restore "AdventOfCode.Console/AdventOfCode.Console.csproj"
COPY . .
WORKDIR "/src/AdventOfCode.Console"
RUN dotnet build "AdventOfCode.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdventOfCode.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdventOfCode.Console.dll"]
