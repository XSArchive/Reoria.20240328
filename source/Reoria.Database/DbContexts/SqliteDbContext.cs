using Microsoft.EntityFrameworkCore;

namespace Reoria.Database.DbContexts;

public class SqliteDbContext : ReoriaDbContext
{
    public readonly string? DatabaseName;

    public SqliteDbContext() => this.DatabaseName = "GameDatabase.db";
    public SqliteDbContext(string? databaseName) => this.DatabaseName = databaseName;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        string path = Path.Join(Environment.GetFolderPath(folder), "Reoria");

        _ = optionsBuilder.UseSqlite($"Data Source={Path.Join(path, $"{this.DatabaseName}.db")}");

        base.OnConfiguring(optionsBuilder);
    }
}
