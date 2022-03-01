using System;
using System.Collections.Generic;
using System.Text;

namespace _8._A_CD_List
{
    class CDList
    {
        // Properties
        private CD[] List;     
        private int Maxlength;
        public int Curlength = 0;

        // Setters
        public bool SetList(CD[] list)
        {
            this.List = list == null ? list : this.List;
            if (this.List == null) return false;
            else return true;
        }
        public bool SetMaxlength(int length)
        {
            this.Maxlength = length >= List.Length ? length : this.Maxlength;
            if (this.Maxlength == length) return true;
            else return false;
        }
        public bool Add(CD tmp)
        {
            if (this.Curlength == this.Maxlength)
            {
                Console.WriteLine("The list is full!");
                return false;
            }
            else
            {                
                if (this.Find(tmp.GetId()) >= 0)
                {
                    Console.WriteLine("This CD is existed!");
                    return false;
                }
                else
                {
                    this.List[this.Curlength++] = tmp;
                    return true;
                }
            }
        }

        // Getter
        public int GetMaxlength() => this.Maxlength;
        public int GetCurlength() => this.Curlength;
        public CD GetCDInformation(int id) => this.List[this.Find(id)];
        public double GetTotalPrice()
        {
            double price = 0;
            for (int i = 0; i < this.Curlength; i++)
            {
                price += this.List[i].GetPrice();
            }
            return price;
        }

        // Methods
        public int Find(int id)
        {
            for (int i = 0; i <= this.Curlength; i++)
            {
                if ((this.List == null)||(this.List[i] == null)) return -1;
                int curr = this.List[i].GetId();
                if (curr == id) return i; 
            }
            return -1;
        }
        public void InformationToString()
        {
            for (int i = 0; i < this.Curlength; i++)
            {
                this.List[i].InformationToString();
            }
        }        
        public void SortListByPrice(CDList tmp)
        {
            Array.Sort(tmp.List, new CD.CDPriceComparer());           
        }
        public void SortListByName(CDList tmp)
        {
            Array.Sort(tmp.List, new CD.CDNameComparer());          
        }

        // Constructors        
        public CDList(int length)
        {
            this.List = new CD[length];
            this.Maxlength = length;
            this.Curlength = 0;
        }
        public CDList(CD[] list, int length)
        {
            this.List = list;
            this.Maxlength = length;
            this.Curlength = list.Length;
        }
    }
}
