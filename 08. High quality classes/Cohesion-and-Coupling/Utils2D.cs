namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Utilities class for working with 2D objects.
    /// </summary>
    public class Utils2D
    {
        /// <summary>
        /// Calculates distance between two points.
        /// </summary>
        /// <param name="x1">X coordinate of first point.</param>
        /// <param name="y1">Y coordinate of first point.</param>
        /// <param name="x2">X coordinate of second point.</param>
        /// <param name="y2">Y coordinate of second point.</param>
        /// <returns>Distance between points.</returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Calculates distance  in 2D object.
        /// </summary>
        /// <param name="width">Width of object.</param>
        /// <param name="height">Height of object.</param>
        /// <returns>Diagonal of object.</returns>
        public static double CalcDiagonal2D(double width, double height)
        {
            double distance = Math.Sqrt((width * width) + (height * height));
            return distance;
        }
    }
}