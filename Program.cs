using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Massives_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод четных чисел из диапазона");
            Console.WriteLine("Введите первое число");
            int num1;
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Введите второе число");
            int num2;
            Int32.TryParse(Console.ReadLine(), out num2);

            if (num1 > num2)
            {
                int temp = num2;
                num2 = num1;
                num1 = temp;
            }
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Количество элементов в массиве меньше введенного с клавиатуры");

            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(50);
            }
            Console.WriteLine("Введите целевое значение:");
            int lim;
            Int32.TryParse(Console.ReadLine(), out lim);

            // Подсчитать количество значений в массиве меньше порога
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < lim)
                    count++;
            }

            // Вывести результат
            Console.WriteLine($"Количество значений в массиве меньше {lim}: {count}");

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Количество повторений");
            Console.WriteLine("Введите три числа");

            int num3;
            Int32.TryParse(Console.ReadLine(), out num3);
            int num4;
            Int32.TryParse(Console.ReadLine(), out num4);
            int num5;
            Int32.TryParse(Console.ReadLine(), out num5);
            int[] nums = { num3, num4, num5 };

            int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            count = 0;
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] == numbers[0] && array[i + 1] == numbers[1] && array[i + 2] == numbers[2])
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество повторений последовательности: {count}");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("общие элементы");
            const int M = 10;
            const int N = 20;
            int[] array1 = new int[M];
            int[] array2 = new int[N];

            for (int i = 0; i < M; i++)
            {
                array1[i] = random.Next(50);
            }
            for (int i = 0; i < N; i++)
            {
                array2[i] = random.Next(50);
            }

            int[] commonElements = array1.Intersect(array2).ToArray();//Нашел в документации

            Console.WriteLine("Список общих элементов:");
            foreach (int element in commonElements)            
                Console.Write(element + "");

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Min, Max в 2-мерном массиве");
            int[,] array2D = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)                
                    array2D[i, j] = random.Next(50);                
            }

            int min = 0;
            int max = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array2D[i, j] < min)                    
                        min = array2D[i, j];
                    
                    if (array2D[i, j] > max)                    
                        max = array2D[i, j];                    
                }
            }

            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Максимальное значение: {max}");

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Слова в предложении");
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            // Разделить предложение на слова
            string[] words = sentence.Split(' ');

            // Подсчитать количество слов
            count = words.Length;

            // Вывести результат
            Console.WriteLine($"Количество слов в предложении: {count}");

        }
    }
}
