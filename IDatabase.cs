namespace Databases
{
    public interface IDatabase
    {
        string Query(string key);
        void Update(string key, string value);
    }
}