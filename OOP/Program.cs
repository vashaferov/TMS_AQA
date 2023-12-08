using OOP.Task1;
using OOP.Task2;
using OOP.Task2.Doctors;
using OOP.Task3;
using OOP.Task3.Transports;
using OOP.Task4;
using OOP.Task4.AutoType;
using System.Numerics;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//-------- Наследование 
            Client client1 = new Client(1);
            client1.Id = 1;
            client1.PhoneNumber = "79126784609";
            client1.Email = "test@test.com";

            Corporate corporate1 = new Corporate(1);
            corporate1.Id = 1;
            corporate1.INN = 4523434;
            corporate1.UNP = 3234324;

            Individuals individual1 = new Individuals(1);
            individual1.Firstname = "Aaa";
            individual1.Lastname = "Bbb";
            individual1.Id = 10;         
            individual1.PhoneNumber = "79373892819";
            individual1.Email = "test1@test.com";

            //-------- Свойства
            Person person = new Person("yyy - 715");
            person.Name = "Test";
            person.Age = "25";*/

            bool flag = true;
            string task;

            while (flag)
            {
                Console.Write("-------\nВведите номер задания (от 1 до 4): ");
                task = Console.ReadLine();
                Console.Clear();

                switch (task)
                {
                    case "1":
                        {
                            Console.WriteLine("ЗАДАНИЕ 1\n");

                            FigureType[] figureType = new FigureType[6];
                            figureType[0] = new Triangle(5, 5, 8).CheckTriangle();
                            figureType[1] = new Triangle(6, 6, 6).CheckTriangle();
                            figureType[2] = new Triangle(3, 4, 5).CheckTriangle();
                            figureType[3] = new Triangle(4, 5, 6).CheckTriangle();
                            figureType[4] = new SquareAndRectangle(8, 5);
                            figureType[5] = new SquareAndRectangle(7, 7);

                            foreach (var figure in figureType)
                            {
                                figure.Area();
                                Console.WriteLine();
                            }

                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("ЗАДАНИЕ 2\n");

                            string[] nameForPatient = { "Иван", "Петр", "Семен", "Лена", "Катя", "Ирина" };
                            Random rand = new Random();

                            TreatmentPlan treatmentPlan = new TreatmentPlan(rand.Next(1, 5));
                            Patient patient = new Patient(nameForPatient[rand.Next(nameForPatient.Length)], rand.Next(18, 99), treatmentPlan.treatmentPlanCode);

                            Doctor[] doctor = new Doctor[3];
                            doctor[0] = new Dentist();
                            doctor[1] = new Surgeon();
                            doctor[2] = new Therapist();

                            Console.WriteLine($"Карточка пациент:\nИмя: {patient.name}, Возраст: {patient.age}, Код плана лечения: {patient.treatmentPlan}");
                                                       
                            if (patient.treatmentPlan == 1)
                            {
                                doctor[1].Heal();
                            }
                            else if (patient.treatmentPlan == 2)
                            {
                                doctor[0].Heal();
                            }
                            else
                            {
                                doctor[2].Heal();
                            }

                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("ЗАДАНИЕ 3\n");

                            Random random = new Random();
                            string departureTimeFind;
                            string destinationFind;
                            string[] destinationArray = { "Пункт A", "Пункт B", "Пункт C", "Пункт D", "Пункт E", "Пункт F", "Пункт G"};
                            TransportService transportService = new TransportService();
                            Transport[] transport = new Transport[5];

                            transport[0] = new Bus();
                            transport[1] = new Electric();
                            transport[2] = new Rail();
                            transport[3] = new Tramcar();
                            transport[4] = new Trolleybus();
                            
                            foreach(Transport t in transport)
                            {
                                t.Number = random.Next(1, 10);
                                t.NumberSeats = random.Next(10, 50);
                                t.Destination = destinationArray[random.Next(destinationArray.Length)];
                                var ts = new TimeSpan(random.Next(10, 24), random.Next(10, 60), 0);
                                t.DepartureTime = $"{ts.Hours}:{ts.Minutes}";
                            }
                            
                            Transport temp;
                            for(int i = 0; i < transport.Length; i++)
                                for(int j = i + 1; j < transport.Length; j++)
                                    if (transport[i].numberSeats > transport[j].numberSeats)
                                    {
                                        temp = transport[i];
                                        transport[i] = transport[j];
                                        transport[j] = temp;
                                    }

                            Console.WriteLine("Информационное табло:");
                            foreach (Transport t in transport)
                                transportService.PrintTransportType(t);

                            Console.Write("-------\nКритерии поиска:\n1. Время отправления;\n2. Пункт назначения;\n3. Время отправления и пункт назначения\nМетод поиска: ");
                            string find = Console.ReadLine();
                            switch (find)
                            {
                                case "1":
                                    {
                                        Console.Write("Введите время отправления (в формате \"hh:mm\"): ");
                                        departureTimeFind = Console.ReadLine();

                                        foreach (Transport t in transport)
                                            if (t.departureTime == departureTimeFind)
                                                transportService.PrintTransportType(t);

                                        break;
                                    }
                                case "2":
                                    {
                                        Console.Write("Введите пункт назначения: ");
                                        destinationFind = Console.ReadLine();

                                        foreach (Transport t in transport)
                                            if (t.destination == destinationFind)
                                                transportService.PrintTransportType(t);

                                        break;
                                    }
                                case "3":
                                    {
                                        Console.Write("Введите время отправления (в формате \"hh:mm\"): ");
                                        departureTimeFind = Console.ReadLine();
                                        Console.Write("Введите пункт назначения: ");
                                        destinationFind = Console.ReadLine();

                                        foreach (Transport t in transport)
                                            if (t.destination == destinationFind && t.departureTime == departureTimeFind)
                                                transportService.PrintTransportType(t);

                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Ошибка!");

                                        break;
                                    }
                            }

                            Console.Write("-------\nВремя отправления (в формате \"hh:mm\"): ");
                            departureTimeFind = Console.ReadLine();

                            foreach (Transport t in transport)
                                if (TimeSpan.Parse(t.departureTime) > TimeSpan.Parse(departureTimeFind))
                                    transportService.PrintTransportType(t);

                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("ЗАДАНИЕ 4\n");

                            //Auto[] auto = new Auto[3];
                            //auto[0] = new PassengerCar("Nisan", "A210EM96", 120, 150);
                            //auto[1] = new Motorbike("Java", "E973KO196", 80, 70, false);
                            //auto[2] = new Truck("Man", "T234PC66", 60, 1500, false);
                            Console.Write("Кол-во автотехники: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Auto[] auto = new Auto[n];

                            for(int i = 0; i < n; i++)
                            {
                                Console.Write("------\n1)Легковая машина\n2)Мотоцикл\n3)Грузовик\nТип транспортного средства: ");
                                int type = Convert.ToInt32(Console.ReadLine());
                                switch (type)
                                {
                                    case 1:
                                        {
                                            Console.Write("\nМарка ТС: ");
                                            string mark = Console.ReadLine();
                                            Console.Write("Номер ТС: ");
                                            string number = Console.ReadLine();
                                            Console.Write("Скорость ТС: ");
                                            int speed = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Грузподъемность ТС: ");
                                            int payload = Convert.ToInt32(Console.ReadLine());

                                            auto[i] = new PassengerCar(mark, number, speed, payload);

                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("\nМарка ТС: ");
                                            string mark = Console.ReadLine();
                                            Console.Write("Номер ТС: ");
                                            string number = Console.ReadLine();
                                            Console.Write("Скорость ТС: ");
                                            int speed = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Грузподъемность ТС: ");
                                            int payload = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Наличие коляски у мотоцикла (\"true\" - да/\"false\" - нет): ");
                                            bool availabilityStroller = Convert.ToBoolean(Console.ReadLine());

                                            auto[i] = new Motorbike(mark, number, speed, payload, availabilityStroller);

                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("\nМарка ТС: ");
                                            string mark = Console.ReadLine();
                                            Console.Write("Номер ТС: ");
                                            string number = Console.ReadLine();
                                            Console.Write("Скорость ТС: ");
                                            int speed = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Грузподъемность ТС: ");
                                            int payload = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Наличие прицепа у грузовика (\"true\" - да/\"false\" - нет): ");
                                            bool availabilityTrailer = Convert.ToBoolean(Console.ReadLine());

                                            auto[i] = new Truck(mark, number, speed, payload, availabilityTrailer);

                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Error!");

                                            break;
                                        }
                                }

                            }

                            Console.WriteLine($"------\nВ автопарке {auto.Length} ТС:");
                            foreach(Auto a in auto)
                                a.PrintInfo(a);

                            Console.Write("\n\">\" - вывести список ТС с грузподъемностью больше заданного числа\n\"<\" - вывести список ТС с грузподъемностью меньше заданного числа\n\"=\" - вывести список ТС с грузподъемностью равной заданному числу\nТип операции: ");
                            string operationType = Console.ReadLine();
                            Console.Write("Введите проверяемый вес: ");
                            int mas = Convert.ToInt32(Console.ReadLine());

                            switch (operationType)
                            {
                                case ">":
                                    {
                                        foreach(Auto a in auto)
                                            if(a.payload > mas)
                                                a.PrintInfo(a);
                                        break;
                                    }
                                case "<":
                                    {
                                        foreach (Auto a in auto)
                                            if (a.payload < mas)
                                                a.PrintInfo(a);
                                        break;
                                    }
                                case "=":
                                    {
                                        foreach (Auto a in auto)
                                            if (a.payload == mas)
                                                a.PrintInfo(a);
                                        break;
                                    }
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Не найден номер задачи. Повторите ввод номера (от 1 до 4)");

                            break;
                        }
                }
            }

        }
    }
}