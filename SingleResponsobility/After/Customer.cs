using System;

namespace SingleResponsobility.After
{
    public class Customer
    {
        private FileLogger obj = new FileLogger();
        public void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                obj.Handle(ex.ToString());
            }
        }
    }
}
