using System;

namespace InvoiceClass4._10
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("123", "Muffler", 5, 264.32m);
            Invoice invoice2 = new Invoice("456", "Brakes", 4, 95.00m);

            Console.WriteLine(
                $"Part:         {invoice1.PartNumber} \n" +
                $"Description:  {invoice1.PartDescription} \n" +
                $"Quantity:     {invoice1.Quantity} \n" +
                $"Cost Per:     {invoice1.PricePerItem} \n" +
                $"Invoice Total:{invoice1.GetInvoiceAmount():C}\n");

            Console.WriteLine(
                $"Part:         {invoice2.PartNumber} \n" +
                $"Description:  {invoice2.PartDescription} \n" +
                $"Quantity:     {invoice2.Quantity} \n" +
                $"Cost Per:     {invoice2.PricePerItem} \n" +
                $"Invoice Total:{invoice2.GetInvoiceAmount():C}");
        }
    }
}
