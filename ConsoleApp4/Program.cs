using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            double number_a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x:");
            double number_x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double number_b = double.Parse(Console.ReadLine());
            double number_exp = 2.72;

            if (number_x >= 0 && number_x < number_b)
            {
                Console.WriteLine("Ответ = {0}",
                Math.Log(Math.Abs((number_a * Math.Pow(number_x, 5) - Math.Cos(number_x)) / number_b)));

            }
            else if (number_b <= number_x && number_x < number_a)
            {
                Console.WriteLine("Ответ = {0}",
                Math.Sqrt(Math.Pow(number_exp, number_a + 1) / Math.Tan(number_b * number_x - number_a)));
            }
            else if (number_x >= number_a)
            {
                Console.WriteLine("Ответ = {0}",
                number_a * (Math.Pow(number_x, 2) + Math.Log(Math.Abs(Math.Pow(Math.Cos(number_b * number_x), 3) - number_b * Math.Pow(number_x, 3)))));
            }



            Console.ReadKey();




        }
    }
}
