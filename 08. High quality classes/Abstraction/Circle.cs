namespace Abstraction
{
    using System;
    
    /// <summary>
    /// Circle class
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Radius of circle.
        /// </summary>
        private double radius;

        /// <summary>
        /// Initializes a new instance of the Circle class.
        /// </summary>
        public Circle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Circle class.
        /// </summary>
        /// <param name="radius">Radius of circle.</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets radius of circle.
        /// </summary>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be zero or less.");
                }

                this.radius = value;
            }
        }

        /// <summary>
        /// Calculates perimeter of the circle.
        /// </summary>
        /// <returns>Radius of circle.</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Calculates surface of the circle.
        /// </summary>
        /// <returns>Returns surface of the circle.</returns>
        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}