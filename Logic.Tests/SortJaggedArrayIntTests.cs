using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logic.Tests
{
    [TestClass]
    public class SortJaggedArrayIntTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortDescendingByMinElement_NullReference()
        {
            int[][] act = null;
            SortJaggedArrayInt.SortDescendingByMinElement(act);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortDescendingByMinElement_ArgumentException()
        {
            int[][] act = new int[][] { };
            SortJaggedArrayInt.SortDescendingByMinElement(act);
        }

        [TestMethod]
        public void SortDescendingByMinElement_SimpleArray()
        {
            int[][] arrange =
            {
                new int[] {1, -1},
                new int[] {5, -8}
            };
            int[][] act = 
            {
                new int[] {5, -8},
                new int[] {1, -1}
            };
            SortJaggedArrayInt.SortDescendingByMinElement(act);
            for (int i = 0; i < arrange.Length; i++)
            {
                CollectionAssert.AreEqual(arrange[i], act[i]);
            }
        }
         
    }
}
