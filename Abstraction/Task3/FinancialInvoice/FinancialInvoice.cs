using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task3.FinancialInvoice
{
    internal class FinancialInvoice : Document
    {
        private double totalAmount;
        private int departmentCode;

        public FinancialInvoice() { }

        public FinancialInvoice(int numDoc, DateTime date, double totalAmount, int departmentCode) : base(numDoc, date)
        {
            this.totalAmount = totalAmount;
            this.departmentCode = departmentCode;
        }
        
        public override void PrintInfo()
        {
            Console.WriteLine($"""
                               ФИНАНСОВАЯ НАКЛАДНАЯ
                               Номер документа: {numDoc}
                               Код департамента: {departmentCode}
                               Количество товаров: {totalAmount}
                               Дата: {date}
                               """);
        }
    }
}
