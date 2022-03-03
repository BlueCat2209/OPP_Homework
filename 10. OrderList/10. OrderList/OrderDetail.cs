using System;
using System.Collections.Generic;
using System.Text;

namespace _10._OrderList
{
    class OrderDetail
    {
        // Properties
        private int Quatity;
        private Product Production;
        
        // Setter
        public void SetQuatity(int quatity)
        {
            this.Quatity = quatity;
        }

        // Getter
        public int GetQuatity() => this.Quatity;
        public string GetProductID() => this.Production.GetProductID();

        // Methods
        public double GetTotalPrice() => this.Quatity * this.Production.GetPrice();
        public void InformationToString()
        {
            Console.WriteLine($"|{this.Production.GetProductID(),-5}|{this.Production.GetDescription(),-15}|{this.Production.GetPrice(),10:c}|{this.Quatity, 10}|{this.GetTotalPrice(),10:c}|");
        }
        // Constructor
        public OrderDetail(Product product, int quatity)
        {
            this.Production = product;
            this.Quatity = quatity;
        }
    }
}
