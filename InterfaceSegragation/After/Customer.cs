namespace InterfaceSegregation.After
{
    public class Customer : IDatabase
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

}
