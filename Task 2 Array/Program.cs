using System;
using System.Linq;
namespace Task_2_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //A: Declared a 20-element array by using int.
            //Console.WriteLine("Podpunkt A");
            //int[] elements = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
            //for (int i = 0, i = elements.Length, i++);
            //Console.WriteLine(elements{i});

            //B: Using a for loop and the Random class, fill it with random numbers between 1 and 100.
            Console.WriteLine("A & B");
            Console.WriteLine();
            int[] board = new int[20];
            Random rand = new Random();

            for (int i = 0; i < board.Length; i++)
            {
                int number = rand.Next(1, 101);
                board[i] = number;
                Console.Write("{0,8:N0}", number);
                Console.WriteLine();
            }


            //C: Display the sum of all numbers with a foreach loop

            int sum = 0;
            foreach (int item in board)
            {
                sum += item;

            }
            Console.WriteLine();
            Console.WriteLine("Sum of array elements:  " + sum);
            Console.WriteLine();

            //D: Display an average value calculated from all array elements.

            double avg = 0;
            for (int i = 0; i < board.Length; i++)
            {
                avg = avg + board[i];
            }
            avg = avg / 20;
            Console.WriteLine("Average value of the array:  " + avg);
            Console.WriteLine();

            //E: Display the minimum value contained in an array

            int min = board[0];
            for (int i = 1; i < board.Length; i++)
            {
                if (board[i] < min)
                {
                    min = board[i];
                }

            }

            Console.WriteLine("The smallest element of the array is:  " + min);
            Console.WriteLine();

            //F: Display the maximum value contained in an array

            int max = board[0];
            for (int i = 1; i < board.Length; i++)
            {
                if (board[i] > max)
                {
                    max = board[i];
                }

            }
            Console.WriteLine("The largest element of the array is:  " + max);
        }
    }
}
