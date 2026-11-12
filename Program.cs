using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppС
{
    internal class Program
    {
        static int GetSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static int CountEven(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static int CountOdd(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsPositive(int number)
        {
            return number > 0;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 12, 5, 18, 7, 20, 3, 14 };
            Console.WriteLine("Исходный массив: " + string.Join(", ", numbers));
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Сумма всех элементов: " + GetSum(numbers));
            Console.WriteLine("Количество чётных чисел: " + CountEven(numbers));
            Console.WriteLine("Количество нечётных чисел: " + CountOdd(numbers));

            Console.WriteLine("\nПроверка метода IsPositive для каждого элемента: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Число " + numbers[i] + " > 0: " + IsPositive(numbers[i]));
            } 
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Введите число для проверки в массиве: ");

            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                bool isFound = false;
                for (int j = 0; j < numbers.Length; j++) 
                {
                    if (numbers[j] == userNumber)
                    {
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    Console.WriteLine("Успех! Число " + userNumber + " присутствует в массиве.");
                }
                else
                {
                    Console.WriteLine("Число " + userNumber + " отсутствует в массиве.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: вы ввели не целое число.");
            }
        }
    }
}
