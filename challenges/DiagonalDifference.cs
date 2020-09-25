using System;
using System.Collections.Generic;

namespace HackerRank
{
  class DiagonalDifference
  {
    public static int Main(List<List<int>> arr)
    {
      int forward = 0;
      int reverse = 0;
      for (int i = 0; i < arr.Count; i++)
      {
        forward += arr[i][i];
        reverse += arr[i][arr.Count - i - 1];
      }
      return Math.Abs(forward - reverse);
    }
  }
}