using Exceptions.Task2.ExceptionsOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Task2
{
    internal class Order
    {
        private int numberOrder;
        private string products;
        private string deliveryAddress;

        public Order() { }

        public int NumberOrder 
        { 
            get => numberOrder;
            set
            {
                if (value < 0)
                    throw new InvalidOrderNumberException("Номер заказа отрицательный");
                else
                    numberOrder = value;
            }
        }
        public string Products
        {
            get => products;
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                    throw new EmptyOrderException("Пустой список товаров");
                else
                    products = value;
            }
        }
        public string DeliveryAddress 
        { 
            get => deliveryAddress;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new DeliveryInformationMissingException("Недостаточные данные для доставки");
                else
                    deliveryAddress = value;
            }
        }
    }
}
