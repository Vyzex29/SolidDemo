using NUnit.Framework;

namespace DependencyInversion.Before
{
    [TestFixture]
    public class LoggerTests
    {
        [Test]
        public void LoggerDemo()
        {
            var customer = new Customer();
            customer.Add(1);
        }
    }
}
