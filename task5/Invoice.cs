using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Invoice
    {
        private int Account { get; set; }
        private string Customer { get; set; }
        private string Provider { get; set; }
        public string Article { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }



        public decimal CostCalculation(bool needEDV)
        {
            if (needEDV)
            {
                return Price * Quantity + CalculateEdv(Price, Quantity);
            }
            else
            {
                return Price * Quantity;
            }
        }

        public decimal CalculateEdv( decimal price, int quantity )
        {
            decimal edv = (price * quantity) * 18 / 100;
            return edv;
        }
    }
}
