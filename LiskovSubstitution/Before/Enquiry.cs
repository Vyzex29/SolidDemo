using System;

namespace LiskovSubstitution.Before
{
    public class Enquiry : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 5;
        }

        public override void Add()
        {
            throw new Exception("Not allowed");
        }
    }
}
