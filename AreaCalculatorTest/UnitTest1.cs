using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculatorNS;


namespace AreaCalculatorTest
{

   [TestClass]
   public class UnitTest1
   {
      //public TestContext TestContext { get; set; }

      //[ClassInitialize]
      //public static void TestClassinitialize(TestContext context)
      //{
      //   var x = context.Properties["RADIUS"];
      //}

      [TestMethod]
      public void TestSquare1() => Assert.AreEqual(AreaCalculator.getSquareArea(7),49);

      [TestMethod]
      public void TestSquare2() => Assert.AreEqual(AreaCalculator.getSquareArea("seven"), 49);

      [TestMethod]
      public void TestRectangle() => Assert.AreEqual(AreaCalculator.getRectangleArea(5, 4), 20);

      [TestMethod]
      public void TestParallelogram() => Assert.AreEqual(AreaCalculator.getParallelogramArea(5, 4), 20);

      [TestMethod]
      public void TestRadius() => Assert.AreEqual(AreaCalculator.getCircleRadius(3), .47);

      [TestMethod]
      public void TestDiamter() => Assert.AreEqual(AreaCalculator.getCircleDiameter(3), 9);

   }
}
