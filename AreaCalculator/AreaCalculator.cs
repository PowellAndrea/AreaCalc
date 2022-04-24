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

      public static double Calculate(int _base, int _height)
      {
         return _base * _height;
      }
      
      #region Squares
      public static double getSquareArea(int _base)
      {
         return Calculate(_base,_base);
      }

      public static double GetSquareArea(string _base)
      {
         if (!string.IsNullOrEmpty(_base) && Convert.ToInt16(_base) >-1 && Convert.ToInt16(_base) <11)
         { return Calculate(Convert.ToInt16(_base), Convert.ToInt16(_base));
         }
         else { return -1; }
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
         return (double)(_circumference / (2 * PI));
      }

      public static double getCircleDiameter(int _radius)
      {
         return _radius * 2;
      }
   }
}