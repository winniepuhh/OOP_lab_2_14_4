using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMultiplication()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = OOP_lab_2_14_4.Program.Multiplication(array);
            Assert.AreEqual(945, result);
        }

        [TestMethod]
        public void TestSum()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = OOP_lab_2_14_4.Program.Sum(array);
            Assert.AreEqual(45, result);
        }
    }
}
