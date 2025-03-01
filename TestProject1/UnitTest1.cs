using StarWarsConsoleApp.Models;
using StarWarsConsoleApp.Commands;
using System.Numerics;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(12, 5, 0, -7, 3, 0)]
        public void Test1(float x, float y, float z, float vx, float vy, float vz)
        {
            Spaceship spaceship = new Spaceship()
            {
                Position = new(x,y,z),
                Velocity = new(vx,vy,vz)
            };
            Move moveSpaceship = new(spaceship);
            moveSpaceship.Execute();
            Assert.Equal(new Vector3(5, 8, 0), spaceship.Position);
        }
    }
}
