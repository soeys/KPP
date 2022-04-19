using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Mouse : Periphery
    {
        double cableLenth;
        string movementDetectionTechnology;
        public Mouse() { }
        public Mouse(string connectionType, string name, double price, double cableLenth, string movementDetectionTechnology) : base(connectionType, name, price)
        {
            this.cableLenth = cableLenth;
            this.movementDetectionTechnology = movementDetectionTechnology;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\n\tCable Lenth: {this.cableLenth}m" +
                   $"\n\tMovement Detection Technology: {this.movementDetectionTechnology}";
        }
    }
}
