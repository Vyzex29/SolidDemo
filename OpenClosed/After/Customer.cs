namespace OpenClosed.After
{
    public class Customer
    {
        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }
    }

    public class SilverCustomer : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 50;
        }
    }

    public class GoldCustomer : SilverCustomer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 100;
        }
    }
}
