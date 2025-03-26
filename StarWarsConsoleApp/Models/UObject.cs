using StarWarsConsoleApp.Interfaces;
namespace StarWarsConsoleApp.Models
{
    public class UObject : IUObject
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public object GetValue(string key)
            => GetType().GetProperty(key)!.GetValue(this)!;

        public void SetValue(string key, object value) 
            => GetType().GetProperty(key)!.SetValue(this, value);
    }
}
