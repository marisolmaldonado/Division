using System;

namespace Division.Test
{
    internal class Calculadora
    {
        public Calculadora()
        {
        }

        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();

            return dividendo / divisor;
        }
    }
}