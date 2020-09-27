// https://www.hackerrank.com/challenges/mini-max-sum/problem

using System.Linq;

namespace HackerRank
{
  class MiniMaxSum
  {
    public static void Main(int[] arr)
    {
      long ascending = arr.Select(n => (long)n)
                               .OrderBy(n => n)
                               .Take(4)
                               .Sum();
      long descending = arr.Select(n => (long)n)
                                .OrderByDescending(n => n)
                                .Take(4)
                                .Sum();
      System.Console.WriteLine($"{ascending} {descending}");
    }
  }
}