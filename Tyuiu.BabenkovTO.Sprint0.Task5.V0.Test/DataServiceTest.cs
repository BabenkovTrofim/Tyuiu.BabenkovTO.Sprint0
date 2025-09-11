using Tyuiu.BabenkovTO.Sprint0.Task5.V0.Lib;
namespace Tyuiu.BabenkovTO.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addiction(5, 5));
        }
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(6, DataService.Subtraction(9, 3));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(100, DataService.Multiplication(10, 10));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(1, DataService.Division(5, 5));
        }
    }
}
