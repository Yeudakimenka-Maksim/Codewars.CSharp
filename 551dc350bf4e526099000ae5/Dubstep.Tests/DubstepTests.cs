﻿using NUnit.Framework;

namespace Dubstep.Tests
{
  [TestFixture]
  public class DubstepTests
  {
    [Test]
    public void Test1()
    {
      Assert.AreEqual("ABC", Dubstep.SongDecoder("WUBWUBABCWUB"));
    }

    [Test]
    public void Test2()
    {
      Assert.AreEqual("R L", Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
    }
  }
}