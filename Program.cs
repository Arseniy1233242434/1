using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_19_
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {
                int a, b, a1 = 0;
                int k1 = 0, k2 = 0, sum1 = 1;
                Console.WriteLine("введите а");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("введите b");
                b = int.Parse(Console.ReadLine());
                int[,] arr = new int[5, 5];
                Random rn = new Random();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = rn.Next(-10, 10);
                        Console.Write(arr[i, j] + " ");

                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] % a == 0 || arr[i, j] % b == 0)
                            a1++;

                    }
                }
                Console.WriteLine("кол-во элементов кратных а или b=" + a1);
                while (true)
                {
                    Console.WriteLine("введите k1");
                    k1 = int.Parse(Console.ReadLine());
                    if (k1 >= 0 || k1 <= arr.GetLength(1) - 1)
                    {
                        Console.WriteLine("неверные данные");
                    }
                    else
                        break;
                }
                while (true)
                {
                    Console.WriteLine("введите k2");
                    k2 = int.Parse(Console.ReadLine());
                    if (k2 > 0 && k2 <= arr.GetLength(1))
                    {
                        Console.WriteLine("неверные данные");
                    }
                    else
                        break;
                }
                for (int i = k1; i < k2; i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[j, i] < 0)
                            sum1 *= arr[j, i];

                    }
                }
                Console.WriteLine("сумма отрицательных элементов в столбцах с" + k1 + " по " + k2 + "=" + sum1);
                Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("некоректные данные");
            }


        }
    }
}
