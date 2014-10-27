using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {

            IFigure figure = new Figure();
            
            double result = 0;
            
            //square Perimeter
            result = figure.squarePerimeter(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-2, 0));
            Console.WriteLine("Perimeter: " + result);
            //Square Square
            result = figure.squareSquare(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-2, 0));
            Console.WriteLine("square Square: " + result);
            //Square overload Square
            result = figure.squareSquare(Coordinates.getLengthSide(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-3, 0)));
            //use get from class .
            result = figure.squareSquareBox;
            Console.WriteLine("square Square<overload>: " + result);
            //Triangle Perimeter
            result = figure.trianglePerimeter(Coordinates.getPointArr(0, 1), Coordinates.getPointArr(2, 2), Coordinates.getPointArr(0, 4));
            Console.WriteLine("Triangle Perimeter: " + result);
            //Hexagon Square
            result = figure.hexagonSquare(Coordinates.getLengthSide(Coordinates.getPointArr(0, 1), Coordinates.getPointArr(3, 4)));
            Console.WriteLine("Hexagon Square: " + result);
            //overload Hexagon Square
            result = figure.hexagonSquare(Coordinates.getPointArr(0, 2), Coordinates.getPointArr(3, 4));
            Console.WriteLine("Hexagon Square<overload>: " + result);

            ITriangle triangle = new Triangle();
            
            //circle Perimeter
            result = triangle.circlePerimeter(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-2, 0));
            Console.WriteLine("circle Perimeter: " + result);
            result = triangle.circlePerimeter(Coordinates.getLengthSide(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-2, 0)));
            Console.WriteLine("circle Perimeter<overload>:  " + result);
            //circle Square
            result = triangle.circleSquare(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-2, 0));
            Console.WriteLine("circle Square: " + result);
            result = triangle.circleSquare(Coordinates.getLengthSide(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-2, 0)));
            Console.WriteLine("circle Square<overload>: " + result);

            /*
             * Creating figure by constructor with param...
             */
            Console.WriteLine();
            triangle = new Triangle(5);//oure constructor
            Console.WriteLine("Constructor with param! - for Circle");
            Console.WriteLine("circle Perimeter: " + triangle.circlePerimeterBox);
            Console.WriteLine("circle Square: " + triangle.circleSquareBox);

            Console.ReadKey();


        }
    }
}
