namespace InterfaceSegregation.Before
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

        public void Read()
        {
            throw new System.NotImplementedException();
        }
    }
}
