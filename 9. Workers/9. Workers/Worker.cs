using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Workers
{   
    class Worker
    {
        // Something need to be added when using Sort but I don't know how to named it?!
        public class WorkerKPIComparer : IComparer<Worker>
        {
            public int Compare(Worker a, Worker b)
            {
                return a.GetKPI().CompareTo(b.GetKPI());
            }
        }

        // Properties
        private int Id;
        private string Name;
        private int KPI;

        // Setters
        public void SetID(int id)
        {
            this.Id = id > 0 ? id : 0;
        }
        public void SetName(string name)
        {
            this.Name = name.Trim() != "" ? name : "#UNDEFINED";
        }
        public void SetKPI(int kpi)
        {
            this.KPI = kpi > 0 ? kpi : 0;
        }

        // Getters
        public int GetID() => this.Id;
        public string GetName() => this.Name;
        public int GetKPI() => this.KPI;

        // Methods
        public double GetSalary()
        {
            if (this.KPI < 200) return this.KPI * 0.5;
            else
            if (this.KPI < 400) return this.KPI * 0.55;
            else
            if (this.KPI < 500) return this.KPI * 0.6;
            else return this.KPI * 0.65;
        }
        public void InformationToString()
        {
            Console.WriteLine($"|{this.Id,-5}|{this.Name,-20}|{this.KPI,5}|{this.GetSalary(),9:n2}|");
        }        

        // Constructors
        public Worker()
        {
            this.Id = 0;
            this.Name = "#UNDEFINED";
            this.KPI = 0;
        }
        public Worker(int id, string name, int kpi)
        {
            this.Id = id > 0 ? id : 0;
            this.Name = name.Trim() != "" ? name : "#UNDEFINED";
            this.KPI = kpi > 0 ? kpi : 0;
        }
    }
}
