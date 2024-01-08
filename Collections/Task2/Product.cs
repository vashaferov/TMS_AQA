using Collections.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Task2
{
    internal class Product
    {
        private string productName;
        private double productPrice;
        private int productCount;

        public Product() { }

        public string ProductName { get => productName;  set => productName = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
        public int ProductCount { get => productCount; set => productCount = value; }

        public static Product Add(string productName, double productPrice, int productCount)
        {
            Product product = new Product();
            if (String.IsNullOrWhiteSpace(productName))
                throw new EmptyInfoException("Заполнены не все поля!");
            else
            {
                product.ProductName = productName;
                product.ProductPrice = productPrice;
                product.ProductCount = productCount;

                return product;
            }            
        }

        public static Product Change(Product product, double productPrice, int productCount)
        {
            product.ProductPrice = productPrice;
            product.ProductCount = productCount;

            return product;
        }
    }
}
