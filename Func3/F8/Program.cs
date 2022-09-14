// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите размер массива ");
            int N = int.Parse(Console.ReadLine());
            double[] Mass = new double[N];
 
            //Заполняем массив
 
            Console.WriteLine("Выберите ручной или автоматический вариант заполнения массива");
            Console.WriteLine(" 1 - Ручной ввод\n 2 - Автоматический ввод");
        swVVOD:
            int vvod = int.Parse(Console.ReadLine());
            switch (vvod)
            {
                case 1:
                    {
                        Console.Write("Введите элементы массива\n\n");
                        for (int i = 0; i < N; i++)
                        {
                            Mass[i] = double.Parse(Console.ReadLine());
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("\nИсходный массив\n\n");
                        for (int i = 0; i < N; i++)
                        {
                            Mass[i] = (double)(rnd.NextDouble() * rnd.Next(-5, 5));
                            Console.Write("{0} ", Mass[i]);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Нужно ввести 1 или 2!!!");
                        goto swVVOD;
                    }
            }
            //Console.Write("\nИсходный массив\n\n");
 
            //Вычисляем сумму элементов массива с нечетными номерами
 
            double nechetSum = 0;
            for (int i = 1; i < N; i += 2)
            {
                nechetSum += Mass[i];
            }
            Console.WriteLine("\n\nСумма нечетных элементов = {0}", nechetSum.ToString());
 
           
                            
        }
    }
}