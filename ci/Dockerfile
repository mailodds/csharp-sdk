FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /sdk
COPY . .
RUN dotnet build --configuration Release --verbosity quiet
WORKDIR /smoke
RUN dotnet new console --force --no-restore
COPY ci/smoke_test.cs Program.cs
RUN dotnet add reference /sdk/src/MailOdds/MailOdds.csproj
RUN dotnet build --verbosity quiet
CMD ["dotnet", "run"]
