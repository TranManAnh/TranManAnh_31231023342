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
    }
}
