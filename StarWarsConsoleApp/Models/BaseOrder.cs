

using StarWarsConsoleApp.Interfaces;
using System.Numerics;

namespace StarWarsConsoleApp.Models
{
    public class BaseOrder : UObject
    {
        /// <summary>
        /// Id from ordered object
        /// </summary>
        public string ObjectId { get; set; } = null!;

        /// <summary>
        /// код операции
        /// </summary>
        public string Action { get; set; } = null!;
    }
}
