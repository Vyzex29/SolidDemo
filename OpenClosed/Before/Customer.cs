namespace OpenClosed.Before
{
    public class Customer
    {
        public int CustomerType { get; set; }

        public double GetDiscount(double totalSales)
        {
            if (CustomerType == 1)
            {
                return totalSales - 100;
            }
            else
            {
                return totalSales - 50;
            }
        }
    }
}
