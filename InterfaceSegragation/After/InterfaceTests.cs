using NUnit.Framework;

namespace InterfaceSegregation.After
{
    [TestFixture]
    public class InterfaceTests
    {
        [Test]
        public  void InterfaceDemonstration()
        {
            IDatabase i = new Customer(); // 1000 happy old clients not touched
            i.Add();

            IDatabaseV1 iv1 = new CustomerWithRead(); // new clients
            iv1.Read();

            IDatabase customerWithRead = new CustomerWithRead(); // Can also act as an old one
        }
    }
}
