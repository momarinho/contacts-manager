# Contacts Manager

Aplicacao ASP.NET Core MVC para gerenciamento de contatos com Entity Framework Core e SQL Server.

## Stack

- .NET 10
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Nix Flakes para ambiente de desenvolvimento

## Como executar

1. Entre no ambiente Nix:

```bash
nix develop
```

2. Configure a connection string local com User Secrets:

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost,1433;Database=ContactsManagerDB;UID=sa;Password=SUA_SENHA;TrustServerCertificate=True;"
```

3. Restaure os pacotes, a ferramenta local do EF, aplique as migrations e inicie a aplicacao:

```bash
dotnet restore
dotnet tool restore
dotnet tool run dotnet-ef -- database update
dotnet run
```

## Estrutura

- `Controllers/`: endpoints MVC
- `Models/`: entidades e validacoes
- `Data/`: `ApplicationDbContext`
- `Views/`: telas Razor
- `Migrations/`: historico do banco

## Observacoes

- O projeto usa `net10.0`
- O ambiente de desenvolvimento oficial e o `flake.nix`
- Credenciais nao devem ser versionadas em `appsettings.json`
- Use [appsettings.Example.json](/home/mateus/Documents/contacts-manager/appsettings.Example.json:1) apenas como referencia estrutural
