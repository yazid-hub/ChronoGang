using System;
using System.Linq;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int[] transactions = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Dictionary<int, int> freq = new Dictionary<int, int>();
    for (int i = 0; i < transactions.Length; i++) {
        if(!freq.ContainsKey(transactions[i]))
            freq[transactions[i]]=1;
        else
            freq[transactions[i]]++;
    }

    int maxFreq = 0;
    int minFreq = int.MaxValue;
    List<int> maxNums = new List<int>();
    List<int> minNums = new List<int>();
    foreach (var item in freq)
    {
        if (item.Value > maxFreq) {
            maxFreq = item.Value;
            maxNums.Clear();
            maxNums.Add(item.Key);
        }
        else if(item.Value == maxFreq)
        {
            maxNums.Add(item.Key);
        }
        if (item.Value < minFreq && item.Value != 0) {
            minFreq = item.Value;
            minNums.Clear();
            minNums.Add(item.Key);
        }
        else if(item.Value == minFreq)
        {
            minNums.Add(item.Key);
        }
    }
    int maxNum = maxNums.Max();
    int minNum = minNums.Min();

    Console.WriteLine(maxNum - minNum);
  }
}
