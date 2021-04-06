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

#### Observação: Microsoft.EntityFrameworkCore.Tools e Microsoft.EntityFrameworkCore.Design mesma versão 3.1.13
#### ---------- : Microsoft.VisualStudio.Web.CodeGeneration.Design versão 3.1.5
#### ---------- : Tem que instalar o Microsoft.EntityFrameworkCore.SqlServer versão 3.1.13
#### ---------- : Tem que instalar o Microsoft.EntityFrameworkCore.Sqlite versão 3.1.13
### EF Criação da segunta tabela -- Produtos
Add-Migration TabelaProdutos
Update-Database