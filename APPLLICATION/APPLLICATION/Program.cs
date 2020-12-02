using System;


namespace LABA1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            {
                Double x1 = 0;
                Double x2 = 0;
                Double y1 = 0;
                Double y2 = 0;
                Double rasst;
                Console.Write("x1=");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("x2=");
                x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y1=");
                y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y2=");
                y2 = Convert.ToDouble(Console.ReadLine());

                {
                    rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                    Console.WriteLine("rasst:" + rasst);
                    Console.WriteLine("This proggram created by: Lupanov Denis Vadimovich from the group 19CH1c\nTap any button to close console");
                    Console.ReadKey();
                }
            }
        }
    }
}
