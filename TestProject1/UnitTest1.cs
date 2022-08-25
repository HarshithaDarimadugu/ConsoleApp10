using ConsoleApp22;
namespace AddUnitTest
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            calculator C = new calculator();
            int result = calculator.Add(10, 20);
            Assert.AreEqual(30, result);
        }
    }
}
