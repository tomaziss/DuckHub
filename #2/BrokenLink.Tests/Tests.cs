using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrokenLink.Tests
{
    [TestClass]
    public class QuackedListTests
    {
        [TestMethod]
        public void CanAddMember()
        {
            // Arrange
            var sut = new QuackedList();
            // Act
            sut.Add("Test");
            // Assert
            Assert.AreEqual(1, sut.Count);
        }

        [TestMethod]
        public void CanSetHeadElement()
        {
            // Arrange
            var sut = new QuackedList();
            var item = "Test";
            // Act
            sut.Add(item);
            // Assert
            Assert.AreEqual(item, sut.Head);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ThrowsOutOfIndex()
        {
            // Arrange
            var sut = new QuackedList();
            // Act
            // Assert
            var item = sut[0];
        }

        [TestMethod]
        public void RetrievesMembersByIndex()
        {
            var sut = new QuackedList();
            var item = "Test";
            // Act
            sut.Add(item);
            // Assert
            Assert.AreEqual(item, sut[0]);
        }

        [TestMethod]
        public void CanRemoveMember()
        {
            // Arrange
            var sut = new QuackedList();
            var item = "Test";
            // Act
            sut.Add(item);
            sut.Remove(item);
            // Assert
            Assert.AreEqual(0, sut.Count);
        }

        [TestMethod]
        public void CanRemoveMemberByIndex()
        {
            // Arrange
            var sut = new QuackedList();
            var item = "Test";
            // Act
            sut.Add(item);
            sut.RemoveAt(0);
            // Assert
            Assert.AreEqual(0, sut.Count);
        }

        [TestMethod]
        public void CanPrintEmptyList()
        {
            // Arrange
            var sut = new QuackedList();
            // Act
            // Assert
            Assert.AreEqual("", sut.ToString());
            Assert.AreEqual("", sut.ToStringReverse());
        }

        [TestMethod]
        public void SupportsNullValues()
        {
            // Arrange
            var sut = new QuackedList();
            sut.Add(null);
            // Act
            // Assert
            Assert.AreEqual("", sut.ToString());
            Assert.AreEqual("", sut.ToStringReverse());
        }

        [TestMethod]
        public void CanPrintMembers()
        {
            // Arrange
            var sut = new QuackedList();
            // Act
            sut.Add("1");
            sut.Add("2");
            sut.Add("3");
            sut.Add("5");
            sut.Add("7");
            // Assert
            Assert.AreEqual("1,2,3,5,7", sut.ToString());
        }

        [TestMethod]
        public void CanPrintMembersReverse()
        {
            // Arrange
            var sut = new QuackedList();
            // Act
            sut.Add("1");
            sut.Add("2");
            sut.Add("3");
            sut.Add("5");
            sut.Add("7");
            // Assert
            Assert.AreEqual("7,5,3,2,1", sut.ToStringReverse());
        }
    }
}
