using System;

namespace Move_zero_To_End
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 0, 3, 0, 0, 4, 0 };
            MoveZero(arr);
            Console.WriteLine(string.Join(",",arr));
        }

        public static void MoveZero(int[] arr)
        {
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    Swap(arr, i, j);
                    j++;
                }
            }
        } 

        public static void Swap(int[] arr,int i,int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}
