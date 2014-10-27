using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public sealed class TriangleModForHome6 : Figure, ITriangle
    {
        public TriangleModForHome6() { 
        
        }
        //Constructor with param
        public TriangleModForHome6(double Radius)
        {
            circleSquare(Radius);
            circlePerimeter(Radius);
        }

        //circle Perimeter Box
        public double circlePerimeterBox { get;  set; }
        //circle Square Box
        public double circleSquareBox { get;  set; }
        /*
        Square
        */
        public double circleSquare(int[] A, int[] B)
        {
            double Radius;
            Coordinates.getABC(ref A, ref B, out Radius);
            circleSquareBox = (Radius * Radius) * (Math.PI);
            return circleSquareBox;
        }
        /*
        Square
        */
        public double circleSquare(double Radius)
        {
            circleSquareBox = (Radius * Radius) * (Math.PI);
            return circleSquareBox;
        }
        //circle Perimeter
        public double circlePerimeter(int[] A, int[] B)
        {
            double Radius;
            Coordinates.getABC(ref A, ref B, out Radius);
            circlePerimeterBox = 2 * Radius * (Math.PI);
            return circlePerimeterBox;
        }
        //circle Perimeter
        public double circlePerimeter(double Radius)
        {
            circlePerimeterBox = 2 * Radius * (Math.PI);
            return circlePerimeterBox;
        }

        /*
         * 
         * 
         * Part For Home Task #6 
         * 
         * 
         */
        //********ICloneable***************************************
        public object Clone()
        {
            TriangleModForHome6 foClone = new TriangleModForHome6();
            
            foClone.circlePerimeterBox      = this.circlePerimeterBox;
            foClone.circleSquareBox         = this.circleSquareBox;
            foClone.hexagonSquareBox        = base.hexagonSquareBox;
            foClone.rectanglePerimeterBox   = base.rectanglePerimeterBox;
            foClone.rectangleSquareBox      = base.rectangleSquareBox;
            foClone.squarePerimeterBox      = base.squarePerimeterBox;
            foClone.trianglePerimeterBox    = base.trianglePerimeterBox;
            foClone.triangleSquareBox       = base.triangleSquareBox;

            return foClone;
        }

        ////********IComparable***************************************
        public int CompareTo(object obj) {
            
            TriangleModForHome6 other = obj as TriangleModForHome6;
           
            if (this.triangleSquareBox > other.triangleSquareBox)       return 1;
            else if (this.triangleSquareBox < other.triangleSquareBox)  return -1;
            else return 1;
            
        }
        /*
         ********toString() AND equals()***************************************
        */

        public override string ToString()
        {
            return "circle Perimetr : " + this.circlePerimeterBox + " circle Sqvere : " + this.circleSquareBox +
                   "\n hexagon Squar : " + base.hexagonSquareBox + " rectangle Perimeter : " + base.rectanglePerimeterBox +
                   "\n rectangle Square : " + base.rectangleSquareBox + " quare Perimeter : " + base.squarePerimeterBox +
                   "\n triangle Perimeter : " + base.trianglePerimeterBox + " triangle Square : " + base.triangleSquareBox;
        }
       

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            TriangleModForHome6 other = obj as TriangleModForHome6;
            if (this.triangleSquareBox      != other.triangleSquareBox)     return false;
            if (other.circlePerimeterBox    != this.circlePerimeterBox)     return false;
            if (other.circleSquareBox       != this.circleSquareBox)        return false;
            if (other.hexagonSquareBox      != base.hexagonSquareBox)       return false;
            if (other.rectanglePerimeterBox != base.rectanglePerimeterBox)  return false;
            if (other.rectangleSquareBox    != base.rectangleSquareBox)     return false;
            if (other.squarePerimeterBox    != base.squarePerimeterBox)     return false;
            if (other.trianglePerimeterBox  != base.trianglePerimeterBox)   return false;
            if (other.triangleSquareBox     != base.triangleSquareBox)      return false;
            else return true;
        }
        public override int GetHashCode()
        {
            return (int)(this.triangleSquareBox + this.trianglePerimeterBox + base.GetHashCode());
        }


        public static bool operator >(TriangleModForHome6 a, TriangleModForHome6 b)
        {

            if (a.circleSquareBox > b.circleSquareBox)
            {
                return true;
            }
            else return false;
        }
        public static bool operator <(TriangleModForHome6 a, TriangleModForHome6 b)
        {
            if (a.circleSquareBox < b.circleSquareBox)
            {
                return true;
            }
            else return false;
        }



        public static TriangleModForHome6 operator +(TriangleModForHome6 f1, TriangleModForHome6 f2)
        {
            TriangleModForHome6 th = new TriangleModForHome6(f1.circlePerimeterBox + f2.circlePerimeterBox);
            return th;
        }
        public static TriangleModForHome6 operator -(TriangleModForHome6 f1, TriangleModForHome6 f2)
        {
            TriangleModForHome6 th = new TriangleModForHome6(f1.circlePerimeterBox - f2.circlePerimeterBox);
            return th;
        }
        public static TriangleModForHome6 operator *(TriangleModForHome6 f1, TriangleModForHome6 f2)
        {
            double res  = Convert.ToDouble(f1.circlePerimeterBox);
            if (res == 0) throw new MyExeptioClass("Fist parama = 0");
            double res2 = Convert.ToDouble(f2.circlePerimeterBox);
            if (res2 == 0) throw new MyExeptioClass("Second parama = 0");
            TriangleModForHome6 th = new TriangleModForHome6(res*res2);
            
            return th;
        }
        public static int operator /(TriangleModForHome6 f1, TriangleModForHome6 f2) 
        {
            int resu = 0;
            int res = 0;
            int res2 = 0;
            try
            {
                res = Convert.ToInt32(f1.circlePerimeterBox);
                res2 = Convert.ToInt32(f2.circlePerimeterBox);
                if (res2 == 0) throw new DivideByZeroException();


            } catch(OverflowException e){
                throw;
            } 

                resu = (res / res2);
            

            return resu;
            
        }






    }
}
