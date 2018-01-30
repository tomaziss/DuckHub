using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HomeworkSecond.Tests
{
    [TestClass]
    public class ArraySorterTests
    {
        [TestMethod]
        [DataRow(new[] { 1, 1, 2, 6, 82, 854, 5, 81, 5, 2, 5, 4 }, new[] { 1, 1, 2, 2, 4, 5, 5, 5, 6, 81, 82, 854 })]
        [DataRow(new[] { 3, 1, 2 }, new[] { 1, 2, 3 })]
        [DataRow(new[] { 2, 2, 1 }, new[] { 1, 2, 2 })]
        [DataRow(new[] { 2 }, new[] { 2 })]
        [DataRow(new int[] { }, new int[] { })]
        public void GivenArrayIsInitialized_WhenItContainsUnorderedIntElements_ThenItIsAscSorted(int[] given, int[] expected)
        {
            // Assert.
            var sut = new ArraySorter();
            // Act.
            var actual = sut.SortArrayAsc(given);
            // Assert.
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        [DataRow(new[] { 1, 1, 2, 6, 82, 854, 5, 81, 5, 2, 5, 4 }, new[] { 854, 82, 81, 6, 5, 5, 5, 4, 2, 2, 1, 1, })]
        [DataRow(new[] { 3, 1, 2 }, new[] { 3, 2, 1 })]
        [DataRow(new[] { 2, 2, 3 }, new[] { 3, 2, 2 })]
        [DataRow(new[] { 2 }, new[] { 2 })]
        [DataRow(new int[] { }, new int[] { })]
        public void GivenArrayIsInitialized_WhenItContainsUnorderedIntElements_ThenItIsDescSorted(int[] given, int[] expected)
        {
            // Assert.
            var sut = new ArraySorter();
            // Act.
            var actual = sut.SortArrayDesc(given);
            // Assert.
            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}
