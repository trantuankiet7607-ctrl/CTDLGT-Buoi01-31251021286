using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1.ss1
{
    public class bai_1
    {
        static void Main()
        {
            static void bai1(int a, int b, int c)
            {
                int max = a;
                int min = a;
                if(b > a &&  a > c )
                {
                    max = b;
                    min = c;
                }
                else if (a > b && b > c)
                {
                    min = c;

                }
                else if ( c > a && a> b)
                {
                    max = c;
                    min = b;
                }
                else if (a > c && c > b)
                {
                    min = b;
                }
                else if (b > c && c > a)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
                float avg = (a + b + c) / 3f;
                Console.WriteLine($"max trong 3 so la: {max}");
                Console.WriteLine($"min trong 3 so la: {min}");
                Console.WriteLine($"Tong cua 3 so la: {a + b + c}");
                Console.WriteLine($"Trung binh 3 so la {avg:F2}");
            }
            //bai1(-5,-2,-9);
            static void bai2(int n)
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
            //bai2(5);
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
}
