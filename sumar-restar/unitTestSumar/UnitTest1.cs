using Microsoft.VisualStudio.TestTools.UnitTesting;
using sumar.Controllers;

namespace unitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestADD1()
        {
            //arrange
            SumaController sumaController = new SumaController();
            int a = 5;
            int b = 8;
            int expected = 13;
            
            //act
            int result = sumaController.ADD(a, b);

            //assert
            Assert.AreEqual(expected, result);

        }
    }
}
