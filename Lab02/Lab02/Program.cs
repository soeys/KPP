namespace Lab02
{
    class Program
    {
        static void Main()
        {
            Container container = new Container();

            Product obj1 = new Mouse("wireless", "HAIPER EKES", 69.9, 1.5, "optic");
            Product obj2 = new Keyboard("wired", "LoJTK", 100, "Gaming", 107);
            Product obj3 = new PC("Bandera 3000", 2999.99, "Core i5 9400F", 8196);

            container.Add(obj1);
            container.Add(obj2);
            container.Add(obj3);

            for(int i = 0; i < container.Count; i++)
            {
                Console.WriteLine(container[i].ToString());
            }
        }
    }
}