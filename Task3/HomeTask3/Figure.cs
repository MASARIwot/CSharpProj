using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeTask3
{
    public partial class Figure
    {
        //constructor
       public  Figure() { 
       
       }
       
       /*
        Create side by point
        */
       private void getABC(ref int[] A, ref int[] B, ref int[] C, out double AB, out double BC, out double CA)
       {
           AB = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]),2));
           BC = Math.Sqrt(Math.Pow((C[0] - B[0]), 2) + Math.Pow((C[1] - B[1]), 2));
           CA = Math.Sqrt(Math.Pow((A[0] - C[0]), 2) + Math.Pow((A[1] - C[1]), 2));
       
       }
       /*
       Create side by point
       */
       private void getABC(ref int[] A, ref int[] B,  out double AB)
       {
           AB = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2));
       }
       /*
        Square Perimeter
        */
       public double squarePerimeter(int[] A, int[] B)
       {   double AB; 
           getABC(ref A, ref B, out AB);
           squarePerimeterBox = AB * 4;
        return squarePerimeterBox; 
       }
       /*
        Rectangle Perimeter
        */
       public double rectanglePerimeter(int[] A, int[] B, int[] C)
       {   double AB, BC, CA;
           getABC(ref A, ref B, ref C, out AB, out BC, out CA);
           rectanglePerimeterBox = (AB + BC) * 2;
        return rectanglePerimeterBox;
       }
       /*
        Triangle Perimeter
        */
       public double trianglePerimeter(int[] A, int[] B, int[] C)
       {   double AB, BC, CA;
           getABC(ref A, ref B, ref C, out AB, out BC, out CA);
           trianglePerimeterBox = AB + BC + CA;

           return trianglePerimeterBox;
       }

    }
}
