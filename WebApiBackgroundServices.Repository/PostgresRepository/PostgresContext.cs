using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace WebApiBackgroundServices.Repository.PostgresRepository;

public class PostgresContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
}

public class ConnectionManager
{
    public static PostgresContext CreateContext(string connectionString)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PostgresContext>();
        optionsBuilder.UseNpgsql(connectionString);

        var dbContext = new PostgresContext();
        dbContext.Database.SetDbConnection(new NpgsqlConnection(connectionString)); // Configura a conexão diretamente

        return dbContext;
    }
}