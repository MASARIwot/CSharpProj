using System;
namespace HomeTask4
{
    public interface ITriangle : IFigure, ICloneable, IComparable
    {
        double circlePerimeter(double Radius);
        double circlePerimeter(int[] A, int[] B);
        double circlePerimeterBox { get; }
        double circleSquare(double Radius);
        double circleSquare(int[] A, int[] B);
        double circleSquareBox { get; }

    }
}
