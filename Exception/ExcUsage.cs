using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class ExcUsage
    {
        private CheckExc checkExc = new CheckExc();

        public void Template()
        {
            try
            {
                checkExc.ReadFile("File.txt");

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException");
                throw;
            }
            catch (Exception e) 
            {
                Console.WriteLine("Exception");
                throw;
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

        public void ManyCatch()
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Возникло исключение {ex.Message}");
            }
            catch (Exception genEx)
            {
                Console.WriteLine($"Возникло общее исключение {genEx.Message}");
            }
        }

        public void FilterCatch(int x, int y)
        {
            try
            {
                int result1 = x / y;
                int result2 = y / x;
            }
            catch (DivideByZeroException) when (y == 0)
            {
                Console.WriteLine("y не может быть 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
