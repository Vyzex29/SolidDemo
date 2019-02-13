using System;

namespace DependencyInversion.Before
{
    public class Customer
    {
        private ILogger logger;
        public virtual void Add(int Exhandle)
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                if (Exhandle == 1)
                {
                    logger = new FileLogger();
                }
                else
                {
                    logger = new EmailLogger();
                }
                logger.Handle(ex.Message.ToString());
            }
        }
    }
}
