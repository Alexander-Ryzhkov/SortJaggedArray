using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logic.Tests
{
    [TestClass]
    public class SortJaggedArrayIntTests
    {
        //
        //
        //  Testing SortJaggedArrayInt.SortDescending with different parameters
        //
        //
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortDescending_ArgumentNullException()
        {
            int[][] actArray = null;
            SortJaggedArrayInt.Comparer actComparison = null;
            SortJaggedArrayInt.SortDescending(actArray, actComparison);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortDescending_ArgumentException()
        {
            int[][] actArray = 
            { 
                new int[] {},
                new int[] {1, 2}
            };
            SortJaggedArrayInt.Comparer actComparison = SortJaggedArrayInt.CompareBySum;
            SortJaggedArrayInt.SortDescending(actArray, actComparison);
        }

        [TestMethod]
        public void SortDescending_SmallArray_CompareByMin()
        {
            int[][] arrange =
            {
                new int[] {1, -1, 0},
                new int[] {5, -8}
            };
            int[][] act = 
            {
                new int[] {5, -8},
                new int[] {1, -1, 0}
            };

            SortJaggedArrayInt.SortDescending(act, SortJaggedArrayInt.CompareByMin);
            for (int i = 0; i < arrange.Length; i++)
            {
                CollectionAssert.AreEqual(arrange[i], act[i]);
            }
        }

        [TestMethod]
        public void SortDescending_MediumArray_CompareByMax()
        {
            int[][] arrange =
            {
                new int[] {7, 8, 90, 909},
                new int[] {1, -1, 98},
                new int[] {-8, 19}
            };
            int[][] act = 
            {
                new int[] {1, -1, 98},
                new int[] {-8, 19},
                new int[] {7, 8, 90, 909}
            };

            SortJaggedArrayInt.SortDescending(act, SortJaggedArrayInt.CompareByMax);
            for (int i = 0; i < arrange.Length; i++)
            {
                CollectionAssert.AreEqual(arrange[i], act[i]);
            }
        }

        [TestMethod]
        public void SortDescending_LargeArray_CompareBySum()
        {
            int[][] arrange =
            {
                new int[] {int.MaxValue - 10, 10},
                new int[] {7, 8, 90, 909},
                new int[] {1, -1, 98},
                new int[] {-8, 19}
                
            };
            int[][] act = 
            {
                new int[] {1, -1, 98},
                new int[] {-8, 19},
                new int[] {int.MaxValue - 10, 10},
                new int[] {7, 8, 90, 909}
            };

            SortJaggedArrayInt.SortDescending(act, SortJaggedArrayInt.CompareBySum);
            for (int i = 0; i < arrange.Length; i++)
            {
                CollectionAssert.AreEqual(arrange[i], act[i]);
            }
        }


        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void SortDescending_SmallArray_CompareByMin_OverflowException()
        {
            int[][] act = 
            {
                new int[] {int.MinValue},
                new int[] {5, 8}
            };

            SortJaggedArrayInt.SortDescending(act, SortJaggedArrayInt.CompareByMin);
        }



        //
        //
        //  Testing Array.Sort
        //
        //
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Sort_ArgumentNullException()
        {
            int[][] actArray = null;
            Comparison<int[]> actComparison = null;
            Array.Sort(actArray, actComparison);
        }



        [TestMethod]
        public void Sort_SmallArray_CompareByMin()
        {
            int[][] arrange =
            {

                new int[] {5, -8},
                new int[] {1, -1}
                
            };
            int[][] act = 
            {
                new int[] {1, -1},
                new int[] {5, -8}
            };

            Array.Sort(act, SortJaggedArrayInt.CompareByMin);
            for (int i = 0; i < arrange.Length; i++)
            {
                CollectionAssert.AreEqual(arrange[i], act[i]);
            }
        }


        [TestMethod]
        public void Sort_MediumArray_CompareByMax()
        {
            int[][] arrange =
            {
                new int[] {-8, 19},
                new int[] {1, -1, 98},
                new int[] {7, 8, 90, 909}
            };
            int[][] act = 
            {
                new int[] {1, -1, 98},
                new int[] {-8, 19},
                new int[] {7, 8, 90, 909}
            };

            Array.Sort(act, SortJaggedArrayInt.CompareByMax);
            for (int i = 0; i < arrange.Length; i++)
            {
                CollectionAssert.AreEqual(arrange[i], act[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Sort_LargeArray_CompareBySum_InvalidOperationException()
        {
            int[][] act = 
            {
                new int[] {1, -1, 98},
                new int[] {-8, 19},
                new int[] {int.MaxValue, 10},
                new int[] {7, 8, 90, 909}
            };
            Array.Sort(act, SortJaggedArrayInt.CompareBySum);

        }

    }
}
