# Construindo uma aplicação C# com ASP .NET Core e MySQL
Construindo uma aplicação C# com ASP .NET Core e MySQL

## Foram instalados os pacotes:
	- MySql.Data.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Tools

## Comandos
* Criando o banco
```sh
$ Add-Migration InitialCreate
```

* Adicionando novas migrações
```sh
$ Add-Migration <NomeDaMigracaoAqui>
```
> O EntityFrameworkCore.Tools vai criando um histórico das migrações

* Para desfazer a migração criada
```sh
$ Remove-Migration
``

* Atualizando o banco com a migração criada
```sh
$ Update-Database
```
