namespace DependencyInversion.Before
{
    public class FileLogger: ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
}
