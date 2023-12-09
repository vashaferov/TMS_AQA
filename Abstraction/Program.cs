
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

                    break;
                }
                case "2":
                {
                    Console.WriteLine("ЗАДАНИЕ 2\n");

                    break;
                }
                case "3":
                {
                    Console.WriteLine("ЗАДАНИЕ 3\n");

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