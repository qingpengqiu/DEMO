using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCApp.Controllers;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            new TestController().SimpleMethod();
        }
    }
}
