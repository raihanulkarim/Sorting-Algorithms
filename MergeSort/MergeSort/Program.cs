using System;

namespace MergeSort
{
    public class Program
    {
        public static void sorting(int[] nums, int left, int right)
        {
            int mid;
            if(left < right) {
                mid = (left + right) / 2;
                sorting(nums, left, mid);
                sorting(nums, mid + 1, right);
                merge(nums, left, mid, right);
            } 
        } 
        public static void merge(int[] nums, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = 0;
            int[] temp = new int[nums.Length];
            while(i <= mid && j <= right)
            {
                if(nums[i] < nums[j])
                {
                    temp[k++] = nums[i++];
                }
                else
                {
                    temp[k++] = nums[j++];
                }
            }
            while(i <= mid)
            {
                temp[k++] = nums[i++];
            }
            while (j <= right)
            {
                temp[k++] = nums[j++];
            }
            for(i = left,j=0; i <= right; i++, j++)
            {
                nums[i] = temp[j];
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 10,50, 2, 3, 4, 5, 6, 7 };
            sorting(arr, 0, arr.Length - 1);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
