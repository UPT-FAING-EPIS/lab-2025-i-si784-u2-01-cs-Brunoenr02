namespace Math.Lib
{
    /// <summary>
    /// proporciona metodos para calcular raices cuadradas
    /// </summary>
    public class Rooter
    {
        /// <summary>
        /// calcula la raiz cuadrada de un numero positivo
        /// </summary>
        /// <param name="input">el numero del cual se desea obtener la raiz cuadrada, debe ser positivo</param>
        /// <returns>la raíz cuadrada aproximada del valor de entrada</returns>
        /// <exception cref="ArgumentOutOfRangeException">se lanza si el numero es negativo o cero</exception>
        public double SquareRoot(double input)
        {
            if (input <= 0.0) throw new ArgumentOutOfRangeException("El valor ingresado es invalido, solo se puede ingresar números positivos.");
            double result = input;
            double previousResult = -input;
            while (System.Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result * result - input) / (2 * result);
            }
            return result;
        }
    }
}
