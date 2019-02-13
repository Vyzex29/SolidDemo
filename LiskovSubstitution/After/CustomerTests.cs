using System.Collections.Generic;
using LiskovSubstitution.Before;
using NUnit.Framework;

namespace LiskovSubstitution.After
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void IDatabaseAddListTest()
        {
            List<IDatabase> customers = new List<IDatabase> { new SilverCustomer(), new GoldCustomer(), new Enquiry() };

            foreach (IDatabase o in customers)
            {
                o.Add();
            }
        }
    }
}
