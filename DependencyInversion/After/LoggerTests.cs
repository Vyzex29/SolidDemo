using DependencyInversion.Before;
using NUnit.Framework;

namespace DependencyInversion.After
{
    public class LoggerTests
    {
        [Test]
        public void LoggerDemo()
        {
            var customer = new Customer(new EmailLogger());
            customer.Add();
            customer = new Customer(new EventViewerLogger());
            customer.Add();
            customer = new Customer(new FileLogger());
            customer.Add();
        }
    }
}
