using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_04_Ex2
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
        /// 1.Check whether a given number is even or odd.
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter number a = ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is an even number.");
            }
            else
            {
                Console.WriteLine($"{a} is an odd number.");
            }
        }

        /// <summary>
        /// 2. Find the largest of three numbers.
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Enter the first number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number c = ");
            int c = int.Parse(Console.ReadLine());
            int max;

            if (a > b && a > c)
            {
                max = a;
            }
            else if (b > a && b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
            Console.WriteLine($"The largest number is {max}.");
        }

        /// <summary>
        /// 3. Accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter the value for X coordinate = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the value for Y coordinate = ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point {x};{y} lies in the 1st Quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point {x};{y} lies in the 2nd Quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point {x};{y} lies in the 3nd Quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point {x};{y} lies in the 4th Quadrant.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point {x};{y} lies at the Origin.");
            }
        }
    }
}
