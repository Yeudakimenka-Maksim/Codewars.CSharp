namespace MergedStringChecker
{
  public class StringMerger
  {
    public static bool isMerge(string s, string part1, string part2)
    {
      if (part1 == string.Empty)
      {
        return s == part2;
      }

      if (part2 == string.Empty)
      {
        return s == part1;
      }

      if (s == string.Empty)
      {
        return part1 == string.Empty && part2 == string.Empty;
      }

      if (s[0] != part1[0] && s[0] != part2[0])
      {
        return false;
      }

      if (s[0] == part1[0] && s[0] == part2[0])
      {
        return
          isMerge(s.Substring(1), part1.Substring(1), part2) ||
          isMerge(s.Substring(1), part1, part2.Substring(1));
      }

      return
        s[0] == part1[0]
          ? isMerge(s.Substring(1), part1.Substring(1), part2)
          : isMerge(s.Substring(1), part1, part2.Substring(1));
    }
  }
}