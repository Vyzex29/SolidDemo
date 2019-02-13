using System;
using DependencyInversion.Before;

namespace DependencyInversion.After
{
    public class Customer
    {
        private readonly ILogger _logger;

        public Customer(ILogger logger)
        {
            _logger = logger;
        }
        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                _logger.Handle(ex.Message.ToString());
            }
        }
    }

}
