using System;

namespace MandelbrotSet
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter X");
            decimal X = Convert.ToDecimal(Console.ReadLine());  // 0.25m;
            Console.WriteLine("Enter Y");
            decimal Y = Convert.ToDecimal(Console.ReadLine());
            bool doesBelongTo = RunProgramm(X, Y);
            Console.WriteLine(doesBelongTo);

        }

        private static bool RunProgramm(decimal x, decimal y)
        {
            CNumber c = new CNumber(x, y);
            ZFunction Z = new ZFunction(0);
            for (int i = 1; i < 500; i++)
            {
                Z = Z * Z + c;
                if (Z.Length > 2 || Z.Length < 0)
                {
                    return false;
                }
                Z.Print();

            }
            return true;
        }
    }
}
