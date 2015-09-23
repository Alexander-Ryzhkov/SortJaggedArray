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
            SortJaggedArrayInt.SortDescendingByMinElement(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortDescendingByMinElement_ArgumentException()
        {

            SortJaggedArrayInt.SortDescendingByMinElement(new int[][] { });
        }
        /*
        [TestMethod]
        public void SortDescendingByMinElement_OneArray()
        {
            int[][] arrange = {
                                  new int[] {1},
                                  new int[] {5, -8}
                              };
            int[][] act = arrange;
            SortJaggedArrayInt.SortDescendingByMinElement(act);
            System.Console.WriteLine(act[0][0]);
            Assert.AreEqual(arrange, act);
        }
         */
    }
}
