using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HomeworkFirst.Tests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        [DataRow(new[] { 1, 5, 6, 8, 1, 6, 3, 5, 1, 2, 5 }, 5, 1)]
        [DataRow(new int[] { }, 5, -1)]
        [DataRow(new[] { 3, 2, 1 }, 5, -1)]
        [DataRow(new[] { 1, 7, 7 }, 7, 1)]
        [DataRow(new[] { 1, 7, 7, 8, 3 }, 3, 4)]
        public void Should_return_index_of_first_occurrence(int[] values, int number, int expectedIndex)
        {
            var actual = Program.FirstIntegerIndex(values, number);

            Assert.AreEqual(expectedIndex, actual);
        }

        [TestMethod]
        [DataRow(new[] { 1, 5, 6, 8, 1, 6, 3, 5, 1, 2, 5 }, 6, 5)]
        [DataRow(new[] { 1, 5, 6, 8, 1, 6, 3, 5, 1, 2, 5 }, 5, 10)]
        [DataRow(new[] { 1, 5, 6, 8, 1, 6, 3, 5, 1, 2, 5 }, 47, -1)]
        [DataRow(new int[] { }, 5, -1)]
        [DataRow(new int[] { 1, 2, 6 }, 5, -1)]
        [DataRow(new[] { 1, 1, 1 }, 1, 2)]
        [DataRow(new[] { 1, 3, 1 }, 3, 1)]
        public void Should_return_index_of_last_occurrence(int[] values, int number, int expectedIndex)
        {
            var actual = Program.LastIntegerIndex(values, number);

            Assert.AreEqual(expectedIndex, actual);
        }
    }
}
