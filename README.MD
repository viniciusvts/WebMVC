# Construindo uma aplica��o C# com ASP .NET Core e MySQL
Construindo uma aplica��o C# com ASP .NET Core e MySQL

## Foram instalados os pacotes:
	- MySql.Data.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Tools

## Comandos
* Criando o banco
```sh
$ Add-Migration InitialCreate
```

* Adicionando novas migra��es
```sh
$ Add-Migration <NomeDaMigracaoAqui>
```
> O EntityFrameworkCore.Tools vai criando um hist�rico das migra��es

* Para desfazer a migra��o criada
```sh
$ Remove-Migration
``

* Atualizando o banco com a migra��o criada
```sh
$ Update-Database
```
