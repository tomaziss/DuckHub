using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LetsQueue.Tests
{
    [TestClass]
    public class CoffeeShopTests
    {
        [TestMethod]
        public void Ctor1()
        {
            // Arrange
            var data = new[] { new Coffee("Espresso"), new Coffee("Espresso"), new Coffee("Royal"), new Coffee("Royal"), new Coffee("Espresso"), new Coffee("Tasty"), new Coffee("Mocha"), };
            var sut = new CoffeeShop(data);
            // Act
            // Assert
            Assert.IsTrue(data.GroupBy(x => x).All(x => x.Count() == data.Count(c => c.Equals(x.First()))));
        }
        [TestMethod]
        public void Ctor2()
        {
            // Arrange
            var data = new[] { new Coffee("Espresso"), new Coffee("Espresso"), new Coffee("Royal"), new Coffee("Royal"), new Coffee("Espresso"), new Coffee("Tasty"), new Coffee("Mocha"), };
            var sut = new CoffeeShop(data, 4);
            // Act
            // Assert
            Assert.IsTrue(data.GroupBy(x => x).All(x => x.Count() == data.Count(c => c.Equals(x.First()))));
            Assert.IsTrue(sut.CustomersInQueue.Count == 4);
        }

        [TestMethod]
        public void AddCustomer()
        {
            // Arrange
            var data = new[] { new Coffee("Espresso"), new Coffee("Espresso"), new Coffee("Royal"), new Coffee("Royal"), new Coffee("Espresso"), new Coffee("Tasty"), new Coffee("Mocha"), };
            var sut = new CoffeeShop(data, 4);
            // Act
            sut.AddCustomer();
            Assert.IsTrue(sut.CustomersInQueue.Count == 5);
            sut.AddCustomer();
            // Assert
            Assert.IsTrue(data.GroupBy(x => x).All(x => x.Count() == data.Count(c => c.Equals(x.First()))));
            Assert.IsTrue(sut.CustomersInQueue.Count == 6);
            Assert.IsTrue(sut.NextTicket == 7);
            Assert.IsTrue(sut.NextTicket == 7);
        }

        [TestMethod]
        public void ServeCoffeeTest()
        {
            // Arrange
            var data = new[] { new Coffee("Espresso"), new Coffee("Espresso"), new Coffee("Royal"), new Coffee("Royal"), new Coffee("Espresso"), new Coffee("Tasty"), new Coffee("Mocha"), };
            var sut = new CoffeeShop(data, 4);
            // Act
            Assert.IsTrue(sut.ServeCustomer(new Coffee("Espresso")));
            Assert.IsFalse(sut.ServeCustomer(new Coffee("Random")));
            Assert.IsTrue(sut.CoffeesServed == 1);
            Assert.IsTrue(sut.CustomersServed == 1);
            Assert.IsTrue(sut.ServeCustomer(new Coffee("Royal")));
            Assert.IsTrue(sut.CoffeesServed == 2);
            Assert.IsTrue(sut.CustomersServed == 2);
            // Assert
            Assert.IsTrue(data.GroupBy(x => x).All(x => x.Count() == data.Count(c => c.Equals(x.First()))));
            Assert.IsTrue(sut.CustomersInQueue.Count == 2);
            Assert.IsTrue(sut.NextTicket == 5);
            Assert.IsTrue(sut.CoffeesReadyToServe[new Coffee("Espresso")] == 2);
            Assert.IsTrue(sut.CoffeesReadyToServe[new Coffee("Royal")] == 1);
        }

        [TestMethod]
        public void AddCoffee()
        {
            // Arrange
            var data = new[] { new Coffee("Espresso"), new Coffee("Espresso"), new Coffee("Royal"), new Coffee("Royal"), new Coffee("Espresso"), new Coffee("Tasty"), new Coffee("Mocha"), };
            var sut = new CoffeeShop(data, 4);
            // Act
            Assert.IsTrue(sut.AddCoffee(new Coffee("Random")));
            Assert.IsTrue(sut.AddCoffee(new Coffee("Random")));
            // Assert
            Assert.IsTrue(sut.CoffeesReadyToServe[new Coffee("Random")] == 2);
            Assert.IsTrue(sut.CoffeesServed == 0);
        }

        [TestMethod]
        public void RemoveCoffee()
        {
            // Arrange
            var data = new[] { new Coffee("Espresso"), new Coffee("Espresso"), new Coffee("Royal"), new Coffee("Royal"), new Coffee("Espresso"), new Coffee("Tasty"), new Coffee("Mocha"), };
            var sut = new CoffeeShop(data, 4);
            // Act
            Assert.IsTrue(sut.RemoveCoffee(new Coffee("Espresso")));
            Assert.IsTrue(sut.RemoveCoffee(new Coffee("Mocha")));
            // Assert
            Assert.IsTrue(sut.CoffeesReadyToServe[new Coffee("Espresso")] == 2);
            Assert.IsTrue(sut.CoffeesReadyToServe[new Coffee("Mocha")] == 0);
            Assert.IsTrue(sut.CoffeesServed == 0);
        }
    }
}
