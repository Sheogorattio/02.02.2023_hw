using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02._2023_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            {
                Random r = new Random();
                int[] arr = new int[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(0, 100);
                }
                foreach (var i in arr)
                {
                    Console.Write($"{i}\t");
                }
                Console.WriteLine();
                int temp = 1;
                foreach (var i in arr)
                {
                    if (i % 2 == 1 && i > temp)
                    {
                        temp = i;
                    }
                }
                Console.WriteLine(temp);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (temp == arr[i])
                    {
                        temp = i;//index inside of temp
                        temp++;//first element of the right part
                        break;
                    }
                }
                int first_elem = arr[temp];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = temp; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Length - 1] = first_elem;
                    first_elem = arr[temp];
                }
                foreach (var i in arr)
                {
                    Console.Write($"{i}\t");
                }
            }
            #endregion
            #region task 2
            {
                int indexZeroF = 0, indexZeroS = 0, sum = 0;
                int[] arr = new int[10];
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(-5, 6);
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {
                        indexZeroF = i;
                        break;
                    }
                }
                for (int i = indexZeroF + 1; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {
                        indexZeroS = i;
                        break;
                    }
                }
                if (indexZeroS != 0)
                {
                    for (int i = indexZeroF; i < indexZeroS; i++)
                    {
                        sum += arr[i];
                    }
                }
                Console.WriteLine(sum);
            }
            #endregion
            #region 3
            {
                int[] arr = new int[15];
                Random r = new Random();
                for(int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(-3,5);
                    Console.Write($"{arr[i]}\t");
                }
                Console.WriteLine();
                Console.WriteLine("Subset elements number is 3. In total 15 elements.");
                Console.WriteLine("Enter number");
                int targetSum = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < arr.Length-2; i += 3)
                {
                    if (arr[i] + arr[i + 1] + arr[i+2] == targetSum)
                    {
                        Console.WriteLine($"{arr[i]}\t{arr[i + 1]}\t{arr[i + 2]}");
                    }
                }
            }
            #endregion
            Console.WriteLine("ok, the end");
            Console.Read();
        }
    }
}
