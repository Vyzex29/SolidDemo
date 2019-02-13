namespace DependencyInversion.Before
{
    public class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }
}
