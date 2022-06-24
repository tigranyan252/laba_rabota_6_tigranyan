using System;
using System.Collections.Generic;

namespace laba_rabota_6_tigranyan
{
    class Product
    {
        private string name;
        public int price;

        public Product(string name, int price)
        {
            this.name = name;
            int price1 = this.price;
            this.price = price1;
        }

        public override string ToString()
        {
            return name + " " + price + " рублей";
        }
    }
    class Program
    {
        private const int Price = 140;
        private const int Price1 = 40;

        static void Main()
        {
            Stack<Product> products = new Stack<Product>();

            products.Push(new Product("Хлеб ", Price1));
            products.Push(new Product("Масло ", Price));

            double s = 0;
            foreach (var a in products)
            {
                s += a.price;
                Console.WriteLine(a);
            }

            Console.WriteLine(s / products.Count);
        }
    }
}