namespace CohesionAndCoupling
{
    using System;
    
    /// <summary>
    /// Utilities class for working with 3D objects
    /// </summary>
    public class Utils3D
    {
        /// <summary>
        /// Calculates volume of object.
        /// </summary>
        /// <param name="width">Width of object.</param>
        /// <param name="height">Height of object.</param>
        /// <param name="depth">Depth of object.</param>
        /// <returns>Volume of object.</returns>
        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        /// <summary>
        /// Calculates distance between two points in 3D environment.
        /// </summary>
        /// <param name="x1">X coordinate of first point.</param>
        /// <param name="y1">Y coordinate of first point.</param>
        /// <param name="z1">Z coordinate of first point.</param>
        /// <param name="x2">X coordinate of second point.</param>
        /// <param name="y2">Y coordinate of second point.</param>
        /// <param name="z2">Z coordinate of second point.</param>
        /// <returns>Distance between two points in 3D environment.</returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        /// <summary>
        /// Calculates diagonal in 3D object.
        /// </summary>
        /// <param name="width">Width of object.</param>
        /// <param name="height">Height of object.</param>
        /// <param name="depth">Depth of object.</param>
        /// <returns>Diagonal of object.</returns>
        public static double CalcDiagonal3D(double width, double height, double depth)
        {
            double distance = Math.Sqrt((width * width) + (height * height) + (depth * depth));
            return distance;
        }
    }
}