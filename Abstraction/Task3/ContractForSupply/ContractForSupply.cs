using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task3.ContractForSupply
{
    internal class ContractForSupply : Document
    {
        private string typeProducts;
        private int amountProducts;

        public ContractForSupply() { }

        public ContractForSupply(int numDoc, DateTime date, string typeProducts, int amountProducts) : base(numDoc, date)
        {
            this.typeProducts = typeProducts;
            this.amountProducts = amountProducts;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"""
                               КОНТРАКТ НА ПОСТАВКУ ТОВАРОВ
                               Номер документа: {numDoc}
                               Тип товара: {typeProducts}
                               Количество товаров: {amountProducts}
                               Дата: {date}
                               """);
        }
    }
}
