﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace integral
{
    class Program
    {
        static int prost(int a)
        {
            int[] b = new int[10000];
            b[0] = 2;
            b[1] = 3;
            b[2] = 5;
            int k = 3;
            int t = 0;
            while (b[k - 1] <= a)
            {
                for (int i = b[k - 1] + 1; true; i++)
                {
                    t = 0;
                    for (int j = 0; j < k; j++)
                        if (i % b[j] == 0) { t = 1; break; }
                    if (t != 1) { b[k] = i; k++; break; }
                }
            }
            return b[k - 1];
        }

        static double integsqrt(double a, double b)
        {
            double s1, s2;
            s1 = (a / 2) * Math.Sqrt(1 - a * a) + 0.5 * Math.Asin(a);
            s2 = (b / 2) * Math.Sqrt(1 - b * b) + 0.5 * Math.Asin(b);
            return s1 - s2;
        }
        static double sortirovka(double[] a, double n)
        {
            double k;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        k = a[j];
                        a[j] = a[i];
                        a[i] = k;
                    }
            return 0;
        }
        static string reverse(string str)
        {
            char[] dop;
            char simv;
            int i;
            dop = str.ToCharArray();
            for (i = 0; i < (dop.Length / 2); i++)
            {
                simv = dop[i];
                dop[i] = dop[dop.Length - i - 1];
                dop[dop.Length - i - 1] = simv;

            }
            str = new string(dop);
            return str;
        }
        static void Main(string[] args)
        {
            //Первое задание - расчет интеграла
            double a;
            a = integsqrt(1, -1);
            Console.WriteLine("Первая Задача Значение интеграла: " + a);
            Console.Write("\n\n\nВторая задача\n");
            //Второе задание - сортировка массива
            Console.Write("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите элементы массива(по одному элементу в каждой строке)\n");
            double[] a1 = new double[n];
            for (int i = 0; i < n; i++)
            {
                a1[i] = Convert.ToDouble(Console.ReadLine());
            }
            sortirovka(a1, n);
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a1[i] + " ");
            }
            // третье задание записать массив задом наперед
            Console.WriteLine("\n\n\nТретья задача\n");
            int l;
            Console.Write("Введите строку:\n ");
            Console.Write("\n");
            string s = Console.ReadLine();
            s=reverse(s);
            Console.WriteLine("\nПеревернутая строка: " + s );

            //четвертое задание
            Console.WriteLine("\n\n\nЧетвертая задача\n");
            int k;
            int r;
            Console.WriteLine("Введите ваше натуральное число..");
            k = Convert.ToInt32(Console.ReadLine());
            r = prost(k);
            Console.Write("Первое простое число больше вашего равно=");
            Console.Write(r);
            Console.WriteLine();
            
        }



    }
}
    

