using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Reading input
        int N = int.Parse(Console.ReadLine());
        int[] weights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        // Output the result
        Console.WriteLine(MaxTeams(N, weights));
    }

    static int MaxTeams(int N, int[] weights)
    {
        // Count occurrences of each weight
        Dictionary<int, int> weightCounts = new Dictionary<int, int>();
        foreach (int weight in weights)
        {
            if (!weightCounts.ContainsKey(weight))
                weightCounts[weight] = 0;
            weightCounts[weight]++;
        }

        int maxTeamsCount = 0;

        for (int s = 2; s <= N * 2; s++)
        {
            int teamsCount = 0;
            for (int a = 1; a < s; a++)
            {
                int b = s - a;
                if (weightCounts.ContainsKey(a) && weightCounts.ContainsKey(b))
                {
                    teamsCount += Math.Min(weightCounts[a], weightCounts[b]);
                }
            }
            maxTeamsCount = Math.Max(maxTeamsCount, teamsCount / 2);
        }

        return maxTeamsCount;
    }
}
