using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task3
{
    internal class Register : Document, IWorkable
    {
        Register[] docArray = new Register[10];

        void Add(Register[] docArray)
        {
            Console.Write("1) Контракт на поставку товаров;\n2)Контракт с сотрудником\n3)Финансовая накладная\nТип документа для добавления: ");
            string docNum = Console.ReadLine();

            switch (docNum)
            {
                case "1":
                    {
                        Console.Write("Введите номер документа: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите дату документа: ");
                        DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Введите тип продукта: ");
                        string? typeProducts = Console.ReadLine();
                        Console.Write("Кол-во товаров: ");
                        int amountProducts = Convert.ToInt32(Console.ReadLine());

                        return new ContractForSupply.ContractForSupply(num, dateTime, typeProducts, amountProducts); 
                    }
                case "2":
                    {
                        Console.Write("Введите номер документа: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите дату документа: ");
                        DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Введите дату окончания контракта: ");
                        DateTime dateEnd = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Введите имя сотрудника: ");
                        string? name = Console.ReadLine();

                        return new ContractStaff.ContractStaff(num, dateTime, dateEnd, name);
                    }
                case "3":
                    {
                        Console.Write("Введите номер документа: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите дату документа: ");
                        DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Введите итоговую сумму за месяц: ");
                        double totalAmount = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Код департамента: ");
                        int departmentCode = Convert.ToInt32(Console.ReadLine());

                        return new FinancialInvoice.FinancialInvoice(num, dateTime, totalAmount, departmentCode);
                    }
                default:
                    {
                        Console.WriteLine("Неизвестный документ");

                        return null;
                    }
            }
        }


    }
}
