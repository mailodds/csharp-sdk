FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /sdk
COPY . .
# Fix namespace conflict: MailOdds.Model.ValidationResult shadows System.ComponentModel.DataAnnotations.ValidationResult
RUN find src/MailOdds/Model -name '*.cs' -exec sed -i \
    's/IEnumerable<ValidationResult> IValidatableObject.Validate/IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate/g' {} + \
 && find src/MailOdds/Model -name '*.cs' ! -name 'ValidationResult.cs' -exec sed -i \
    's/new ValidationResult(/new System.ComponentModel.DataAnnotations.ValidationResult(/g' {} +
RUN dotnet build src/MailOdds/MailOdds.csproj --configuration Release --verbosity quiet
WORKDIR /smoke
RUN dotnet new console --force --no-restore
COPY ci/smoke_test.cs Program.cs
RUN dotnet add reference /sdk/src/MailOdds/MailOdds.csproj
RUN dotnet build --verbosity quiet
CMD ["dotnet", "run"]
