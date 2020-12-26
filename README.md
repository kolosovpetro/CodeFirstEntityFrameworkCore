# Code First with Entity Framework

Simple example of Entity Framework Core Code-First approach.

## Data base schema

![DbSchema](DbSchema.JPG?raw=true)

## Which packages to use?

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Npgsql.EntityFrameworkCore.PostgreSQL`

## Entity Framework CLI commands

- `dotnet-ef migrations add SqlServerInitialMigration --project CodeFirst.DataAccess --context SqlServerContext`
- `dotnet-ef migrations add PostgreSqlInitialMigration --project CodeFirst.DataAccess --context PostgreSqlContext`
- `dotnet-ef database update --project CodeFirst.DataAccess --context SqlServerContext`
- `dotnet-ef database update --project CodeFirst.DataAccess --context PostgreSqlContext`
- `dotnet ef migrations remove`

## Roadmap

- Create a separate project `Models`, where data models are stored
- Create a separate project `DataAccess`, that is responsible for interraction with database
- Load packages to `DataAccess` project. See section *Which packages to use?*
- Get proper connection string for SQL Server database. For localhost it is: 

	`"Data Source=DESKTOP-P87PH2B;Initial Catalog=CodeFirstEntityFramework;Integrated Security=true;"`

- Get proper connection string for Postgre SQL database. For localhost it is: 

	`"Server=localhost;User Id=postgres;Password=postgres;Database=CodeFirstEntityFramework;"`

- Build a relations between models, for instance, `one-to-one`, `one-to-many`, `many-to-many` according to the database diagram. 
	Refer to
  - https://www.learnentityframeworkcore.com/configuration/one-to-one-relationship-configuration
  - https://www.learnentityframeworkcore.com/relationships/managing-one-to-many-relationships
  - https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration

- Create proper configurations of models, using Fluent API. Configuration should implement `IEntityTypeConfiguration<T>` from Entity Framework namespace
- Create `BaseContext` inherrit it from `DbContext` in Entity Framework namespace, add related sets `BDSet<T>`, where `T` -- models.
- Create `SqlServerContext`, inherrit it from `BaseContext` and override methods `OnConfiguring` and `OnModelCreating`.
- Create `PostgreSqlContext`, inherrit it from `BaseContext` and override methods `OnConfiguring` and `OnModelCreating`.
- Create migration for `SqlServerContext`, use CLI command: 

	`dotnet-ef migrations add SqlServerInitialMigration --project CodeFirst.DataAccess --context SqlServerContext`
	
- Create migration for `PostgreSqlContext`, use CLI command: 

	`dotnet-ef migrations add PostgreSqlInitialMigration --project CodeFirst.DataAccess --context PostgreSqlContext`
	
- Update SQL Server database, use CLI command: 

	`dotnet-ef database update --project CodeFirst.DataAccess --context SqlServerContext`

- Update Postgre SQL database, use CLI command: 

	`dotnet-ef database update --project CodeFirst.DataAccess --context PostgreSqlContext`

- Write unit tests for `SqlServerContext`
- Write unit tests for `PostgreSqlContext`
- Create Generic repository interface
- Implement Generic repository interface
- Test Generic Repositories

## Notes

To get MS SQL connection string proceed:
- Go to visual studio - Server explorer - Data connections
- Right click on data connections - Add new connection
- Type there your server name
- Click add connection
- Then in properties of such connection you'd get connection string