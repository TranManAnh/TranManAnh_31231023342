using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_04_Ex1
    {
        public static void Main()
        {
            Question_01();
            Question_02();
            Question_03();
            Question_04();
            Question_05();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        /// <summary>
        /// 1. Takes two numbers as input and performs an operation(+,-,*, x,/) on them and displays the result of that operation.
        /// </summary>
        public static void Question_01()
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

        /// <summary>
        /// 2. Display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        public static void Question_02()
        {
            do
            {
                Console.Write("Enter number y (ranging from -5 to +5) = ");
                int y;
                bool res = int.TryParse(Console.ReadLine(), out y);
                int x = y * y + 2 * y + 1;


                if (res && y >= -5 && y <= 5)
                {
                    Console.WriteLine($"Numbers x = {x}");
                    break;
                }
                else
                    Console.WriteLine("Number y must in range of -5 and +5!!!");
            } while (true);
        }

        /// <summary>
        /// 3. Takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h).
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter distance (kilometer) = ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Enter time (hours) = ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter time (minutes) = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter time (seconds) = ");
            int sec = int.Parse(Console.ReadLine());

            double time = hours + min / 60.0 + sec / 3600.0;
            double mile = km * 0.621371;

            double speedkm = km / time;
            double speedmi = mile / time;

            Console.WriteLine($"Speed in kilometers per hour (km/h) = {speedkm}");
            Console.WriteLine($"speed in miles per hour (miles/h) = {speedmi}");
        }

        /// <summary>
        /// 4. Takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.
        /// </summary>
        public static void Question_04()
        {
            Console.Write("Enter radius = ");
            double r = double.Parse(Console.ReadLine());
            double s = 4 * Math.PI * r * r;
            double v = 4 / 3 * Math.PI * r * r * r;

            Console.WriteLine($"Surface of the sphere = {s}");
            Console.WriteLine($"Volume of the sphere = {v}");
        }

        /// <summary>
        /// 5. Takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Enter a character: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsDigit(inputChar))
            {
                Console.WriteLine($"'{inputChar}' is a digit.");
            }
            else if ("aeiouAEIOU".Contains(inputChar))
            {
                Console.WriteLine($"'{inputChar}' is a vowel.");
            }
            else
            {
                Console.WriteLine($"'{inputChar}' is a symbol or consonant.");
            }
        }
    }
}
