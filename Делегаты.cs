using System;

namespace делегаты
{
    delegate double Delegate(double radius);
    class Program
    {
        static void Main(string[] args)
        {
            Delegate del = Circuit;
            double result = Circuit(double.Parse(Console.ReadLine()));
            Console.WriteLine(result);
            del = Square;
            result = Square(double.Parse(Console.ReadLine()));
            Console.WriteLine(result);
            del = Volume;
            result = Volume(double.Parse(Console.ReadLine()));
        }
        public static double Circuit(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static double Square(double radius)
        {
            return Math.PI * radius * radius;
        }
        public static double Volume (double radius)
        {
            return (4 / 3) * Math.PI * radius * radius * radius;
        }
    }
}
