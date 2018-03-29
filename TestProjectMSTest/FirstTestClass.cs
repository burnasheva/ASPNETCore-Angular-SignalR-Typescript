using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectMSTest
{
    [TestClass]
    public class FirstTestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreNotEqual(12, 14, "Should be not equal");
        }
    }
}