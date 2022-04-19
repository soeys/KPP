using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Periphery : Product
    {
        string connectionType;
        public Periphery()
        {

        }
        public Periphery(string connectionType, string name, double price) : base(name, price)
        {
            this.connectionType = connectionType;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\n\tConnection Type: {this.connectionType}";
        }
    }
}
