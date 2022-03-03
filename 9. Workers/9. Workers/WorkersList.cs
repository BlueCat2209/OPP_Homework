using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Workers
{
    class WorkersList
    {    
        // Properties
        public Worker[] List;
        private int MaxLength;
        private int CurLength;

        // Methods
        public int Find(int id)
        {
            for (int i=0; i < this.CurLength; i++)
            {
                if (this.List[i].GetID() == id) return i;
            }
            return -1;
        }
        public bool Add(Worker tmp)
        {
            if (this.MaxLength == this.CurLength)
            {
                Console.WriteLine("The List is at the maximum size!");
                return false;
            }
            else
            if (Find(tmp.GetID()) > 0)
            {
                Console.WriteLine("The worker with this ID has been added before!");
                return false;
            }
            else
            {
                this.List[CurLength++] = tmp;
                return true;
            }
        }
        public int GetTotalWorker() => this.CurLength;
        public void TotalInformationToString()
        {
            for (int i = 0; i < this.CurLength; i++)
            {
                this.List[i].InformationToString();
            }
        }
        public void OnKPIToString(int kpi)
        {
            for (int i=0; i<this.CurLength; i++)
            {
                if (this.List[i].GetKPI() >= kpi)
                {
                    this.List[i].InformationToString();
                }
            }    
        }
        public void SortListByKPI(WorkersList tmp)
        {
            Array.Sort(tmp.List, new Worker.WorkerKPIComparer());
        }


        // Constructors
        public WorkersList(int lenght)
        {
            this.List = new Worker[lenght];
            this.MaxLength = lenght;
            this.CurLength = 0;
        }                              
    }
}
