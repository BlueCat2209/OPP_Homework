using System;
using System.Collections.Generic;
using System.Text;

namespace _10._OrderList
{
    class Order
    {
        // Properties
        private int OrderID;
        private DateTime OrderDate;
        private OrderDetail[] ItemsList;
        private int MaxLength;
        private int CurLength = 0;

        // Setter
        public void SetOrderDate(DateTime dateTime)
        {
            this.OrderDate = dateTime;
        }                                            

        // Getters
        public OrderDetail[] GetItemsList() => this.ItemsList;
        public DateTime GetOrderDate() => this.OrderDate;
        public int GetOrderID() => this.OrderID;

        // Methods
        public int Find(string id)
        {
            for (int i = 0; i < this.CurLength; i++)
            {
                if (this.ItemsList[i].GetProductID() == id) return i;
            }
            return -1;
        }
        public bool AddItemsList(Product product, int quatity)
        {
            if (this.CurLength == this.MaxLength)
            {
                Console.WriteLine("The List is at the maximum size!");
                return false;
            }
            else
            if (this.Find(product.GetProductID()) >= 0)
            {
                Console.WriteLine("This Item has been added before!");
                return false;
            }
            else
            {
                this.ItemsList[this.CurLength++] = new OrderDetail(product, quatity);
                return true;
            }
        }
        public double GetTotalBill()
        {
            double totalBill = 0;
            for (int i = 0; i < this.CurLength; i++)
            {
                totalBill += this.ItemsList[i].GetTotalPrice();
            }
            return totalBill;
        }
        public void BillToString()
        {
            for (int i = 0; i < this.CurLength; i++)
            {
                Console.Write($"|{i+1}  ");
                this.ItemsList[i].InformationToString();
            }
        }
        // Constructors
        public Order(int orderID, DateTime orderDate, int maxLength)
        {
            this.OrderID = orderID;
            this.OrderDate = orderDate;
            this.MaxLength = maxLength;
            this.ItemsList = new OrderDetail[maxLength];
        }
    }
}
