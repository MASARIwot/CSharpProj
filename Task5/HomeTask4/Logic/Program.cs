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

            /*
             * 
             * 
             * Part For Home Task #6 
             * 
             * 
             * 
             * @see Logic.TriangleModForHome6.cs 
             * @see interface.ITriangle.cs
             * 
             * 
             */
            /*
            * Creating figure by constructor with param...
            */
            ITriangle triangle = new TriangleModForHome6(5);
            
            double result = 0;
            
            //square Perimeter
            result = triangle.squarePerimeter(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-2, 0));
            Console.WriteLine("Perimeter: " + result);
            //Square Square
            result = triangle.squareSquare(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-2, 0));
            Console.WriteLine("square Square: " + result);
            //Square overload Square
            result = triangle.squareSquare(Coordinates.getLengthSide(Coordinates.getPointArr(0, -2), Coordinates.getPointArr(-3, 0)));
            //use get from class .
            result = triangle.squareSquareBox;
            Console.WriteLine("square Square<overload>: " + result);
            //Triangle Perimeter
            result = triangle.trianglePerimeter(Coordinates.getPointArr(0, 1), Coordinates.getPointArr(2, 2), Coordinates.getPointArr(0, 4));
            Console.WriteLine("Triangle Perimeter: " + result);
            //Hexagon Square
            result = triangle.hexagonSquare(Coordinates.getLengthSide(Coordinates.getPointArr(0, 1), Coordinates.getPointArr(3, 4)));
            Console.WriteLine("Hexagon Square: " + result);
            //overload Hexagon Square
            result = triangle.hexagonSquare(Coordinates.getPointArr(0, 2), Coordinates.getPointArr(3, 4));
            Console.WriteLine("Hexagon Square<overload>: " + result);

            //ITriangle triangle = new TriangleModForHome6();
            
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



            Console.WriteLine("\nPart For Home Task #6 ");
            Console.WriteLine();
            Console.WriteLine("Constructor with param! - for Circle");
            Console.WriteLine("circle Perimeter: " + triangle.circlePerimeterBox);
            Console.WriteLine("circle Square: " + triangle.circleSquareBox);
            /*
             * Create AND print his clone
             */
            ITriangle conedClass = (TriangleModForHome6)triangle.Clone();
            /*
             * Print clone info
             */
            Console.WriteLine("Constructor with param! - for Circle");
            Console.WriteLine("circle Perimeter: " + conedClass.circlePerimeterBox);
            Console.WriteLine("circle Square: " + conedClass.circleSquareBox);
            /*
             * CompareTo conedClass AND triangle must write *1* 
             */
            Console.WriteLine("CompareTo : " + conedClass.CompareTo(triangle));
            /*
             * Equals conedClass AND triangle must write *true* 
             */
            Console.WriteLine("Equals : " + conedClass.Equals(triangle));
            /*
             * To String 
             */
            Console.WriteLine("ToString : " + conedClass.ToString());



            /*
            * Creating figure by constructor with param...
            */
            TriangleModForHome6 forTest;
            TriangleModForHome6 triangle1 = new TriangleModForHome6(10);
            TriangleModForHome6 triangle2 = new TriangleModForHome6(0);
            
            bool res0 = triangle1 < triangle2;
            bool res1 = triangle1 > triangle2;
            Console.WriteLine("1:"+res0 +" 2:"+ res1);
            Console.WriteLine("\nTest0");          
            
            /*
             * catch Exeption*s
             */
            try
            {
            forTest = triangle1*triangle2;
            }
            catch (MyExeptioClass e)
            {
                Console.WriteLine(e.Message);
            }
                 
            
            Console.WriteLine("\nTest1");
            try
            {
                int resultTest = triangle1 / triangle2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nTest2");
            try
            {
                Coordinates.getPerimetr(1,5,-10,6);
            }
            catch (MyExeptioClass e) {
                 Console.WriteLine(e.SameEmail());
                 Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nTest3");
            try
            {
                Coordinates.getPerimetr(0);
            }
            catch (MyExeptioClass e)
            {
                Console.WriteLine(e.SameEmail());
                Console.WriteLine(e.Message);
            }
            finally {

                Console.WriteLine("AND");
            }
            
            Console.ReadKey();


        }
    }
}
