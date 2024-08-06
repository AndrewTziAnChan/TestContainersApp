using DotNet.Testcontainers.Builders;
using Testcontainers.PostgreSql;

public static class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting");
        Console.WriteLine(string.Join('|', args));

        PostgreSqlContainer container = new PostgreSqlBuilder()
            .WithPortBinding(5432, true)
            .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(5432))
            .Build();
        await container.StartAsync();

        Console.WriteLine(container.GetConnectionString());
    }
}