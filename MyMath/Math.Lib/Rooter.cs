namespace Math.Lib
{
    public class Rooter
    {
        public double SquareRoot(double input)
        {
            double result = input;
            double previousResult = -input;
            while (System.Math.Abs(previousResult - result)
                > result / 1000)
            {
            previousResult = result;
            result = result - (result * result - input) / (2 * result);
            }
            return result;
        }
    }
}