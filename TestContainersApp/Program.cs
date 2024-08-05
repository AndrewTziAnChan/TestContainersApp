
using Testcontainers.PostgreSql;

public static class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine(string.Join('|', args));

        PostgreSqlContainer container = new PostgreSqlBuilder().Build();
        await container.StartAsync();
        
        Console.WriteLine(container.GetConnectionString());
    }
}