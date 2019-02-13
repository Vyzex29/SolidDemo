namespace InterfaceSegregation.After
{
    public class CustomerWithRead : IDatabase, IDatabaseV1
    {

        public void Add()
        {
            Customer obj = new Customer();
            obj.Add();
        }

        public void Read()
        {
            // Implement read function
        }
    }

}
