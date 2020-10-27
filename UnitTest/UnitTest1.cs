using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World!", Hello.Program.CreateMessage());
        }
    }
}
