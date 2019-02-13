namespace InterfaceSegregation.Before
{
    class CustomerwithRead : IDatabase
    {

        public void Add()
        {
            Customer obj = new Customer();
            obj.Add();
        }

        public void Read()
        {
            // implement read
        }
    }
}
