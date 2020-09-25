// https://www.hackerrank.com/challenges/plus-minus/problem
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
  class PlusMinus
  {
    public static void Main(int[] arr)
    {
      float positives = arr.Where(n => n > 0).Select(n => n).Count();
      float negatives = arr.Where(n => n < 0).Select(n => n).Count();
      float zeros = arr.Where(n => n == 0).Select(n => n).Count(); ;  
      System.Console.WriteLine($"{(positives / arr.Count())}");
      System.Console.WriteLine($"{(negatives / arr.Count())}");
      System.Console.WriteLine($"{(zeros / arr.Count())}");
    }
  }
}