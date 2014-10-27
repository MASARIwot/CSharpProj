using System;
namespace HomeTask4
{
    public interface IFigure
    {
        double hexagonSquare(double AB);
        double hexagonSquare(int[] A, int[] B);
        double hexagonSquareBox { get; }
        double rectanglePerimeter(int[] A, int[] B, int[] C);
        double rectanglePerimeterBox { get; }
        double rectangleSquare(double AB, double BC);
        double rectangleSquare(int[] A, int[] B, int[] C);
        double rectangleSquareBox { get; }
        double rhombusSquareBox { get; }
        double squarePerimeter(int[] A, int[] B);
        double squarePerimeterBox { get; }
        double squareSquare(double AB);
        double squareSquare(int[] A, int[] B);
        double squareSquareBox { get; }
        double trianglePerimeter(int[] A, int[] B, int[] C);
        double trianglePerimeterBox { get; }
        double triangleSquare(double AB);
        double triangleSquare(int[] A, int[] B);
        double triangleSquareBox { get; }
    }
}
