using Testcontainers.PostgreSql;

public static class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting");
        Console.WriteLine(string.Join('|', args));

        PostgreSqlContainer container = new PostgreSqlBuilder()
            .WithStartupCallback((resourceReaper, ct) => Task.Delay(TimeSpan.FromSeconds(5), ct)).Build();
        await container.StartAsync();

        Console.WriteLine(container.GetConnectionString());
    }
}