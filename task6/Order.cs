using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Order
    {
        private Product[] products;
        public Product[] Products { get => products; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Limit { get; set; } = 10;

        public Order()
        {
            products = new Product[0];
        }

        public void AddProduct(Product product)
        {
            if (Limit > products.Length)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length -1] = product;
            }
            else
                Console.WriteLine("Limiti kecdiniz");
        }

        public void RemoveProduct(Product product) 
        {
            int index = Array.IndexOf(products, product);
            for(int i = index; i < products.Length - 1; i++)
            {
                products[i] = products[i + 1];
            }
            Array.Resize(ref products, products.Length - 1);
        }
       
        public void GetDetails()
        {
            foreach(Product p in products)
            {
                p.GetDetails();
            }
        }

        public decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach(Product p in products)
            {
                total += p.Price;
            }

            return total;
        }

    }
}
