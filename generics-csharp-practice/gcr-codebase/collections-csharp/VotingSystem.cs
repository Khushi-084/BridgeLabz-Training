using System;
using System.Collections.Generic;

class VotingSystem
{
    public static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();

        Vote(votes, "Alice");
        Vote(votes, "Bob");
        Vote(votes, "Alice");

        Console.WriteLine("Votes:");
        foreach (KeyValuePair<string, int> v in votes)
            Console.WriteLine(v.Key + " : " + v.Value);

        SortedDictionary<string, int> sorted =
            new SortedDictionary<string, int>(votes);

        Console.WriteLine("\nSorted Votes:");
        foreach (KeyValuePair<string, int> v in sorted)
            Console.WriteLine(v.Key + " : " + v.Value);
    }

    static void Vote(Dictionary<string, int> votes, string name)
    {
        if (votes.ContainsKey(name))
            votes[name]++;
        else
            votes[name] = 1;
    }
}
