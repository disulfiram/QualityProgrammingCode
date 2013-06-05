namespace Abstraction
{
    using System;
    
    /// <summary>
    /// Abstract figure class.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Calculates perimeter of figure.
        /// </summary>
        /// <returns>Perimeter of figure.</returns>
        public abstract double CalcPerimeter();

        /// <summary>
        /// Calculates surface area of figure.
        /// </summary>
        /// <returns>Surface area of figure.</returns>
        public abstract double CalcSurface();
    }
}