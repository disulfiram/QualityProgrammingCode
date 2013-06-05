namespace Abstraction
{
    using System;

    /// <summary>
    /// Rectangle figure class.
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// Width of the rectangle.
        /// </summary>
        private double width;

        /// <summary>
        /// Height of the rectangle.
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the Rectangle class.
        /// </summary>
        public Rectangle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rectangle class.
        /// </summary>
        /// <param name="width">Width of the rectangle.</param>
        /// <param name="height">Height of the rectangle.</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets width of rectangle.
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be zero or less.");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets height of rectangle.
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (0 >= value)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be zero or less.");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Calculates perimeter of rectangle.
        /// </summary>
        /// <returns>Perimeter of rectangle.</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        /// Calculates surface area of rectangle.
        /// </summary>
        /// <returns>Surface area of rectangle.</returns>
        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}