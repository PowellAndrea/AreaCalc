using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calc_Lastname
{
   static class AreaCalculator
   {
      internal const decimal PI = 3.14M;

      #region Squares
      public static double getSquareArea(int _base, int _height)
      {
         return _base * _height;
      }

      public static double GetSquareArea(string _base, string _height)
      {
         return 0;
         //if (Convert.ToInt32(_base) >= 1 && Convert.ToInt32(_height) >= 1)
         //{
         //   return getSquareArea(Convert.ToInt32(_base), Convert.ToInt32(_height));
         //}
         //else
         //{
         //   return -1;
         //}       
      }
      #endregion

      public static double getRectangleArea(int _base, int _height)
      {
         return getSquareArea(_base, _height);
      }

      public static double getParallelogramArea(int _base, int _height)
      {
         return getSquareArea(_base, _height);
      }

      public static double getTriangleArea(int _base, int _height)
      {
         return .5 * getSquareArea(_base, _height);
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