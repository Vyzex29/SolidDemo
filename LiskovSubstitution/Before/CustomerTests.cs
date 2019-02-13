using System.Collections.Generic;
using NUnit.Framework;

namespace LiskovSubstitution.Before
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void CustomerAddListTest()
        {
            List<Customer> customers = new List<Customer> {new SilverCustomer(), new GoldCustomer(), new Enquiry()};

            foreach (Customer o in customers)
            {
                o.Add();
            }
        }
    }
}

