using System;

namespace PlayingWithDigits
{
  public class DigPow
  {
    public static long digPow(int n, int p)
    {
      var sum = 0;
      foreach (var c in n.ToString())
      {
        sum += (int)Math.Pow((int)char.GetNumericValue(c), p++);
      }

      if (sum % n == 0)
      {
        return sum / n;
      }

      return -1;
    }
  }
}