using System;

namespace _10._OrderList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|STT|ID   |DESCRIPTION    |PRICE     |QUATITY   |TOTAL     |");
         
            Order myOrder = new Order(1, new DateTime(1, 1, 1), 3);
            myOrder.AddItemsList(new Product("Sauces", "A", 3), 7);
            myOrder.AddItemsList(new Product("Rice", "B", 7), 8);
            myOrder.AddItemsList(new Product("Noodle", "C", 9), 9);
            myOrder.BillToString();
        }
    }
}
