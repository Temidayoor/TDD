using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleInterestTest()
        {

            var saving = new Savings();
            double amount = saving.SimpleInterest(100, 2, 5);
            Assert.AreEqual(110, amount);

        }
    }
}
