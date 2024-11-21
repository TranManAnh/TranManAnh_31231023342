using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_03
    {
        public static void Main()
        {
            Question_01();
            Question_02();
            Question_03();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        /// <summary>
        /// 1. Convert from degrees Celsius to Kelvin and Fahrenheit.
        /// </summary>
        public static void Question_01()
        {
            do
            {
                Console.Write("Enter a value in Celsius degree (minimum value = -273.15) = ");
                double cel;
                bool res = double.TryParse(Console.ReadLine(), out cel);
                double ke = cel + 273;
                double fa = cel * 18 / 10 + 32;

                if (cel >= -273.15)
                {
                    Console.WriteLine($"Kelvin degree = {ke}");
                    Console.WriteLine($"Fahrenheit degree = {fa}");
                    break;
                }
                else
                    Console.WriteLine("The minumum value of Celsius degree is -273.15!!!");
            } while (true);
        }

        /// <summary>
        /// 2. Calculate the surface and volume of a sphere.
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Enter radius = ");
            double r = double.Parse(Console.ReadLine());
            double s = 4 * Math.PI * r * r;
            double v = 4 / 3 * Math.PI * r * r * r;

            Console.WriteLine($"Surface of the sphere = {s}");
            Console.WriteLine($"Volume of the sphere = {v}");
        }

        /// <summary>
        /// 3. Calculates the result of adding, subtracting, multiplying and dividing two numbers.
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            double b = double.Parse(Console.ReadLine());
            double sum = a + b;
            double minus = a - b;
            double product = a * b;
            double divide = a / b;
            double mod = a % b;

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} - {b} = {minus}");
            Console.WriteLine($"{a} * {b} = {product}");
            Console.WriteLine($"{a} / {b} = {divide}");
            Console.WriteLine($"{a} mod {b} = {mod}");
        }
    }
}
