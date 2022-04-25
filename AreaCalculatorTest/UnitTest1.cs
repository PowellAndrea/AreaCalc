using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculatorNS;


namespace AreaCalculatorTest
{

   [TestClass]
   public class UnitTest1
   {
      private int Base = 3;
      private int Height = 7;
      private int Radius = 4;
      private int Circ = 3;

      public TestContext TestContext { get; set; }

      // I couldn't quite get there .. but danced all night long.
      //private int Base;
      //private int Height;
      //private int Radius;
      //private int Circ;


      ////[TestInitialize]
      //[ClassInitialize]
      //public void ClassInitialize(TestContext context)
      //{
      //   Base = (int)context.Properties["BASE"];     // 3
      //   Height = (int)context.Properties["HEIGHT"]; // 7
      //   Radius = (int)context.Properties["RADIUS"]; // 4
      //   Circ = (int)context.Properties["CIRC"];     // 3
      //}


      [TestMethod]
      public void TestSquare1() => Assert.AreEqual(AreaCalculator.getSquareArea(Base),9);

      [TestMethod]
      public void TestSquareseven() => Assert.AreEqual(AreaCalculator.getSquareArea("seven"), 49);

      [TestMethod]
      public void TestSquareSeVen() => Assert.AreEqual(AreaCalculator.getSquareArea("SeVen"), 49);
      
      [TestMethod]
      public void TestSquareeleven() => Assert.AreEqual(AreaCalculator.getSquareArea("eleven"), -1);

      [TestMethod]
      public void TestSquareBob() => Assert.AreEqual(AreaCalculator.getSquareArea("Bob"), -1);

      [TestMethod]
      public void TestRectangle() => Assert.AreEqual(AreaCalculator.getRectangleArea(Base, Height), 21);

      [TestMethod]
      public void TestParallelogram() => Assert.AreEqual(AreaCalculator.getParallelogramArea(Base, Height), 21);

      [TestMethod]
      public void TestTriangle() => Assert.AreEqual(AreaCalculator.getTriangleArea(Base, Height), 10.5);

      [TestMethod]
      public void TestRadius() => Assert.AreEqual(AreaCalculator.getCircleRadius(Circ), .47);

      [TestMethod]
      public void TestDiamter() => Assert.AreEqual(AreaCalculator.getCircleDiameter(Radius), 16);

   }
}
