using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {   /*
             * some test of use 
             */
            double result;
            Figure ff = new Figure();
            //square Perimeter
            result = ff.squarePerimeter(Figure.getPointArr(0, -2), Figure.getPointArr(-2, 0));
            Console.WriteLine("[] Perimeter: " + result);
            //Square Square
            result = ff.squareSquare(Figure.getPointArr(0, -2), Figure.getPointArr(-2, 0));
            Console.WriteLine("square Square: " + result);
            //Square overload Square
            result = ff.squareSquare(Figure.getLengthSide(Figure.getPointArr(0, -2), Figure.getPointArr(-3, 0)));
           //use get from class .
            result = ff.squareSquareBox;
            Console.WriteLine("square Square<overload>: " + result);
            //Triangle Perimeter
            result = ff.trianglePerimeter(Figure.getPointArr(0, 1), Figure.getPointArr(2, 2), Figure.getPointArr(0, 4));
            Console.WriteLine("Triangle Perimeter: " + result);
            //Hexagon Square
            result = ff.hexagonSquare(Figure.getLengthSide(Figure.getPointArr(0, 1), Figure.getPointArr(3, 4)));
            Console.WriteLine("Hexagon Square: " + result);
            //overload Hexagon Square
            result = ff.hexagonSquare(Figure.getPointArr(0, 2), Figure.getPointArr(3, 4));
            Console.WriteLine("Hexagon Square<overload>: " + result);
            //Perimeter of same Figura
            double sameFigura = Figure.getPerimetr(
                Figure.getLengthSide(Figure.getPointArr(8, -2), Figure.getPointArr(-1, 3)),
                Figure.getLengthSide(Figure.getPointArr(0, -3), Figure.getPointArr(-2, 0)),
                Figure.getLengthSide(Figure.getPointArr(8, -4), Figure.getPointArr(-9, 2)),
                Figure.getLengthSide(Figure.getPointArr(0, -5), Figure.getPointArr(-8, 0)),
                Figure.getLengthSide(Figure.getPointArr(0, -6), Figure.getPointArr(-7, 0))
               
                );
            Console.WriteLine("Perimeter of same Figura: " + sameFigura);
            
        }
    }
}
