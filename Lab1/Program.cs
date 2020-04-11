using System;

namespace Lab1
{
    class Program
    {
        enum gradus : int
        {
            min = 0,
            krit = 72,
            max = 100,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            const int i = 10;	
            Console.WriteLine(i);
            Console.WriteLine("минимальная температура=" + (int)gradus.min);
            Console.WriteLine("критическая температура=" + (int)gradus.krit);
            Console.WriteLine("максимальная температура=" + (int)gradus.max);
            double x = Math.E;
            Console.WriteLine("E={0,20}", x);
            Console.WriteLine("E={0,10}", x);
            Console.WriteLine("E={0:##.###}", x);
            Console.WriteLine("E={0:.######}", x);

            Console.WriteLine("C Format:{0,14:C} \t{0:C2}", 12345.678);
            Console.WriteLine("D Format:{0,14:D} \t{0:D6}", 123);
            Console.WriteLine("E Format:{0,14:E} \t{0:E8}", 12345.6789);
            Console.WriteLine("G Format:{0,14:G} \t{0:G10}", 12345.6789);
            Console.WriteLine("N Format:{0,14:N} \t{0:N4}", 12345.6789);
            Console.WriteLine("X Format:{0,14:X} ", 1234);
            Console.WriteLine("P Format:{0,14:P} ", 0.9);
            

            double z = double.Parse(Console.ReadLine()); //преобразование введенной строки в число
            Console.WriteLine("z={0:.###}",z);


        }
    }
}
