using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Reoria.Database.DbContexts;

public class ReoriaDbContext : DbContext
{
    private readonly IConfiguration configuration;

    public ReoriaDbContext()
    {
        IConfigurationBuilder builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
            .AddEnvironmentVariables();

        this.configuration = builder.Build();

        string connectionString = this.configuration["Database:ConnectionString"] ?? "Data Source=Data/Reoria.db";

        if (connectionString.Contains("Filename=") || connectionString.Contains("Data Source="))
        {
            string? directory = Path.GetDirectoryName(connectionString.Replace("Filename=", "").Replace("Data Source=", ""));

            if (!string.IsNullOrWhiteSpace(directory) && !Directory.Exists(directory))
            {
                _ = Directory.CreateDirectory(path: directory);
            }
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = this.configuration["Database:ConnectionString"] ?? "Data Source=Data/Reoria.db";
            string dbtype = this.configuration["Database:Type"] ?? "Sqlite";

            _ = dbtype switch
            {
                "Sqlite" => optionsBuilder.UseSqlite(connectionString),
                "SqlServer" => optionsBuilder.UseSqlServer(connectionString),
                _ => throw new NotSupportedException($"Database type '{dbtype}' is not supported."),
            };

            _ = optionsBuilder.UseSqlite(connectionString);
        }
    }
}
