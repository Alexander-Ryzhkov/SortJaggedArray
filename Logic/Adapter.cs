using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Adapter : IComparer<int[]>
    {
        private Logic.SortJaggedArrayInt.Comparer cmp;

        public Adapter(Logic.SortJaggedArrayInt.Comparer cmp)
        {
            this.cmp = cmp;
        }

        public int Compare(int[] x, int[] y)
        {
            return cmp(x, y);
        }
    }
}
