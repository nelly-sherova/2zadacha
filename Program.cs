using System;

namespace _2zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 задача
            Console.Write("A = ");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("B = ");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Console.Write("C = ");
            decimal c = Convert.ToDecimal(Console.ReadLine());
            decimal AC, BC;
            AC = Math.Abs(a - c);
            BC = Math.Abs(b - c);
            Console.WriteLine($"Длина отрезка AC =  {AC}");
            Console.WriteLine($"Длина отрезка BC =  {BC}");
            Console.WriteLine($"AC+BC = {AC + BC} ");
        }
    }
}
