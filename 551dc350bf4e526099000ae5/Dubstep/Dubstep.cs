using System.Text.RegularExpressions;

namespace Dubstep
{
  public class Dubstep
  {
    public static string SongDecoder(string input)
    {
      return Regex.Replace(input, "(WUB)+", " ").Trim();
    }
  }
}