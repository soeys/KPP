using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Keyboard : Periphery
    {
        string keyboardDescription;
        int numberOfKeys;
        public Keyboard() {}
        public Keyboard(string connectionType, string name, double price, string keyboardDescription, int numberOfKeys) : base(connectionType, name, price)
        {
            this.keyboardDescription = keyboardDescription;
            this.numberOfKeys = numberOfKeys;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\n\tKeyboard Description: {this.keyboardDescription}" +
                   $"\n\tNumber of Keys: {this.numberOfKeys}";
        }
    }
}