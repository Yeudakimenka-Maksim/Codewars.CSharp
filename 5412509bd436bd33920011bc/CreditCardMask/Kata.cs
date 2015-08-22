namespace CreditCardMask
{
  public static class Kata
  {
    // return masked string
    public static string Maskify(string cc)
    {
      return cc.Length <= 4 ? cc : cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#');
    }
  }
}