using System;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Enter 2 numbers:");
            Console.Write("a = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x + " + " + y + " = " + (x + y)+"\n");

            //Задание 2
            Console.WriteLine("Enter 3 numbers:");
            Console.Write("a = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}+{2}={2}+{1}+{0}\n",x1,y1,z1);

            //Задание 3
            Console.WriteLine("Enter 3 numbers:");
            Console.Write("a = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine(x2+"+"+y2+"+"+z2+"="+(x2+y2+z2)+"\n");

            //Задание 4
            Console.WriteLine("Enter 2 numbers:");
            Console.Write("a = ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double y3 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:.#}*{1:.#}={2:.#}\n",x3,y3,x3*y3);


            //Задание 5
            Console.WriteLine("Enter 2 numbers:");
            Console.Write("a = ");
            double x4 = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double y4 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:.###}/{1:.###}={2:.###}\n", x4, y4, x4 / y4);

            //Задание 6
            Console.WriteLine("Enter 3 numbers:");
            Console.Write("a = ");
            double x5 = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double y5 = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double z5 = double.Parse(Console.ReadLine());
            Console.WriteLine("({0:.##}+{1:.##})+{2:.##}={0:.##}+({1:.##}+{2:.##})\n", x5, y5, z5);
        }
    }
}
