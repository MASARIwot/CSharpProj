using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class Figure : HomeTask4.IFigure
    {   // same Box
        public double squarePerimeterBox    { get; private set; }
        public double rectanglePerimeterBox { get; private set; }
        public double trianglePerimeterBox  { get; private set; }

        public double squareSquareBox    { get; private set; }
        public double rectangleSquareBox { get; private set; }
        public double triangleSquareBox  { get; private set; }
        public double hexagonSquareBox   { get; private set; }
        public double rhombusSquareBox   { get; private set; }
                
        /*
         *Square Perimeter
         */
        public double squarePerimeter(int[] A, int[] B)
        {
            double AB;
            Coordinates.getABC(ref A, ref B, out AB);
            squarePerimeterBox = AB * 4;
            return squarePerimeterBox;
        }
        /*
         *Rectangle Perimeter
         */
        public double rectanglePerimeter(int[] A, int[] B, int[] C)
        {
            double AB, BC, CA;
            Coordinates.getABC(ref A, ref B, ref C, out AB, out BC, out CA);
            rectanglePerimeterBox = (AB + BC) * 2;
            return rectanglePerimeterBox;
        }
        /*
         *Triangle Perimeter
         */
        public double trianglePerimeter(int[] A, int[] B, int[] C)
        {
            double AB, BC, CA;
            Coordinates.getABC(ref A, ref B, ref C, out AB, out BC, out CA);
            trianglePerimeterBox = AB + BC + CA;

            return trianglePerimeterBox;
        }

        /*
         * Square
         */
        public double squareSquare(int[] A, int[] B)
        {
            double AB;
            Coordinates.getABC(ref A, ref B, out AB);
            squareSquareBox = AB * AB;
            return squareSquareBox;
        }
        //overload Square
        public double squareSquare(double AB)
        {
            squareSquareBox = AB * AB;
            return squareSquareBox;
        }
        /*
         Rectangle Square
         */
        public double rectangleSquare(int[] A, int[] B, int[] C)
        {
            double AB, BC, CA;
            Coordinates.getABC(ref A, ref B, ref C, out AB, out BC, out CA);
            rectangleSquareBox = AB * BC;
            return rectangleSquareBox;
        }
        //overload Rectangle Square
        public double rectangleSquare(double AB, double BC)
        {
            rectangleSquareBox = AB * BC;
            return rectangleSquareBox;
        }
        /*
         *Triangle Square
         */
        public double triangleSquare(int[] A, int[] B)
        {
            double AB;
            Coordinates.getABC(ref A, ref B, out AB);
            triangleSquareBox = (Math.Sqrt(3)) * ((AB * AB) / 4);
            return triangleSquareBox;
        }
        //overload Triangle Square
        public double triangleSquare(double AB)
        {
            triangleSquareBox = (Math.Sqrt(3)) * ((AB * AB) / 4);
            return triangleSquareBox;
        }
        /*
         * Hexagon Square
         */
        public double hexagonSquare(int[] A, int[] B)
        {
            double AB;
            Coordinates.getABC(ref A, ref B, out AB);
            hexagonSquareBox = 3 * (Math.Sqrt(3)) * ((AB * AB) / 2);
            return hexagonSquareBox;
        }
        //overload Hexagon Square
        public double hexagonSquare(double AB)
        {
            hexagonSquareBox = 3 * (Math.Sqrt(3)) * ((AB * AB) / 2);
            return hexagonSquareBox;
        }



    }

}
