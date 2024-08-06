namespace TestContainersAppTest;

public class Tests
{
    [Test]
    public async Task RunProgram()
    {
        Console.WriteLine(Environment.ExpandEnvironmentVariables("%HOME%"));
        await Program.Main(["argument1", "argument2"]);
    }
}