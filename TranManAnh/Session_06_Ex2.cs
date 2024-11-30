using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_06_Ex2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = ran(size);

            Console.WriteLine($"Generated array: {print(array)}");

            Console.WriteLine($"Average value of the array: {Question_01(array)}");

            Console.Write("Enter a value to check if it exists in the array: ");
            int check = int.Parse(Console.ReadLine());
            Console.WriteLine($"Value {check} is in the array: {Question_02(array, check)}");

            Console.Write("Enter a value to find its index: ");
            int index = int.Parse(Console.ReadLine());
            Question_03(array, index);

            Console.Write("Enter a value to remove from the array: ");
            int remove = int.Parse(Console.ReadLine());
            array = Question_04(array, remove);
            Console.WriteLine($"Array after removal: {print(array)}");

            var (max, min) = Question_05(array);
            Console.WriteLine($"Maximum of the array: {max}");
            Console.WriteLine($"Minimum of the array: {min}");

            int[] reverse = Question_06(array);
            Console.WriteLine("Reversed array: " + print(reverse));

            int[] duplicates = Question_07(array);
            Console.WriteLine("Duplicate values: " + (duplicates.Length > 0 ? print(duplicates) : "None"));

            array = Question_08(array);
            Console.WriteLine("Array after removing duplicates: " + print(array));
            Console.WriteLine();

            Console.WriteLine("Enter 10 integers:");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(numbers);
            Console.Write("Numbers sorted in ascending order:");
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter a sentence:");
            char[] sentence = Console.ReadLine().ToCharArray();

            Console.Write("Enter a word to search for in the sentence:");
            char[] wordToSearch = Console.ReadLine().ToCharArray();

            bool isFound = LinearSearch(sentence, wordToSearch);
            if (isFound)
            {
                Console.WriteLine("The word is present in the sentence.");
            }
            else
            {
                Console.WriteLine("The word is NOT present in the sentence.");
            }

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        static string print(int[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + (i < array.Length - 1 ? ", " : "");
            }
            return result;
        }

        static int[] ran(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 101); 
            }
            return array;
        }

        /// <summary>
        /// 1. Calculate the average value of array elements
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static double Question_01(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }

        /// <summary>
        /// 2. Test if an array contains a specific value
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool Question_02(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return true;
            }
            return false;
        }

        /// <summary>
        /// 3. Find the index of an array element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static void Question_03(int[] array, int value)
        {
            bool find = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    Console.WriteLine($"The index of the value is: {i}");
                    find = true;
                } 
            }
            if (!find)
            {
                Console.WriteLine($"Value {value} is not found in the array.");
            }
        }

        /// <summary>
        /// 4. Remove a specific element from an array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static int[] Question_04(int[] array, int value)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != value)
                {
                    count++;
                }
            }
            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != value)
                {
                    result[index++] = array[i];
                }
            }
            return result;
        }

        /// <summary>
        /// 5. Find the maximum and minimum value of an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static (int max, int min) Question_05(int[] array)
        {
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            return (max, min);
        }

        /// <summary>
        /// 6. Reverse an array of integer values
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] Question_06(int[] array)
        {
            int[] reversed = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }
            return reversed;
        }

        /// <summary>
        /// 7. Find duplicate values in an array of values
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] Question_07(int[] array)
        {
            List<int> duplicates = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j] && !duplicates.Contains(array[i]))
                    {
                        duplicates.Add(array[i]);
                    }
                }
            }
            return duplicates.ToArray();
        }

        /// <summary>
        /// 8. Remove duplicate elements from an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] Question_08(int[] array)
        {
            List<int> unique = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!unique.Contains(array[i]))
                {
                    unique.Add(array[i]);
                }
            }
            return unique.ToArray();
        }

        /// <summary>
        /// Orders 10 integers.
        /// </summary>
        /// <param name="array"></param>
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Search if the word appears in the phrase.
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        static bool LinearSearch(char[] sentence, char[] word)
        {
            int sentenceLength = sentence.Length;
            int wordLength = word.Length;

            for (int i = 0; i <= sentenceLength - wordLength; i++)
            {
                bool match = true;
                for (int j = 0; j < wordLength; j++)
                {
                    if (sentence[i + j] != word[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
