FROM mcr.microsoft.com/dotnet/sdk:6.0 as Build

WORKDIR /app

COPY ./WebAppJenkins.sln ./
COPY ./src/WebAppJ.Api/WebAppJ.Api.csproj ./src/WebAppJ.Api/
COPY ./src/WebAppJ.BL/WebAppJ.BL.csproj ./src/WebAppJ.BL/
COPY ./src/WebAppJ.DAL/WebAppJ.DAL.csproj ./src/WebAppJ.DAL/
COPY ./test/WebAppJ.Tests/WebAppJ.Tests.csproj ./test/WebAppJ.Tests/

RUN dotnet restore WebAppJenkins.sln

COPY ./src ./src
COPY ./test ./test

RUN dotnet build -c Release --no-restore
#RUN dotnet test -c Release --no-build --no-restore
# OR
RUN dotnet test ./test/WebAppJ.Tests/WebAppJ.Tests.csproj -c Release --no-build --no-restore
RUN dotnet publish ./src/WebAppJ.Api/WebAppJ.Api.csproj -c Release -o dist --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=Build /app/dist .
EXPOSE 80
ENTRYPOINT ["dotnet", "WebAppJ.Api.dll"]