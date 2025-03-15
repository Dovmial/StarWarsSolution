namespace SquareEquation
{
    public class SquareEquationHandler
    {
        public static double[] Solve(double a, double b, double c, double epsilon = 0.00000001)
        {
            if (Math.Abs(a) <= epsilon)
                throw new Exception("A mustnot be zero!");
            double D = b * b - 4.0 * a * c;
            double[] roots = new double[2];
            if (D < 0)
                return [];
            else if(D > epsilon)
            {
                roots[0] = (-b + Math.Sqrt(D)) / (2 * a);
                roots[1] = (-b - Math.Sqrt(D)) / (2 * a);
            }
            else if(Math.Abs(D) <= epsilon)
            {
                roots[0] = roots[1] = -b / (2 * a);
            }
            return roots;
        }
    }
}
