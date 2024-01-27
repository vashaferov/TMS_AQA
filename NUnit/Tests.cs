using System.Runtime.InteropServices.JavaScript;
using NUnitTest;

namespace NUnitProject
{
    [TestFixture]
    [Author("vashaferov")]
    public class Tests
    {
        int a ;
        int b ;
        double c;
        double d;
        
        [SetUp]
        public void Setup()
        {
            a = 6;
            b = 3;
            c = 25.5;
            d = 2.5;
        }
        
        [Order(1), Category("Positive"), Category("int")]
        [Description("Позитивная проверка деления, int")]
        [TestCase(4, 2, ExpectedResult = 2)]
        [TestCase(10, 2, ExpectedResult = 5)]
        public int DivTestInt(int x, int y)
        {
            return Calc.Div(x, y);
        }
        
        [Order(1), Category("Negative"), Category("int")]
        [Description("Негативная проверка деления, int")]
        [TestCase(2, 0)]
        public void DivTestIntN(int x, int y)
        {
            Assert.Throws<DivideByZeroException>(() => Calc.Div(x, y));
        }
        
        [Order(1), Category("Positive"), Category("double")]
        [Description("Позитивная проверка деления, double")]
        [TestCase(5.0, 2.5, ExpectedResult = 2)]
        [TestCase(10.5, 2.5, ExpectedResult = 4.2)]
        public double DivTestDouble(double x, double y)
        {
            Console.WriteLine($"{DateTime.Now}: {x} / {y}");
            return Calc.Div(x, y);
        }
        
        [Order(1), Category("Negative"), Category("double")]
        [Description("Негативная проверка деления, double")]
        [TestCase(2.5, 0)]
        public void DivTestDoubleN(double x, double y)
        {
            if (y == 0 && Double.IsInfinity(Calc.Div(x, y)))
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Order(2), Category("Positive"), Category("int")]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCases))]
        public void DivideTest(int n, int d, int q)
        {
            Assert.That(n / d, Is.EqualTo(q));
        }
        
        [Order(3), Category("Positive"), Category("int")]
        [Ignore("Проверка 'Ignore'")]
        [TestCase(4, 2, ExpectedResult = 1)]
        public int DivTestIgnore(int x, int y)
        {
            return Calc.Div(x, y);
        }
    }
}