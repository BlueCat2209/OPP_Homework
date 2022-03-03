using System;
using System.Collections.Generic;
using System.Text;

namespace _10._OrderList
{
    class Product
    {
        // Properties
        private string Description;
        private string ProductID;
        private double Price;

        // Setters
        public void SetDescription(string description)
        {
            this.Description = description.Trim() != "" ? description : "#UNDEFINED";
        }
        public void SetProdutID(string productID)
        {
            this.ProductID = productID.Trim() != "" ? productID : "#UNDEFINED";
        }
        public void SetPrice(double price)
        {
            this.Price = price > 0 ? price : 0;
        }

        // Getters
        public string GetDescription() => this.Description;
        public string GetProductID() => this.ProductID;
        public double GetPrice() => this.Price;                       

        // Constructors
        public Product()
        {
            this.Description = "#UNDEFINED";
            this.ProductID = "#UNDEFINED";
            this.Price = 0;
        }
        public Product(string description, string productID, double price)
        {
            this.Description = description;
            this.ProductID = productID;
            this.Price = price;
        }
    }
}
