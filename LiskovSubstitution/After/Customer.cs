namespace LiskovSubstitution.After
{
    public class Customer :IDatabase, IDiscount
    {
        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }

        public virtual void Add()
        {
            // Database code goes here
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
