using System;

namespace method03
{
    class Program
    {
        static void Main(string[] args)
        {
            int byers;
            Console.WriteLine("enter byers quantity");
            byers = int.Parse(Console.ReadLine());

           if(byers<=0)
                Console.WriteLine("quantity of byers can't be negativ or 0");

           else
                Console.WriteLine($"deliverys ways = {GetFact(byers)}" );


        }
        static double GetFact(int byers)
        {
            if (byers == 0)
                return 1;
            return byers * GetFact(byers - 1);
        }
    }
}
