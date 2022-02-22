using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Vehicles
{
    class Vehicle
    {
        // Attributes
        private string Owner;
        private string Type;
        private double Price;
        private int CylinderCap;

        //Methods
        public double GetTax()
        {
            double tax;
            if (this.CylinderCap < 100)
            {
                tax = this.Price / 100;
            } 
            else if (this.CylinderCap < 200)
            {
                tax = this.Price * 3 / 100;
            }
            else
            {
                tax = this.Price * 5 / 100; 
            }                 
                
            return tax;
        }
        public void InformationToString()
        {
            Console.WriteLine($"|{this.Owner,-20}|{this.Type,-15}|{this.CylinderCap,11}|{this.Price,15:n2}|{this.GetTax(),9:n2}|");
        }


        // Constructors
        public Vehicle()
        {
            this.Owner = "#No_Information#";
            this.Type = "#No_Information#";
            this.Price = -1;
        } 
        public Vehicle(string owner, string type, int cylinderCap, double price)
        {
            if (owner == "") this.Owner = "#No_Information";
            else this.Owner = owner;

            if (type == "") this.Owner = "No_Information";
            else this.Type = type;

            if (cylinderCap < 0) this.CylinderCap = -1;
            else this.CylinderCap = cylinderCap;

            if (price <= 0) this.Price = -1;
            else this.Price = price;
        }
    }
}
