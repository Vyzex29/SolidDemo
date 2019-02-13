using NUnit.Framework;

namespace OpenClosed.After
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void Customer_GetDiscount_returnsWithDiscount()
        {
            // Arrange
            var customer = new Customer ();

            // Act
            var result = customer.GetDiscount(100);
            // Assert
            Assert.That(result == 100);
        }
        [Test]
        public void SilverCustomer_GetDiscount_returnsWithDiscount()
        {
            // Arrange
            var customer = new SilverCustomer( );

            // Act
            var result = customer.GetDiscount(100);
            // Assert
            Assert.That(result == 50);
        }
        [Test]
        public void GoldCustomer_GetDiscount_returnsWithDiscount()
        {
            // Arrange
            var customer = new GoldCustomer();

            // Act
            var result = customer.GetDiscount(100);
            // Assert
            Assert.That(result == 0);
        }
    }
}
