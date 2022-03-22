using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MaxDeviation
{
    class Program
    {
        static void Main(string[] args)
        {
            string toCheck = "aaabb";

            // TODO: Build a nice hash from char to List<int>, this is amoritized O(n)
            Dictionary<char, List<int>> appearences = new Dictionary<char, List<int>>();
            for (int i = 0; i < toCheck.Length; i++)
            {
                char c = toCheck[i];
                if (!appearences.ContainsKey(c)) appearences[c] = new List<int>();
                appearences[c].Add(i);
            }

            List<char> allChars = appearences.Keys.ToList();
            int maxDiff = int.MinValue;
            int minDiff = int.MaxValue;
            for (int i = 0; i < allChars.Count - 1; i++)
            {
                for (int j = i + 1; j < allChars.Count; j++)
                {
                    char a = allChars[0], b = allChars[1];
                    (int pairMax, int pairMin) = CalcPairMaxMin(appearences[a], appearences[b]);
                    maxDiff = Math.Max(pairMax, maxDiff);
                    minDiff = Math.Min(pairMin, minDiff);
                }
            }
            

        }

        static (int, int) CalcPairMaxMin(List<int> xs, List<int> ys)
        {
            int count = 0;
            
        }
    }
}
