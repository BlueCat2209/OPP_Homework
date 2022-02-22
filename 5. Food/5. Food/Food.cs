using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace _5._Food
{
    class Food
    {
        //  Properties
        private string Id;
        private string Name;        
        private int Price;
        private DateTime CreateDate;
        private DateTime ExpiryDate;

        // Setter 
        private void SetId(string id)
        {           
            if (id == "") Console.WriteLine("ID invalid! Please enter a fully function ID");
            else this.Id = id;
        }
        public void SetName(string name)
        {
            if (name == "") this.Name = "xxx";
            else this.Name = name;
        }
        public void SetPrice(int price)
        {
            if (price < 0) this.Price = 0;
            else this.Price = price;
        }
        public void SetCreateDate(DateTime createDate)
        {
            this.CreateDate = createDate;
        }
        public void SetExpiryDate(DateTime expiryDate)
        {
            int check;
            do
            {
                check = DateTime.Compare(expiryDate, this.CreateDate);
                switch (check)
                {
                    case 0: // expiryDate = this.CreateDate
                    case 1: // expiryDate > this.CreateDate
                        this.ExpiryDate = expiryDate;
                        break;
                    case -1: // expiryDate < this.CreateDate
                        Console.WriteLine($"The expiry date of {this.Name} is incompatible! Please re-enter!");
                        Console.Write("Enter Expiry Day: ");
                        int day = int.Parse(Console.ReadLine());
                        Console.Write("Enter Expiry Month: ");
                        int month = int.Parse(Console.ReadLine());
                        Console.Write("Enter Expiry Year: ");
                        int year = int.Parse(Console.ReadLine());

                        expiryDate = new DateTime(year, month, day);
                        break;
                }
                Console.Clear();
            } while (check < 0);
        }


        // Getter
        public string GetID()
        {
            return this.Id;
        }
        public string GetName()
        {
            return this.Name;
        }
        public int GetPrice()
        {
            return this.Price;
        }
        public DateTime GetCreateDate()
        {
            return this.CreateDate;
        }
        public DateTime GetExpiryDate()
        {
            return this.ExpiryDate;
        }

        // Methods  
        public bool IsOutOfDate()
        {
            switch (DateTime.Compare(this.ExpiryDate, DateTime.Now))
            {
                case 0: // this.ExpiryDate = DateTime.Now
                case 1: // this.ExpiryDate > DateTime.Now
                    return false;               
                case -1: // this.ExpiryDate < DateTime.Now
                    return true;
                default:
                    return false;
            }
        }
        public void InformationToString()
        {
            string Note;
            if (this.IsOutOfDate()) Note = "Out Of Date";
            else Note = "";
            Console.WriteLine($"|{this.Id,3}|{this.Name,20}|{this.Price,15:C2}|{this.CreateDate,15:d}|{this.ExpiryDate,15:d}|{Note,15}|");
        }

        // Constructors
        public Food(string id, string name, int price, DateTime createDate, DateTime expiryDate)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetPrice(price);
            this.SetCreateDate(createDate);
            this.SetExpiryDate(expiryDate);
        }
        public Food(string id)
        {
            this.SetId(Id);            
        }
    }
}