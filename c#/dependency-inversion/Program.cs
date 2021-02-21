using System;

namespace dependency_inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount savings = new BankAccount("1241-5623-4541-4512", 2500m);
            BankAccount current = new BankAccount("4541-1211-4421-4512", 100m);

            TransferManager tm = new TransferManager(savings, current, 100m);
            tm.Transfer();

            Console.WriteLine($"Savings: {savings.Balance}\nCurrent: {current.Balance}");
        }
    }
}
