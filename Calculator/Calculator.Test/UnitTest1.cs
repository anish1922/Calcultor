using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        Calc c = new Calc();
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(8, c.Add(3, 5));
        }
    }
}
