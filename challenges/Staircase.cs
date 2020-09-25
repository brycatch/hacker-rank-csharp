// https://www.hackerrank.com/challenges/staircase/problem
namespace HackerRank
{
  class Staircase
  {
    public static void Main(int n)
    {
      for (int i = 0; i < n; i++)
      {
        string spaces = new string(' ', n - i - 1);
        string characters = new string('#', i + 1);        
        System.Console.WriteLine($"{spaces}{characters}");
      }
    }
  }
}