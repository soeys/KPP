using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Program
    {
        static void Main()
        {
            Product obj1 = new Mouse("wireless", "HAIPER EKES", 69.9, 1.5, "optic");
            Console.WriteLine(obj1.ToString());

            Product obj2 = new Keyboard("wired", "LoJTK", 100, "Gaming", 107);
            Console.WriteLine(obj2.ToString());

            Product obj3 = new PC("Bandera 3000", 2999.99, "Core i5 9400F", 8196);

            Console.WriteLine(obj3.ToString());

            Console.ReadKey();
        }
    }
}