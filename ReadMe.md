# Curso Desenvolvimento de aplicações com .NET
## Criando a primeira aplicação APS .NET
-
-
### Instação de pacotes do EF -- Sqlite ou SqlServer
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.EntityFrameworkCore.Tools

### Configuração SQLite - SQLite Connection String:
"Data Source = CursoAspMVC.db"

### EF Criação do banco de dados e criação da tabela
Add-Migration InitialCategorias
Update-Database
