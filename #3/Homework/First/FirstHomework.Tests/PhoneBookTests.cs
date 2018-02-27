using FirstHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class PhoneBookTests
    {
        [TestMethod]
        public void AddsViaCtor()
        {
            // Arrange
            var data = new[] { new PhoneBookEntry("G", 45646546), new PhoneBookEntry("GTG", 49874465), new PhoneBookEntry("ASG", 3333333), new PhoneBookEntry("bnn", 4548), new PhoneBookEntry("OPoah", 98798454) };
            // Act
            var sut = new PhoneBook(data);
            // Assert
            Assert.IsTrue(data.All(x =>
            {
                var value = sut.Addresses[x.Name];
                return value == x.Number;
            }));
        }

        [TestMethod]
        public void Adds()
        {
            // Arrange
            var sut = new PhoneBook(new PhoneBookEntry[0]);
            // Act
            var data = new PhoneBookEntry("JkHASD", 45654654);
            sut.Add(data);
            // Assert
            Assert.IsTrue(sut.Addresses.Count() == 1 && sut.Addresses[data.Name] == data.Number);
        }

        [TestMethod]
        public void Removes()
        {
            // Arrange
            var data = new[] { new PhoneBookEntry("G", 45646546), new PhoneBookEntry("GTG", 49874465), new PhoneBookEntry("ASG", 3333333), new PhoneBookEntry("bnn", 4548), new PhoneBookEntry("OPoah", 98798454) };
            var sut = new PhoneBook(data);
            // Act
            var result = sut.Remove(data.First().Name);
            // Assert
            Assert.IsTrue(sut.Addresses.Count() == (data.Length - 1) && result);
        }



        [TestMethod]
        public void Updates()
        {
            // Arrange
            var sut = new PhoneBook(new PhoneBookEntry[0]);
            // Act
            var data = new PhoneBookEntry("JkHASD", 45654654);
            sut.Add(data);
            var updated = new PhoneBookEntry("JkHASD", 5444);
            sut.Update(updated);
            // Assert
            Assert.IsTrue(sut.Addresses.Single().Value == 5444);
        }


        [TestMethod]
        public void UpdatesError()
        {
            // Arrange
            var sut = new PhoneBook(new PhoneBookEntry[0]);
            // Act
            var data = new PhoneBookEntry("JkHASD", 45654654);
            sut.Add(data);
            var updated = new PhoneBookEntry("asdasd", 5444);
            sut.Update(updated);
            // Assert
            Assert.IsFalse(sut.Update(updated));
        }

        [TestMethod]
        public void DialsWorks()
        {
            // Arrange
            var data = new[] { new PhoneBookEntry("G", 45646546), new PhoneBookEntry("GTG", 49874465), new PhoneBookEntry("ASG", 3333333) };
            // Act
            var sut = new PhoneBook(data);

            var result = sut.Dial(data.Last().Name);
            // Assert
            Assert.IsTrue(result == data.Last().Number);
        }

        [TestMethod]
        public void DialsFails()
        {
            // Arrange
            var data = new[] { new PhoneBookEntry("G", 45646546), new PhoneBookEntry("GTG", 49874465), new PhoneBookEntry("ASG", 3333333) };
            // Act
            var sut = new PhoneBook(data);

            var result = sut.Dial("asds");
            // Assert
            Assert.IsTrue(result == -1);
        }


        [TestMethod]
        public void NamesWork()
        {
            // Arrange
            var data = new[] { new PhoneBookEntry("G", 45646546), new PhoneBookEntry("GTG", 3333333), new PhoneBookEntry("ASG", 3333333) };
            // Act
            var sut = new PhoneBook(data);

            var result = sut.Name(data.First().Number);
            // Assert
            Assert.IsTrue(result.Single() == data.First().Name);
        }


        [TestMethod]
        public void NamesWorkMultiple()
        {
            // Arrange
            var data = new[] { new PhoneBookEntry("G", 45646546), new PhoneBookEntry("GTG", 3333333), new PhoneBookEntry("ASG", 3333333) };
            // Act
            var sut = new PhoneBook(data);

            var result = sut.Name(data.Last().Number);
            // Assert
            Assert.IsTrue(result.Length == 2 && result.Contains(data[1].Name) && result.Contains(data[2].Name));
        }

    }
}
