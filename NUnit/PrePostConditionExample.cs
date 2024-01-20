namespace NUnitProject;

public class PrePostConditionExample
{
    protected int i = 0;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Console.WriteLine($"{this}: OneTimeSetUp...{++i}");
    }
    
    [SetUp]
    public void Setup()
    {
        Console.WriteLine($"{this}: SetUp...{++i}");
    }

    [Test]
    public void Test()
    {
        Console.WriteLine($"{this}: Test...{++i}");
    }
    
    [TearDown]
    public void TearDown()
    {
        Console.WriteLine($"{this}: TearDown...{++i}");
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Console.WriteLine($"{this}: OneTimeTearDown...{++i}");
    }
}