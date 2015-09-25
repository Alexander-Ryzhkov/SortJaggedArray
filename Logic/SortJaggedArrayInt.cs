using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class SortJaggedArrayInt
    {
        public delegate int Comparer(int[] array1, int[] array2);



        public static int CompareBySum(int[] array1, int[] array2)
        {
            checked
            {
                return array1.Sum() - array2.Sum();
            }
        }
        public static int CompareByMax(int[] array1, int[] array2)
        {
            checked
            {
                return array1.Max() - array2.Max();
            }
        }
        public static int CompareByMin(int[] array1, int[] array2)
        {
            checked
            {
                return array1.Min() - array2.Min();
            }
        }


        
        public static void SortDescending(int[][] jaggedArray, Comparer comparer)
        {
            
            if (jaggedArray == null) throw new ArgumentNullException("jaggedArray");
            if (comparer == null) throw new ArgumentNullException("comparer");
            if (jaggedArray.Length == 0) throw new ArgumentException("jaggedArray is empty");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                if (jaggedArray[i] == null) throw new ArgumentException(string.Format("inner array {0} is null", i));
                if (jaggedArray[i].Length == 0) throw new ArgumentException(string.Format("inner array {0} is empty", i));
            }


            for (int k = 0; k < jaggedArray.Length - 1; k++)
            {
                for (int i = 0; i < jaggedArray.Length - 1; i++)
                {
                    if (comparer(jaggedArray[i], jaggedArray[i + 1]) < 0)
                        Swap(ref jaggedArray[i], ref jaggedArray[i + 1]);
                }
            }

        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }



    }
}
