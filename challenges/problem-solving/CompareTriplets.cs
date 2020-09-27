using System.Collections.Generic;

namespace HackerRank
{
  class CompareTriplets
  {
    public static List<int> Main(List<int> a, List<int> b)
    {
      List<int> result = new List<int>() { 0, 0 };
      for (int i = 0; i < 3; i++)
      {
        if (!(a[i] == b[i]))
        {
          if (a[i] > b[i])
            result[0]++;
          else
            result[1]++;
        }
      }
      return result;
    }
  }
}