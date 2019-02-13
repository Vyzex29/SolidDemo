using NUnit.Framework;

namespace OpenClosed.Before
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void CustomerType_TotalSales_Is1_returnWithDiscount()
        {
            // Arrange
            var customer = new Customer {CustomerType = 1};

            // Act
            var result = customer.GetDiscount(100);
            // Assert
            Assert.That(result == 0);
        }
        [Test]
        public void CustomerType_TotalSales_Is0_returnWithDiscount()
        {
            // Arrange
            var customer = new Customer { CustomerType = 0 };

            // Act
            var result = customer.GetDiscount(100);
            // Assert
            Assert.That(result == 50);
        }
    }
}
