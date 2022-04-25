using System;
using Area_Calc_Lastname;

namespace AreaCalculator
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hello World!");

         Console.WriteLine("Square 3: " + Area_Calc_Lastname.AreaCalculator.getSquareArea(3) + "\n");
         Console.WriteLine("Square three: " + Area_Calc_Lastname.AreaCalculator.getSquareArea("three") + "\n");
         Console.WriteLine("Rectange 3,4 : " + Area_Calc_Lastname.AreaCalculator.getRectangleArea(3,4) + "\n");
         Console.WriteLine("Parallelogram 5,4 : " + Area_Calc_Lastname.AreaCalculator.getParallelogramArea(4,2) + "\n"); ;
         Console.WriteLine("Triange 3,5 " + Area_Calc_Lastname.AreaCalculator.getTriangleArea(3,5) + "\n");
         Console.WriteLine("Radius 3: " + Area_Calc_Lastname.AreaCalculator.getCircleRadius(3) + "\n");
         Console.WriteLine("Circle Diameter, 7 " + Area_Calc_Lastname.AreaCalculator.getCircleDiameter(7) + "\n" );
      }
   }
}