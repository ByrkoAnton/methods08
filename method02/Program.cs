using System;

namespace method02
{
    class Program
    {
        static void Main(string[] args)
        {
            double debit = 800;

            for (int i = 0; i < 7; i++)
            {
                if (debit == 0)
                    break;
                Console.Write("enter depsit ");
                double money = double.Parse(Console.ReadLine());

                if (money < 100)
                {
                    Console.WriteLine("deposit can't be negativ or 0");
                    i--;
                    continue;
                }
                Console.WriteLine(DepositMoney(ref debit, money));
            }

        }

        static string DepositMoney(ref double debit, double money)
        {
            debit -= money;
            double overpayment = 0;
            string msgNoDebit = "\n";

            if (debit < 0)
            {
                overpayment = debit * -1;
                debit = 0;
            }

            if (debit == 0)
                msgNoDebit = "\nNo Debit";

            return $"amount of debt = {debit}\noverpayment amount = {overpayment} {msgNoDebit}";
        }
    }
}
