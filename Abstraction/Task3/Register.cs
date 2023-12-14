using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task3
{
    internal class Register : IWorkable
    {
        Document[] docArray = new Document[10];

        public void Add()
        {
            Console.Write(
                "1) Контракт на поставку товаров;\n2) Контракт с сотрудником\n3) Финансовая накладная\nТип документа для добавления: ");
            string docNum = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < docArray.Length; i++)
            {
                if (docArray[i] == null)
                {
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

                            docArray[i] = new ContractForSupply.ContractForSupply(num, dateTime, typeProducts, amountProducts);
                            
                            break;
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

                            docArray[i] = new ContractStaff.ContractStaff(num, dateTime, dateEnd, name);
                            
                            break;
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

                            docArray[i] = new FinancialInvoice.FinancialInvoice(num, dateTime, totalAmount, departmentCode);
                            
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Неизвестный документ");

                            break;
                        }
                    }
                    
                    break;
                }
            }
        }

        public void PrintInfo()
        {
            foreach (var doc in docArray)
                if (doc != null)
                {
                    doc.PrintInfo();
                    Console.ReadLine();
                }
        }

        public void FullnessRegister()
        {
            int count = 0;
            
            foreach (var doc in docArray)
                if (doc != null)
                    count++;

            Console.WriteLine($"В регистре {count} документов.\n------------");
        }
    }
}