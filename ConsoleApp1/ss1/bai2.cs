using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ss1
{
   public class bai2
    {
        static void bai_2(int n)
        {
            if (n > 2 && n < 100000)
            {
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
                    a[i] = int.Parse(Console.ReadLine());

                }
                int max1 = a[0];
                int max2 = a[0];
                bool c = false;


                for (int j = 1; j < n; j++)
                {
                    if (a[j] > max1)
                    {

                        max2 = max1;
                        max1 = a[j];
                        c = true;
                    }
                    else if (a[j] < max1)
                    {

                        if (!c || a[j] > max2)
                        {
                            max2 = a[j];
                            c = true;
                        }
                    }
                }

                if (c)
                {
                    Console.WriteLine($"{max1} {max2}");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }

        }
    }
}
