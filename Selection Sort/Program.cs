/*
    #Given an unsorted array of integer values, a
selection sort visits each element of the
array
    #As it visits an element, it employs a second
index to scan the array from the present
location to the end while it identifies the
least (smallest) value in that segment of
the array
    #It then swaps that least value with the
current value.
    #Because one index scans the array once
while another index scans part of the
array each time, this sort algorithm is
O(n2).

*/
using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i,num_element, min_index,temp;
            Console.Write("Number of elements to be sorted: ");
            num_element = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[num_element];
            Console.Write("Enter the values: ");
            for (i = 0; i < num_element; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Unsorted Values: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //Selection Sorting
            for(i = 0; i < num_element - 1; i++){
                min_index = i;
                for (int j = i + 1; j < num_element; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                   
                }
                if (min_index != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min_index];
                    arr[min_index] = temp;
                }
            }
             Console.Write("\n");
            Console.Write("Sorted Values: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
