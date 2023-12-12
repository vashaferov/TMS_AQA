using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task2
{
    internal class Package
    {
        public string name;
        public double price = 0;
        public List<Product> products;

        public Package(string name, List<Product> products)
        {
            this.name = name;
            this.products = products;

            foreach (Product p in products)
            {
                price += p.price;
            }
        }

        public void PrintInfoPackage()
        {
            Console.WriteLine($"Имя комплекта: {name}, перечень продуктов: ");
            foreach (Product product in products)
                Console.WriteLine($"Название: {product.name}, цена: {product.price}, дата производства: {product.productionDate}, срок годности: {product.expirationDate}");
            Console.WriteLine($"Общая стоимость комплекта: {price}\n");
        }
        public void IsProductFreshPackage()
        {
            foreach (Product product in products)
                if (!product.IsProductFresh())
                    Console.WriteLine("В комплекте есть продукты с не соблюденным сроком годности!");
        }
    }
}
