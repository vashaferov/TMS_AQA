using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task2
{
    internal class Batch : Product
    {
        public int quantity;
        public Batch(string name, double price, DateTime productionDate, DateTime expirationDate, int quantity) : base(name, price, productionDate, expirationDate)
        {
            this.quantity = quantity;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Количество штук в партии: {quantity}");
        }
    }
}
