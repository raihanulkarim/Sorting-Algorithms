using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItem, temp, i;
            Console.Write("Number of Items:");
            numberOfItem = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[numberOfItem];

            Console.Write("Enter Values:");
            for (i = 0; i < numberOfItem; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Unsorted Values:");
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
             //Bubble Sorting
            for ( i = 0; i < numberOfItem-1; i++)
            {
                for (int j = 0; j < numberOfItem-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            Console.Write("Sorted Values:");
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
           
        }
    }
}
