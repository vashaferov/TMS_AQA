namespace NUnitProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine($"{this}: Test...");
            Assert.Pass();
        }
    }
}