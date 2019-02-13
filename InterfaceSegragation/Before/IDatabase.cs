namespace InterfaceSegregation.Before
{
    public interface IDatabase
    {
        void Add(); // old client are happy with these.
        void Read(); // Added for new clients.
    }
}
