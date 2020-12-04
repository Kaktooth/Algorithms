using System;

namespace ConsoleApp80
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array =new int[N];
            array =Array.ConvertAll(Console.ReadLine().Trim().Split(),int.Parse);
            int[] result=new int[N];
           MergeSort(ref array,0,array.Length-1);
          for (int i = 0; i < N; i++)
          {
              Console.WriteLine(array[i]);
          }
             

        }
      
        public static void MergeSort(ref int[] array,int left,int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(ref array, left, mid);
                MergeSort(ref array, mid + 1, right);
                Merge(ref array, left, mid, right);
            }

        }
        private static void Merge(ref int[] array, int left, int mid, int right)
        {
            int i, j, k;
            int start = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[start];
            int[] R = new int[n2];

            for (i = 0; i < start; i++)
                L[i] = array[left + i];

            for (j = 0; j < n2; j++)
                R[j] = array[mid + 1 + j];

            i = 0;
            j = 0;
            k = left;

            while (i < start && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i <start)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
	}
    
}
