using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class SortJaggedArrayInt
    {

        public static void SortDescendingByMinElement(int[][] jaggedArray)
        {

            if (jaggedArray == null) throw new ArgumentNullException("jaggedArray");
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
                    if (jaggedArray[i].Min() < jaggedArray[i + 1].Min())
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
