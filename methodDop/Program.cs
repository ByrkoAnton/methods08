using System;

namespace methodDop
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 20, b = -33, c = 57;

            DivByN(ref a, ref b, ref c);

            Console.WriteLine($"{a}\n{b}\n{c}");
        }

        static void DivByN(ref double a, ref double b, ref double c, int n=5)
        {
            a /= n;
            b /= n;
            c /= n;
        }
    }
}
