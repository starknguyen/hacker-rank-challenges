using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Algorithm.CSharp.Algorithms
{
    internal sealed class QuickSort
    {
        private int partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right--;

                if (left >= right)
                {
                    return right;
                }
                else
                {
                    if (arr[left] == arr[right])
                        return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
            }
        }


        public void Sort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int pivot = this.partition(arr, left, right);
            if (pivot > 1)
            {
                Sort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Sort(arr, pivot + 1, right);
            }
        }
    }
}
