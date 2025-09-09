using Tyuiu.BabenkovTO.Sprint0.Task3.V0.Lib;
namespace Tyuiu.BabenkovTO.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
