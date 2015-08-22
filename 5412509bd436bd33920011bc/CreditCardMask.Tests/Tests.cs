using NUnit.Framework;

namespace CreditCardMask.Tests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void ExamplesTests()
    {
      Assert.AreEqual(Kata.Maskify("4556364607935616"), "############5616");
      Assert.AreEqual(Kata.Maskify("1"), "1");
      Assert.AreEqual(Kata.Maskify("11111"), "#1111");
    }
  }
}