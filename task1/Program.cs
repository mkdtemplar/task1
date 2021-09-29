using System;
using static System.Console;

namespace task1
{
    class Program
    {
        static int MaxAge(int[] arr)
        {
            int max = arr[0];

            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        static int MinAge(int[] arr)
        {
            int min = arr[0];

            foreach (var i in arr)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            return min;
        }

        static void CountAges(int[] arr)
        {
            int countMin = 0;
            int countMax = 0;
            foreach (var i in arr)
            {
                if (i == MaxAge(arr))
                {
                    countMax++;
                }
            }

            if (countMax > 0)
            {
                WriteLine($"Oldest student in the group is {MaxAge(arr)} years old There are {countMax} at that age in the group");
            }
            else
            {
                WriteLine($"Oldest student is: {MaxAge(arr)}");
            }

            foreach (var j in arr)
            {
                if (j == MinAge(arr))
                {
                    countMin++;
                }
            }

            if (countMin > 0)
            {
                WriteLine($"Youngest student in the group is {MinAge(arr)} years old There are {countMin} at that age in the group ");
            }
            else
            {
                WriteLine($"Youngest  student is: {MinAge(arr)}");
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[8];

            for (int i = 0; i < array.Length; i++)
            {
                bool isNumber;
                Write($"Age for student {i + 1}: ");
                isNumber = int.TryParse(ReadLine(), out var number);
                while (!isNumber)
                {
                    WriteLine("Entered number is not in valid format!");
                    Write($"Age for student {i + 1}: ");
                    isNumber = int.TryParse(ReadLine(), out number);
                }

                array[i] = number;
                
                
            }

            MaxAge(array);
            MinAge(array);
            CountAges(array);
        }
    }
}
