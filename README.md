# Code First with Entity Framework

Simple example of Entity Framework Core Code-First approach.

## Data base schema

![DbSchema](DbSchema.JPG?raw=true)

## Which packages to use?

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.SqlServer
- Npgsql.EntityFrameworkCore.PostgreSQL

## Roadmap

- Create a separate project Models, where data models are stored
- Create a separate project DataAccess, that is responsible for interraction with database
- Load packages to DataAccess project. See section Which packages to use?
- Inside project DataAccess create SqlServerDbContext, inherrit it from DbContext in Entity Framework
- Inside project DataAccess create PostgeSqlDbContext, inherrit it from DbContext in Entity Framework
- Get proper connection string for SQL Server database. For localhost it is: "Data Source=DESKTOP-P87PH2B;Initial Catalog=CodeFirstEntityFramework;Integrated Security=true;"
- Get proper connection string for Postgre SQL database. For localhost it is: "Server=localhost;User Id=postgres;Password=postgres;Database=CodeFirstEntityFramework;"
- Build a relations between models, for instance, one-to-one, one-to-many, many-to-many. Refer to
  - https://www.learnentityframeworkcore.com/configuration/one-to-one-relationship-configuration
  - https://www.learnentityframeworkcore.com/relationships/managing-one-to-many-relationships
  - https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration
- Create proper configurations of models, using Fluent API. Configuration should implement IEntityTypeConfiguration<T>.
- Update SqlServerContext with BDSet<T> and override methods OnConfiguring and OnModelCreating.
- Update PostgreSqlContext with BDSet<T> and override methods OnConfiguring and OnModelCreating.
- Create migration for SqlServerContext, use CLI command: dotnet-ef migrations add SqlServerInitialMigration --project CodeFirst.DataAccess --context SqlServerContext
- Create migration for PostgreSqlContext, use CLI command: dotnet-ef migrations add PostgreSqlInitialMigration --project CodeFirst.DataAccess --context PostgreSqlContext