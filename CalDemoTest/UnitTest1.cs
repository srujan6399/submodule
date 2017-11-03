using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace CalDemoTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void AddTest()
        {
            int a = 3;
            int b = 4;
            int expeted = 7;
            int actual = CalDemo.Program.Add(a, b);
            NUnit.Framework.Assert.AreEqual(expeted, actual);
        }
        [Test]
        public void DivideTest()
        {
            int x = 10;
            int y = 2;
            int expected = 4;
            int actual = CalDemo.Program.divide(x, y);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
