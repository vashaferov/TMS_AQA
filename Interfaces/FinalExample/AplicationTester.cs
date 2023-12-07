using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FinalExample
{
    internal class AplicationTester : ITestable
    {
        private Test[] _tests = new Test[10];
        private int _index = 0;

        public void AddTest(Test test)
        {
            _tests[_index++] = test;
        }

        public void RunTests()
        {
            for (int i = 0; i < _index; i++)
            {
                _tests[i].Run();
            }
        }
    }
}
