using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Session_06_Ex3
    {
        static void Main(string[] args)
        {
            Question_01();
            Question_02();
            Question_03();
        }

        static void Question_01()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = CreateMatrix(rows, cols);
            Console.WriteLine("Matrix:");
            PrintMatrix(matrix, rows, cols);

            Console.Write("Enter the row/column index to print (starting from 0): ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Enter 'r' for row or 'c' for column: ");
            char rowOrCol = char.Parse(Console.ReadLine());

            if (rowOrCol == 'r')
            {
                PrintRow(matrix, index, cols);
            }
            else if (rowOrCol == 'c')
            {
                PrintColumn(matrix, index, rows);
            }

            int maxValue = FindMax(matrix, rows, cols);
            Console.WriteLine($"Max value in the matrix: {maxValue}");

            Console.Write("Enter the row/column index to find min (starting from 0): ");
            index = int.Parse(Console.ReadLine());
            Console.Write("Enter 'r' for row or 'c' for column: ");
            rowOrCol = char.Parse(Console.ReadLine());

            if (rowOrCol == 'r')
            {
                int minInRow = FindMinRow(matrix, index, cols);
                Console.WriteLine($"Min value in row {index}: {minInRow}");
            }
            else if (rowOrCol == 'c')
            {
                int minInCol = FindMinColumn(matrix, index, rows);
                Console.WriteLine($"Min value in column {index}: {minInCol}");
            }

            int[,] transposedMatrix = Transpose(matrix, rows, cols);
            Console.WriteLine("Transposed Matrix:");
            PrintMatrix(transposedMatrix, cols, rows); 

            Console.WriteLine("Main diagonal of the matrix:");
            PrintMainDiagonal(matrix, rows, cols);

            Console.WriteLine("Secondary diagonal of the matrix:");
            PrintSecondaryDiagonal(matrix, rows, cols);
        }

        public static void Question_02()
        {
            int[][] jaggedArray = new int[4][]; 

            jaggedArray[0] = new int[] { 1, 1, 1, 1, 1 }; 
            jaggedArray[1] = new int[] { 2, 2 }; 
            jaggedArray[2] = new int[] { 3, 3, 3, 3 }; 
            jaggedArray[3] = new int[] { 4, 4 }; 
            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) 
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine(); 
            }
        }

        public static void Question_03()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[cols]; 
                for (int j = 0; j < cols; j++)
                {
                    jaggedArray[i][j] = rand.Next(1, 100);
                }
            }

            Console.WriteLine("\nJagged Array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Task_1(jaggedArray, rows, cols);
            Task_2(jaggedArray, rows, cols);
            Task_3(jaggedArray, rows, cols);
            Task_4(jaggedArray, rows, cols);
        }

        public static void Task_1(int[][] jaggedArray, int rows, int cols)
        {
            int largestInArray = int.MinValue;

            Console.WriteLine("\nBiggest number in each row and the largest number in the entire array:");

            for (int i = 0; i < rows; i++)
            {
                int largestInRow = jaggedArray[i][0];

                for (int j = 1; j < cols; j++)
                {
                    if (jaggedArray[i][j] > largestInRow)
                        largestInRow = jaggedArray[i][j];
                }

                Console.WriteLine($"Row {i + 1}: {largestInRow}");

                if (largestInRow > largestInArray)
                    largestInArray = largestInRow;
            }

            Console.WriteLine($"Largest number in the entire array: {largestInArray}");
        }

        public static void Task_2(int[][] jaggedArray, int rows, int cols)
        {
            Console.WriteLine("\nSorted rows in ascending order:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    for (int k = j + 1; k < cols; k++)
                    {
                        if (jaggedArray[i][j] > jaggedArray[i][k])
                        {
                            int temp = jaggedArray[i][j];
                            jaggedArray[i][j] = jaggedArray[i][k];
                            jaggedArray[i][k] = temp;
                        }
                    }
                }

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void Task_3(int[][] jaggedArray, int rows, int cols)
        {
            Console.WriteLine("\nPrime numbers in the array:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (IsPrime(jaggedArray[i][j]))
                    {
                        Console.Write(jaggedArray[i][j] + "\t");
                    }
                }
            }

            Console.WriteLine();
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static void Task_4(int[][] jaggedArray, int rows, int cols)
        {
            Console.Write("\nEnter the number to search for: ");
            int target = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (jaggedArray[i][j] == target)
                    {
                        Console.WriteLine($"Found {target} at position: ({i}, {j})");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"Number {target} not found in the array.");
            }
        }

        static int[,] CreateMatrix(int rows, int cols)
        {
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintRow(int[,] matrix, int rowIndex, int cols)
        {
            Console.WriteLine($"Row {rowIndex}:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[rowIndex, j] + "\t");
            }
            Console.WriteLine();
        }

        static void PrintColumn(int[,] matrix, int colIndex, int rows)
        {
            Console.WriteLine($"Column {colIndex}:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i, colIndex] + "\t");
            }
            Console.WriteLine();
        }

        static int FindMax(int[,] matrix, int rows, int cols)
        {
            int max = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }

            return max;
        }

        static int FindMinRow(int[,] matrix, int rowIndex, int cols)
        {
            int min = matrix[rowIndex, 0];

            for (int j = 1; j < cols; j++)
            {
                if (matrix[rowIndex, j] < min)
                {
                    min = matrix[rowIndex, j];
                }
            }

            return min;
        }

        static int FindMinColumn(int[,] matrix, int colIndex, int rows)
        {
            int min = matrix[0, colIndex];

            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, colIndex] < min)
                {
                    min = matrix[i, colIndex];
                }
            }

            return min;
        }

        static int[,] Transpose(int[,] matrix, int rows, int cols)
        {
            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            return transposed;
        }

        static void PrintMainDiagonal(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < Math.Min(rows, cols); i++)
            {
                Console.Write(matrix[i, i] + "\t");
            }
            Console.WriteLine();
        }

        static void PrintSecondaryDiagonal(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < Math.Min(rows, cols); i++)
            {
                Console.Write(matrix[i, cols - 1 - i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
