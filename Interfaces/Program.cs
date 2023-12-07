using Interfaces.FinalExample;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AplicationTester aplicationTester = new AplicationTester();
            aplicationTester.AddTest(new IntegrationTest());
            aplicationTester.AddTest(new UnitTest());
            aplicationTester.AddTest(new UITest());

            aplicationTester.RunTests();
        }
    }
}
