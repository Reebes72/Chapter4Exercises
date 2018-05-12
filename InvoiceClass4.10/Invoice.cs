using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceClass4._10
{
    class Invoice
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }

        private int quantity = 0;
        private decimal pricePerItem = 0.0m;

        public Invoice (string number, string decription, int qty, decimal price)
        {
            PartNumber = number;
            PartDescription = decription;
            Quantity = qty;
            PricePerItem = price;

        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            private set
            {
                if(value > 0)
                {
                    quantity = value;
                }
            }
        }

        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            private set
            {
                if (value > 0.0m)
                {
                    pricePerItem = value;
                }
            }
        }

        public decimal GetInvoiceAmount()
        {
            return this.Quantity * this.PricePerItem;
        }
    }
}
