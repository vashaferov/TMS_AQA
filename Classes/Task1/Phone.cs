using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Task1
{
    public class Phone
    {
        public string number;
        public string model;
        public float weight;


        public Phone()
        {
            number = "79184782058";
            model = "LG";
            weight = 200.0f;
        }

        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
            weight = 195.0f;
        }

        public Phone(string number, string model, float weight) : this(number, model)
        {
            this.weight = weight;
        }


        public void receiveCall(string name)
        {
            Console.Write($"Звонит {name} ");
        }

        public string getNumber() 
        { 
            return number; 
        }

        public void sendMessage(string[] receivingNumbers)
        {
            Console.WriteLine($"С номера {number} было отправлено сообщение: \"Привет!\" на номера:");
            foreach(string numbers in receivingNumbers)
                Console.WriteLine(numbers + " - доставлено;");
        }

        public void Print()
        {
            Console.WriteLine($"Номер телефона: {number}, Модель: {model}, Масса телефона: {weight}");
        }
    }
}
