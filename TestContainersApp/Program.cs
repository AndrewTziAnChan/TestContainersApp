using DotNet.Testcontainers.Configurations;
using Testcontainers.PostgreSql;

public static class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine(string.Join("|", args));
        Console.WriteLine(TestcontainersSettings.DockerHostOverride);
        PostgreSqlContainer container = new PostgreSqlBuilder()
            .Build();
        await container.StartAsync();

        Console.WriteLine(container.GetConnectionString());
    }
}