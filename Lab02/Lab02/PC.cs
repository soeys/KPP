using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class PC : Product
    {
        string CPU;
        int ramCapacity;
        public PC() { }
        public PC(string name, double price, string CPU, int ramCapacity) : base(name, price)
        {
            this.CPU = CPU;
            this.ramCapacity = ramCapacity;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n\tCPU model: {this.CPU}" +
                $"\n\tRAM capacity: {this.ramCapacity}";
        }
    }
}
