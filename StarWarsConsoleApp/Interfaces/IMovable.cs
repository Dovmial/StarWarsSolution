using System.Numerics;

namespace StarWarsConsoleApp.Interfaces
{
    public interface IMovable
    {
        /// <summary>
        /// кординаты в пространстве
        /// </summary>
        Vector3 Position { get; set; }

        /// <summary>
        /// Скорость по каждой координате
        /// </summary>
        Vector3 Velocity { get; }
    }

}
