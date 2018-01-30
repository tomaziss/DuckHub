using System;

namespace HomeworkSecond
{
    public class ArraySorter
    {
        // TODO : Sort array ascending order. Use loop of your choice.
        public int[] SortArrayAsc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++){
                for (int j = 0; j < arr.Length - (i + 1); j++) {
                    if (arr[j] > arr[j+1]){
                        Swap(arr, j, j + 1);
                    }
                        
                }
            }
            return arr;

        }
        // TODO : Sort array descending order. Use loop of your choice.
        public int[] SortArrayDesc(int[] arr)
        {
            // TODO: Delete following line before implementing.
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - (i+ 1); j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }

                }
            }
            return arr;

        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


    }
}

//4 3 2 1
