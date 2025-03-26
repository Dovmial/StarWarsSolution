

namespace StarWarsConsoleApp.Interfaces
{
    public interface IUObject
    {
        public string Id { get; }
        object GetValue(string key);
        void SetValue(string key, object value);
    }
}
