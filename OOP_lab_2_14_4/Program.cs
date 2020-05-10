﻿using System;

namespace OOP_lab_2_14_4
{
    public class Program
    {
        public static int Multiplication(int[] array)
        {
            int d = array[0];

            for (int i = 2; i < array.Length; i += 2)
            {
                d *= array[i];
            }

            return d;
        }

        private static int IndexMax(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] >= array[index])
                {
                    index = i;
                }
            }

            return index;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < IndexMax(array); ++i)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiр масиву");

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }

            Console.WriteLine("Добуток елементiв масиву з парними номерами: {0}", Multiplication(array));
            Console.WriteLine("Сума елементiв масиву, розташованих до максимального за модулем елемента: {0}", Sum(array));
        }
    }
}
