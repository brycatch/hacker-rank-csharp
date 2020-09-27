namespace HackerRank
{
  class AVeryBugSum
  {
    public static long Main(long[] ar)
    {
      long result = 0;
      for (int i = 0; i < ar.Length; i++)
        result += ar[i];
      return result;
    }
  }
}