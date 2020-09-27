// https://www.hackerrank.com/challenges/birthday-cake-candles/problem

using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
  class BirthdayCakeCandles
  {
    public static int Main(List<int> candles)
    {
      int maxValue = candles.Max();
      return candles.Count(n => n == maxValue);
    }

  }
}