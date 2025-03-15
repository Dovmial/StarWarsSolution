using SquareEquation;

namespace TestSquareEquation
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1.0, 0, 1.0)]
        public void TestResolveRootsNone(double a, double b, double c)
        {
            var result = SquareEquationHandler.Solve(a, b, c);
            Assert.Empty(result);
        }

        [Theory]
        [InlineData(1.0, 0, -1.0)]
        public void TestResolveRootsTwo(double a, double b, double c)
        {
            double[] result = SquareEquationHandler.Solve(a, b, c);
            Assert.Contains(1.0, result);
            Assert.Contains(-1.0, result);
        }

        [Theory]
        [InlineData(1.0,2.0,1.0)]
        public void TestResolveRootsOne(double a, double b, double c)
        {
            double[] result = SquareEquationHandler.Solve(a, b, c);
            Assert.Contains(-1.0, result);
        }

        [Theory]
        [InlineData(0, 1.0, 1.0)]
        public void TestResolveANotZero(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => SquareEquationHandler.Solve(a,b,c));
        }
    }
}
