using System;

namespace MandelbrotSet
{
    public class CNumber
    {
        public decimal X { get; set; } = 0;
        public decimal Y { get; set; } = 0;
        static ComplexNumber i = new ComplexNumber();
        public CNumber(decimal _x, decimal _y)
        {
            X = _x;
            Y = _y;
        }
        public decimal Length()
        {
            double doubleX = Convert.ToDouble(X);
            double sqaureX = Math.Pow(doubleX, 2);
            double doubleY = Convert.ToDouble(Y);
            double sqaureY = Math.Pow(doubleY, 2);
            double result = Math.Sqrt(sqaureX + doubleY);
            return Convert.ToDecimal(result);
        }
        public static CNumber operator *(CNumber c1, CNumber c2)
        {
            double squareX = Math.Pow(Convert.ToDouble(c1.X), 2);
            double squareY = Math.Pow(Convert.ToDouble(c1.Y), 2);
            decimal newX = Convert.ToDecimal(squareX - squareY);
            decimal newY = 2 * c1.X * c1.Y;
            return new CNumber(newX, newY);
        }
        public static CNumber operator +(CNumber c1, CNumber c2)
        {
            return new CNumber(c1.X + c2.X, c1.Y + c2.Y);
        }
    }
}