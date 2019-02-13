namespace DependencyInversion.Before
{
    public class EventViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // Log errors to a event viewer
        }
    }
}
