using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public sealed class Triangle : HomeTask4.Figure, HomeTask4.ITriangle, HomeTask4.IFigure
    {
        public Triangle() { 
        
        }
        //Constructor with param
        public Triangle(double Radius)
        {
            circleSquare(Radius);
            circlePerimeter(Radius);
        }

        //circle Perimeter Box
        public double circlePerimeterBox { get; private set; }
        //circle Square Box
        public double circleSquareBox    { get; private set; }
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


    }
}
