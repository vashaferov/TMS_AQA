using OOP.Task1;
using OOP.Task2;
using OOP.Task2.Doctors;
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



                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("ЗАДАНИЕ 4\n");

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