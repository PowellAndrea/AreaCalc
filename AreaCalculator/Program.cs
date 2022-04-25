using System;
// using Area_Calc_Powell;

namespace AreaCalculatorNS
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hello World!");

         Console.WriteLine("Square 3: " + AreaCalculator.getSquareArea(3) + "\n");
         Console.WriteLine("Square three: " + AreaCalculator.getSquareArea("three") + "\n");
         Console.WriteLine("Rectange 3,4 : " + AreaCalculator.getRectangleArea(3,4) + "\n");
         Console.WriteLine("Parallelogram 5,4 : " + AreaCalculator.getParallelogramArea(4,2) + "\n"); ;
         Console.WriteLine("Triange 3,5 " + AreaCalculator.getTriangleArea(3,5) + "\n");
         Console.WriteLine("Radius 3: " + AreaCalculator.getCircleRadius(3) + "\n");
         Console.WriteLine("Circle Diameter, 7 " + AreaCalculator.getCircleDiameter(7) + "\n" );
      }
   }
}