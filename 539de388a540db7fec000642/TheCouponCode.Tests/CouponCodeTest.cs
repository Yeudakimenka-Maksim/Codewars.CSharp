using NUnit.Framework;

namespace TheCouponCode.Tests
{
  [TestFixture]
  public class CouponCodeTest
  {
    [Test]
    public static void ValidCoupon()
    {
      Assert.AreEqual(true, Kata.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
    }

    [Test]
    public static void InvalidCoupon()
    {
      Assert.AreEqual(false, Kata.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));
    }
  }
}