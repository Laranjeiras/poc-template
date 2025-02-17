
# COMANDOS DE INSTALAÇÃO VIA CODIGO FONTE
dotnet new --list

dotnet new install .\ --force

dotnet new uninstall my_custom_template

# Outras instalações via nuget

## Instale a ferramenta de templates do .NET globalmente:
dotnet new install Microsoft.TemplateEngine.Authoring.Templates

## Criar o pacote
dotnet pack ROJINE.Template.nuspec

## Instalar o template localmente
dotnet new install ROJINE.CleanArchitecture.Template.1.0.0.nupkg

dotnet nuget push ROJINE.CleanArchitecture.Template.1.0.0.nupkg -Source https://api.nuget.org/v3/index.json -ApiKey sua-api-key

dotnet new install ROJINE.CleanArchitecture.Template
