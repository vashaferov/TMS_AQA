
using Abstraction.Task1;
using Abstraction.Task2;
using Microsoft.Win32;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Abstraction.Task3;

internal class Program
{
    private static void Main(string[] args)
    {
        //Warrior warrior = new Warrior(1);
        //Wizard wizard = new Wizard(1);

        //warrior.name = "Tor";
        //warrior.PrintInfo();       

        //warrior.Move();
        //warrior.Attack();
        //warrior.UseAbility();

        //wizard.Attack();
        //wizard.Move();
        //wizard.UseAbility();

        //Console.WriteLine();

        //Character[] characters = new Character[3];

        //characters[0] = new Wizard(1);
        //characters[1] = new Warrior(1);
        //characters[2] = new Warrior(3);

        //foreach(var character in characters)
        //{
        //    character.Attack();
        //    character.PrintInfo();
        //}

        bool flag = true;
        string task;

        while (flag)
        {
            Console.Write("-------\nВведите номер задания (от 1 до 3): ");
            task = Console.ReadLine();
            Console.Clear();

            switch (task)
            {
                case "1":
                    {
                        Console.WriteLine("ЗАДАНИЕ 1\n");

                        double pAll = 0;
                        double sAll = 0;
                        Figure[] figures = new Figure[5];
                        figures[0] = new Triangle(3, 4, 5);
                        figures[1] = new Rectangle(5, 8);
                        figures[2] = new Circle(2.5f);
                        figures[3] = new Triangle(3, 5, 7);
                        figures[4] = new Circle(4);

                        foreach (Figure f in figures)
                        {
                            f.Print();
                            Console.WriteLine($"Периметр: {f.getPerimeter()}, Площадь: {f.getArea()}\n");
                            pAll += f.getPerimeter();
                            sAll += f.getArea();
                        }

                        Console.WriteLine("Сумма площади всех фигур: {0:f4}\nСумма периметров всех фигур: {1:f4}", pAll, sAll);

                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("ЗАДАНИЕ 2\n");

                        Product[] products = new Product[7];
                        products[0] = new Product("Мука \"Макфа\"", 20, new DateTime(2023, 12, 1), new DateTime(2025, 12, 1));
                        products[1] = new Product("Хлеб \"Смак\"", 50, new DateTime(2023, 12, 1), new DateTime(2023, 12, 3));
                        products[2] = new Product("Макароны \"Щебекино\"", 80, new DateTime(2023, 11, 1), new DateTime(2024, 11, 1));
                        products[3] = new Product("Яблоко \"Голд\"", 120, new DateTime(2023, 12, 9), new DateTime(2023, 12, 16));
                        products[4] = new Product("Мыло \"Детское\"", 35, new DateTime(2023, 1, 1), new DateTime(2028, 1, 1));
                        products[5] = new Product("Мука \"Макфа\"", 21, new DateTime(2023, 12, 1), new DateTime(2025, 12, 1));
                        products[6] = new Product("Мыло \"Детское\"", 40, new DateTime(2023, 1, 1), new DateTime(2028, 1, 1));

                        Console.WriteLine("Весь список продуктов:");
                        foreach (Product p in products)
                        {
                            p.PrintInfo();

                            if (!p.IsProductFresh())
                                Console.WriteLine("Срок годности продукта не соблюден!");
                            Console.WriteLine();
                        }

                        // добавление продуктов в партии (партия = общее название, срок производства и срок годности), цена = сумма цен продуктов партии
                        Batch[] batch = new Batch[products.Length];
                        int batchCount = 0;

                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i].batchNum == 0)
                            {
                                products[i].batchNum = batchCount + 1;
                                batch[batchCount] = new Batch(products[i].name, products[i].price, products[i].productionDate, products[i].expirationDate, 1);

                                for (int j = i + 1; j < products.Length; j++)
                                {
                                    if (products[i].name == products[j].name && products[i].productionDate == products[j].productionDate && products[i].expirationDate == products[j].expirationDate)
                                        if (products[j].batchNum == 0)
                                        {
                                            batch[batchCount].quantity++;
                                            batch[batchCount].price += products[j].price;
                                            products[j].batchNum = products[i].batchNum;
                                        }
                                }
                                batchCount++;
                            }
                        }
                        // убираем пустые элементы из партии
                        batch = batch.Where(x => x != null).ToArray();

                        Console.WriteLine("------\nПартии:");
                        foreach (Batch b in batch)
                        {
                            b.PrintInfo();
                            if (!b.IsProductFresh())
                                Console.WriteLine("Срок годности партии не соблюден!");
                            Console.WriteLine();
                        }

                        string[] fruitsAndVegetables = { "Яблоко", "Груша", "Банан", "Картофель", "Морковь", "Лук" };
                        string[] milkProduct = { "Молоко", "Сметана", "Масло", "Йогурт", "Сыр", "Творог" };
                        string[] breadProduct = { "Хлеб", "Батон", "Лепешка", "Булка", "Лаваш", "Мука" };
                        List<Product> fruitsAndVegetablesList = new List<Product>();
                        List<Product> milkProductList = new List<Product>();
                        List<Product> breadProductList = new List<Product>();
                        List<Product> otherList = new List<Product>();

                        foreach (Product p in products)
                        {
                            bool tempFlag = false;

                            for (int i = 0; i < fruitsAndVegetables.Length; i++) // Знаю что костыль, но других идей нет
                            {
                                if (p.name.Contains(fruitsAndVegetables[i]))
                                {
                                    fruitsAndVegetablesList.Add(p);
                                    tempFlag = true;
                                    break;
                                }
                                else if (p.name.Contains(milkProduct[i]))
                                {
                                    milkProductList.Add(p);
                                    tempFlag = true;
                                    break;
                                }
                                else if (p.name.Contains(breadProduct[i]))
                                {
                                    breadProductList.Add(p);
                                    tempFlag = true;
                                    break;
                                }
                            }
                            if (!tempFlag)
                                otherList.Add(p);
                        }

                        Package[] packages = new Package[4];
                        packages[0] = new Package("Фрукты и овощи", fruitsAndVegetablesList);
                        packages[1] = new Package("Молочные продукты", milkProductList);
                        packages[2] = new Package("Хлебобулочные изделия", breadProductList);
                        packages[3] = new Package("Остальные продукты", otherList);

                        Console.WriteLine("------\nКомплект:");
                        foreach (Package package in packages)
                        {
                            package.IsProductFreshPackage();
                            package.PrintInfoPackage();
                        }

                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("ЗАДАНИЕ 3\n");

                        bool exitFlag = false;
                        Register register = new Register();
                        
                        while (!exitFlag)
                        {
                            register.FullnessRegister();
                            Console.Write("1) Добавить документ\n2) Напечатать документ(ы)\n'q' - для выхода\nТип операции: ");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                {
                                    register.Add();
                                    break;
                                }
                                case "2":
                                {
                                    Console.WriteLine();
                                    register.PrintInfo();
                                    break;
                                }
                                case "q":
                                {
                                    exitFlag = true;
                                    break;
                                }
                                default:
                                {
                                    Console.WriteLine("Не найден номер операции.");
                                    break;
                                }
                            }
                            
                        }

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Не найден номер задачи. Повторите ввод номера (от 1 до 3)");

                        break;
                    }
            }
        }
    }
}