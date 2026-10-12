using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ss1
{
    public class bai_3
    {
        static void bai3a(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());

            }
            int maxsum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currentsum = 0;
                for (int j = i; j < n; j++)
                {
                    currentsum += a[j];
                    if (currentsum > maxsum) maxsum = currentsum;
                }
            }
        }
        static void bai3b(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());

            }
            int maxsum = a[0];
            int currentsum = a[0];
            for (int i = 1; i < n; i++)
            {
                currentsum = Math.Max(a[i], currentsum + a[i]);
                maxsum = Math.Max(maxsum, currentsum);
            }
        }
    }
}
