using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeTask3
{
    public partial class Figure
    {   //Perimeter Box
        public double squarePerimeterBox { get; private set; }
        public double rectanglePerimeterBox { get; private set; }
        public double trianglePerimeterBox { get; private set; }
        //Square Box
        public double squareSquareBox { get; private set; }
        public double rectangleSquareBox { get; private set; }
        public double triangleSquareBox { get; private set; }
        public double hexagonSquareBox { get; private set; }
        public double rhombusSquareBox { get; private set; }
        //constructor
        public Figure(string str)
        {
            /*
             It*s a overload constructor.
            */
        }
        /*
         this method find any Perimetr. parama: side ,more than one (>1)
         */
        public static double getPerimetr(params double[] parties)
        {
            double result = 0;
            foreach (double res in parties) {
                result += res;
            }

            return result;
        }
        /*
         This method retun length of side .parama: 2 point
         * can use like->Figure.getLengthSide(Figure.getPointArr(x, y), Figure.getPointArr(x, y))
         */
        public static double getLengthSide(int[] point, int[] point2)
        {
            double result =  Math.Sqrt(Math.Pow((point2[0] - point[0]), 2) + Math.Pow((point2[1] - point[1]), 2));
            
            return result;
        }
        /*
         This method retun length of side .parama: new int[4]{point}
         
        public static double getLengsSide(int[] point)
        {
            double result = Math.Sqrt(Math.Pow((point[0] - point[2]), 2) + Math.Pow((point[2] - point[3]), 2));

            return result;
        }*/
        /*
         This method return int[] result[x,y] :->call- Figure.getPointArr(x, y)
         */
        public static int[] getPointArr(int x, int y)
        {   int[] result = new int[2];
            result[0] = x;
            result[1] = y;
         return result;
        }

        /*
         Square
         */
        public double squareSquare(int[] A, int[] B)
        {
            double AB;
            getABC(ref A, ref B, out AB);
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
            getABC(ref A, ref B, ref C, out AB, out BC, out CA);
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
         Triangle Square
         */
        public double triangleSquare(int[] A, int[] B)
        {
            double AB;
            getABC(ref A, ref B, out AB);
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
        {   double AB;
            getABC(ref A, ref B, out AB);
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
