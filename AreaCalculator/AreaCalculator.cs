using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Check percision on return
 */

namespace Area_Calc_Lastname
{
   static class AreaCalculator
   {
      internal const decimal PI = 3.14M;

      static Dictionary<string, int> Dictionary = new Dictionary<string, int>
      {
         {"one", 1 },
         {"two", 2 },
         {"three", 3 },
         {"four", 4 },
         {"five", 5 },
         {"six", 6 },
         {"seven", 7},
         {"eight", 8 },
         {"nine", 0 },
         {"ten", 10 }
      };
            
      public static double Calculate(int _base, int _height)
      {
         return _base * _height;
      }
      
      #region Squares
      public static double getSquareArea(int _base)
      {
         return Calculate(_base, _base);
      }

      public static double getSquareArea(string _base)
      {
         _base = _base.ToLower();
         return getSquareArea(Dictionary.TryGetValue(_base, out int _x) ? _x : -1);
      }

      #endregion

      public static double getRectangleArea(int _base, int _height)
      {
         return Calculate(_base, _height);
      }

      public static double getParallelogramArea(int _base, int _height)
      {
         return Calculate(_base, _height);
      }

      public static double getTriangleArea(int _base, int _height)
      {
         return .5 * Calculate(_base, _height);
      }

      public static double getCircleRadius(int _circumference)
      {
         return (double) (_circumference / (2 * PI));
      }

      public static double getCircleDiameter(int _radius)
      {
         return Calculate(_radius, _radius);
      }
   }
}