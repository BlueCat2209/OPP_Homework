using System;
using System.Collections.Generic;
using System.Text;

namespace _8._A_CD_List
{
    class CD
    {
        public class CDPriceComparer : IComparer<CD>
        {
            public int Compare(CD x, CD y)
            {
                return x.GetPrice().CompareTo(y.GetPrice());
            }
        }
        public class CDNameComparer : IComparer<CD>
        {
            public int Compare(CD x, CD y)
            {
                return x.GetName().CompareTo(y.GetName());
            }
        }
        // Properties
        private int Id;
        private string Name;
        private int SongsNumber;
        private double Price;

        // Setters
        public void SetId(int id)
        {
            if (id > 0) this.Id = id;
            else this.Id = 999999;
        }
        public void SetName(string name)
        {
            if (name.Trim() == "") this.Name = "#UNDEFINED";
            else this.Name = name;
        }
        public void SetSongsNumber(int songsNumber)
        {
            if (songsNumber >= 0) this.SongsNumber = songsNumber;
            else this.SongsNumber = 0;
        }
        public void SetPrice(double price)
        {
            if (price >= 0) this.Price = price;
            else this.Price = 0;
        }

        // Getters
        public int GetId() => this.Id;
        public string GetName() => this.Name;
        public int GetSongsNumber() => this.SongsNumber;
        public double GetPrice() => this.Price;

        // Method
        public void InformationToString()
        {
            string information = $"|{this.Id,-5}|{this.Name,-20}|{this.SongsNumber,12}|{this.Price,5}|";
            Console.WriteLine(information);
        }
        
        // Constructors
        public CD()
        {
            this.Id = 999999;
            this.Name = "#UNDEFINED";
            this.SongsNumber = 0;
            this.Price = 0;
        }
        public CD(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public CD(int id, string name, int songsNumber, double price)
        {
            this.Id = id;
            this.Name = name;
            this.SongsNumber = songsNumber;
            this.Price = price;
        }
    }
}
