namespace Classes.Task3;

public class ATM
{
    public int banknote20;
    public int banknote50;
    public int banknote100;

    public ATM(int banknote20, int banknote50, int banknote100)
    {
        this.banknote20 = banknote20;
        this.banknote50 = banknote50;
        this.banknote100 = banknote100;
    }

    public void ReplenishmentATM(int banknote, int amount)
    {
        switch (banknote)
        {
            case 20:
            {
                this.banknote20 += amount;
                break;
            }
            case 50:
            {
                this.banknote50 += amount;
                break;
            }
            case 100:
            {
                this.banknote100 += amount;
                break;
            }
            default:
            {
                Console.WriteLine("\nТаких купюр нет в банкомате!");
                break;
            }
        }
    }

    public bool TakeMoney(int amount)
    {
        int count20 = 0;
        int count50 = 0;
        int count100;
        
        int allMoneyATM = banknote20 * 20 + banknote50 * 50 + banknote100 * 100;

        if (allMoneyATM >= amount && amount % 10 == 0)
        {
            for (count100 = 0; amount > 100 && banknote100 != 0; count100++)
            {
                amount -= 100;
                banknote100--;
            }

            while (amount != 0)
            {
                if (amount % 50 == 0 && banknote50 != 0)
                {
                    amount -= 50;
                    banknote50--;
                    count50++;
                }
                else if (banknote20 != 0)
                {
                    amount -= 20;
                    banknote20--;
                    count20++;
                }
                else
                {
                    Console.WriteLine("В банкомате не хватило купюр!");
                    banknote20 += count20;
                    banknote50 += count50;
                    banknote100 += count100;
                    return false;
                }
            }

            if (amount == 0)
            {
                Console.WriteLine($"Выдано купюрами:\n100 - {count100} шт.\n50 - {count50} шт.\n20 - {count20} шт.");
                return true;
            }

        }
        else
        {
            Console.WriteLine("Запрашивамая сумма больше, чем имеется в банкомате, или данная сумма не может быть выдана данными купюрами.");
            return false;
        }
        
        return false;
    }

    public void Print()
    {
        Console.WriteLine($"Количество банкнот номиналом:\n20: {banknote20}\n50: {banknote50}\n100: {banknote100}");
    }
}