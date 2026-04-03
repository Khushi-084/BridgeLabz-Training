using System;
using System.Collections.Generic;

class BankingSystem
{
    public static void Main()
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>();
        accounts[101] = 5000;
        accounts[102] = 12000;
        accounts[103] = 8000;

        Queue<int> withdrawalQueue = new Queue<int>();
        withdrawalQueue.Enqueue(101);
        withdrawalQueue.Enqueue(103);

        Console.WriteLine("Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            int acc = withdrawalQueue.Dequeue();
            accounts[acc] -= 1000;
            Console.WriteLine("Account " + acc + " Balance: " + accounts[acc]);
        }

        SortedDictionary<double, int> sorted =
            new SortedDictionary<double, int>();

        foreach (KeyValuePair<int, double> acc in accounts)
            sorted[acc.Value] = acc.Key;

        Console.WriteLine("\nSorted Accounts:");
        foreach (KeyValuePair<double, int> acc in sorted)
            Console.WriteLine(acc.Value + " : " + acc.Key);
    }
}
