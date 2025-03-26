using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsConsoleApp.Models
{
    public class OrderMove(Vector3 velocity): BaseOrder
    {
        public Vector3 Velocity { get; } = velocity;
    }
}
