
namespace Abstraction.Task2
{
    internal class Product
    {
        public string name;
        public double price;
        public DateTime productionDate;
        public DateTime expirationDate;
        public int batchNum;

        public Product(string name, double price, DateTime productionDate, DateTime expirationDate)
        {
            this.name = name;
            this.price = price;
            this.productionDate = productionDate;
            this.expirationDate = expirationDate;
            batchNum = 0;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Название: {name}, цена: {price}, дата производства: {productionDate}, срок годности: {expirationDate}");
        }
        public virtual bool IsProductFresh()
        {
            if (expirationDate > DateTime.Today)
                return true;
            else return false;
        }
    }
}
