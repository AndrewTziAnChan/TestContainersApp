namespace TestContainersAppTest;

public class Tests
{
    [Test]
    public async Task RunProgram()
    {
        await Program.Main(["argument1", "argument2"]);
    }
}