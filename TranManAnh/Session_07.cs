using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_07
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter input string: ");
            string s1= Console.ReadLine();
            Console.WriteLine($"The input string is: {s1}");
            Console.WriteLine($"The length of the enter string is: {Length(s1)}");
            Console.Write("Separate individual characters from a string: "); Separate(s1); Console.WriteLine();
            Console.WriteLine("The individual characters of the string in reverse order: "); Print(s1);
            Console.WriteLine($"The number of words in the string is: {CountWord(s1)}.");
            Console.Write("Enter the second string: ");
            string s2 = Console.ReadLine();
            Console.WriteLine($"Compare 2 strings: {Compare(s1,s2)}");
            Console.WriteLine("Count the number of alphabets, digits and special characters in a string: "); CountCharacterTypes(s1); Console.WriteLine();          
            Console.WriteLine("Count the number of vowels or consonants in a string: "); CountVowelsAndConsonants(s1); Console.WriteLine();
            Console.Write("Enter a substring: ");
            string substring = Console.ReadLine();
            Console.WriteLine("Check if a substring is present in the given string: "); CheckSubstringPresent(s1, substring) ; Console.WriteLine();
            Console.WriteLine("Find the position of a substring in a string:"); FindSubstringPosition(s1 , substring) ; Console.WriteLine();
            Console.Write("Enter a character: ");
            char c = Console.ReadLine()[0];
            Console.WriteLine("Check whether a character is an alphabet and determine the case:"); CheckCharacterAlphabetAndCase(c); Console.WriteLine();
            Console.WriteLine("Count the number of times a substring appears in a string:"); CountSubstringOccurrences(s1 , substring) ; Console.WriteLine();
            Console.Write("Enter a substring to insert: ");
            string insert = Console.ReadLine();
            Console.WriteLine("Insert a substring before the first occurrence of a string:"); InsertSubstringBefore(s1, insert, substring) ; Console.WriteLine();

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }

        /// <summary>
        /// Find the length of a string without using a library function.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int Length(string s1)
        {
            int l = 0;
            foreach (char c in s1)
            {
                l++;
            }
            return l;
        }

        /// <summary>
        /// Input a string and print it.
        /// </summary>
        /// <param name="s"></param>
        static void Print(string s1)
        {
            for (int i = 0; i < Length(s1); i++)
            {
                Console.WriteLine(s1[i]);
            }
        }

        /// <summary>
        ///  Print individual characters of the string in reverse order.
        /// </summary>
        /// <param name="s"></param>
        static void Reverse(string s1)
        {
            for (int i = s1.Length - 1; i >= 0; i--)
                Console.WriteLine(s1[i]);
        }

        /// <summary>
        /// Separate individual characters from a string.
        /// </summary>
        /// <param name="s"></param>
        static void Separate(string s1)
        {
            foreach (char c in s1)
            {
                Console.Write($"{c} ");
            }
        }

        /// <summary>
        /// Count the total number of words in a string.
        /// </summary>
        /// <param name="s1"></param>
        /// <returns></returns>
        static int CountWord(string s1)
        {
            if (s1 == null || s1.Length == 0)
            {
                return 0;
            }

            int count = 0;
            bool inWord = false;

            for (int i = 0; i < s1.Length; i++)
            {
                char c = s1[i];

                if (c != ' ' && c != '\t' && c != '\n' && c != '\r')
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }
            return count;
        }

        /// <summary>
        /// Compare two strings without using a string library functions.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        static int Compare (string s1, string s2)
        {
            int l1 = s1.Length;
            int l2 = s2.Length;
            int min = l1 > l2 ? l1 : l2;
            int i = 0;
            while (i < min)
            {
                if (s1[i] > s2[i])
                    return 1;
                else if (s1[i] < s2[i])
                    return -1;
                i++;
            }
            if (s1.Length > s2.Length) return 1;
            else if(s1.Length < s2.Length) return -1;
            return 0;
        }

        /// <summary>
        /// Count the number of alphabets, digits and special characters in a string.
        /// </summary>
        /// <param name="input"></param>
        static void CountCharacterTypes(string s1)
        {
            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            foreach (char c in s1)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }
            Console.WriteLine($"Number of alphabets: {alphabetCount}");
            Console.WriteLine($"Number of digits: {digitCount}");
            Console.WriteLine($"Number of special characters: {specialCharCount}");
        }

        /// <summary>
        /// Count the number of vowels or consonants in a string.
        /// </summary>
        /// <param name="s1"></param>
        static void CountVowelsAndConsonants(string s1)
        {
            int vowelCount = 0;
            int consonantCount = 0;

            foreach (char c in s1)
            {
                if (char.IsLetter(c)) 
                {
                    char lowerChar = char.ToLower(c);
                    if ("aeiou".Contains(lowerChar)) 
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            Console.WriteLine($"Vowels: {vowelCount}, Consonants: {consonantCount}");
        }

        /// <summary>
        /// Check if a substring is present in the given string.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="substring"></param>
        static void CheckSubstringPresent(string s1, string substring)
        {
            bool isSubstringPresent = false;

            for (int i = 0; i <= s1.Length - substring.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < substring.Length; j++)
                {
                    if (s1[i + j] != substring[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    isSubstringPresent = true;
                    break;
                }
            }
            Console.WriteLine(isSubstringPresent ? "Substring is present." : "Substring is not present.");
        }

        /// <summary>
        /// Find the position of a substring in a string.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="substring"></param>
        static void FindSubstringPosition(string s1, string substring)
        {
            for (int i = 0; i <= s1.Length - substring.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < substring.Length; j++)
                {
                    if (s1[i + j] != substring[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    Console.WriteLine($"Substring found at position {i}");
                    return;
                }
            }
            Console.WriteLine("Substring not found.");
        }

        /// <summary>
        /// Check whether a character is an alphabet and determine the case.
        /// </summary>
        /// <param name="c"></param>
        static void CheckCharacterAlphabetAndCase(char c)
        {
            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                {
                    Console.WriteLine($"{c} is an uppercase letter.");
                }
                else
                {
                    Console.WriteLine($"{c} is a lowercase letter.");
                }
            }
            else
            {
                Console.WriteLine($"{c} is not an alphabet.");
            }
        }

        /// <summary>
        /// Count the number of times a substring appears in a string.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="substring"></param>
        static void CountSubstringOccurrences(string s1, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = s1.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }

            Console.WriteLine($"The substring appears {count} times.");
        }

        /// <summary>
        /// Insert a substring before the first occurrence of a string.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="substringToInsert"></param>
        /// <param name="targetSubstring"></param>
        static void InsertSubstringBefore(string s1, string substringToInsert, string targetSubstring)
        {
            int index = s1.IndexOf(targetSubstring);
            if (index != -1)
            {
                s1 = s1.Insert(index, substringToInsert);
                Console.WriteLine($"Updated string: {s1}");
            }
            else
            {
                Console.WriteLine("Target substring not found.");
            }
        }
    }
}
