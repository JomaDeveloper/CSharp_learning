using System;

namespace csharp_learning{

    class Program{
        
        static void Main() {
            // Library Math provides many maths operations.
            // Console.WriteLine(Math.PI);
            // Console.WriteLine(Math.Abs(-20));
            // Console.WriteLine(Math.Ceiling(4.11f));
            // Console.WriteLine(Math.Floor(4.11f));
            // Console.WriteLine(Math.Round(4.11f));
            // Console.WriteLine(Math.Min(5, 0));
            // Console.WriteLine(Math.Max(5, 0));
            // Console.WriteLine(Math.Pow(5, 2)); // Степень

            Console.WriteLine("Введите радиус круга: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(rad, 2);
            Console.WriteLine("Площадь круга с радиусом {0} равна {1}", rad, Math.Round(area, 2)); // Вывод можно сделать и так.
        }

    }

}