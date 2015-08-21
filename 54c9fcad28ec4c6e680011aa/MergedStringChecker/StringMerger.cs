using System;
using System.Text;

namespace MergedStringChecker
{
  public class StringMerger
  {
    public static bool isMerge(string s, string part1, string part2)
    {
      var builder1 = new StringBuilder(part1);
      var builder2 = new StringBuilder(part2);

      for (var i = 0; i < s.Length; i++)
      {
        var result = ProcessSymbol(s[i], builder1, builder2);
        var ambiguity = result.Item1;
        var mismatch = result.Item2 == false;

        if (ambiguity)
        {
          return
            isMerge(s.Substring(i + 1), builder1.ToString(), builder2.Remove(0, 1).ToString()) ||
            isMerge(s.Substring(i + 1), builder1.Remove(0, 1).ToString(), builder2.ToString());
        }
        else if (mismatch)
        {
          return false;
        }
      }

      if (builder1.Length != 0 || builder2.Length != 0)
      {
        return false;
      }

      return true;
    }

    private static Tuple<bool, bool> ProcessSymbol(char symbol, StringBuilder builder1, StringBuilder builder2)
    {
      if (builder1.Length != 0 && builder2.Length != 0 && builder1[0] == symbol && builder2[0] == symbol)
      {
        return Tuple.Create(true, true);
      }

      if (builder1.Length != 0 && builder1[0] == symbol)
      {
        builder1.Remove(0, 1);
        return Tuple.Create(false, true);
      }
      else if (builder2.Length != 0 && builder2[0] == symbol)
      {
        builder2.Remove(0, 1);
        return Tuple.Create(false, true);
      }

      return Tuple.Create(false, false);
    }
  }
}