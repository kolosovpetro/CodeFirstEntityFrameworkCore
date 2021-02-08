namespace CodeFirst.ConnectionStrings
{
    public static class Connection
    {
        public const string SqlServerConnectionString =
            "Data Source=DESKTOP-RN0NICT;Initial Catalog=CodeFirstEntityFramework;Integrated Security=true;";

        public const string PostgreSqlConnectionString =
            "Server=localhost;User Id=postgres;Password=postgres;Database=CodeFirstEntityFramework;";
    }
}