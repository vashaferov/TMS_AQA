using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Task2
{
    internal class CreditCard
    {
        public string accountNumber;
        public float theCurrentAmountOnAccount;


        public CreditCard(string accountNumber)
        {
            this.accountNumber = accountNumber;
            theCurrentAmountOnAccount = 0;
        }

        public CreditCard(string accountNumber, float theCurrentAmountOnAccount) : this(accountNumber)
        {
            this.theCurrentAmountOnAccount = theCurrentAmountOnAccount;
        }


        public void GetInfoAccount()
        {
            Console.WriteLine($"Номер счета: {this.accountNumber}\nБаланс: {this.theCurrentAmountOnAccount}");
        }

        public void AddAmountToAccount(float amount)
        {
            this.theCurrentAmountOnAccount += amount;
            Console.WriteLine($"\nНа счет внесено: {amount}. Доступный остаток {this.theCurrentAmountOnAccount}\n");
        }

        public void TakeAmountToAccount(float amount)
        {
            if (this.theCurrentAmountOnAccount <= amount)
                Console.WriteLine($"\nНа счету недостаточно средств. Для снятия доступно: {this.theCurrentAmountOnAccount}\n");
            else
            {
                this.theCurrentAmountOnAccount -= amount;
                Console.WriteLine($"\nСо счета снято: {amount}. Доступный остаток {this.theCurrentAmountOnAccount}\n");
            }
        }
    }
}
