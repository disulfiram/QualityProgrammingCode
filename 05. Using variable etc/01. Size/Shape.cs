using System;
using System.Text;

/// <summary>
/// Shape class
/// </summary>
public class Shape
{
    /// <summary>
    /// Width of shape.
    /// </summary>
    private double width;

    /// <summary>
    /// Height of shape.
    /// </summary>
    private double height;

    /// <summary>
    /// Initializes a new instance of the Shape class.
    /// </summary>
    /// <param name="width">Width of shape.</param>
    /// <param name="height">Height of shape.</param>
    public Shape(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    /// <summary>
    /// Gets or sets width of shape.
    /// </summary>
    public double Width
    {
        get
        {
            return this.width;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Dimensions cannot be negative.");
            }

            this.width = value;
        }
    }

    /// <summary>
    /// Gets or sets height of shape.
    /// </summary>
    public double Height
    {
        get
        {
            return this.height;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Dimensions cannot be negative.");
            }

            this.height = value;
        }
    }

    /// <summary>
    /// Rotates a shape to get new width and height.
    /// </summary>
    /// <param name="figureToRotate">Shape to be rotated.</param>
    /// <param name="angleOfRotation">Angle of rotation.</param>
    /// <returns>New shape with dimensions of the rotated shape.</returns>
    public Shape GetRotatedSize( double angleOfRotation)
    {
        double cosinus = Math.Abs(Math.Cos(angleOfRotation));
        double sinus = Math.Abs(Math.Sin(angleOfRotation));

        double widthAfterRotation = (cosinus * this.Width) + (sinus * this.Height);
        double heightAfterRotation = (sinus * this.Width) + (cosinus * this.Height);

        Shape rotatedShape = new Shape(widthAfterRotation, heightAfterRotation);
        return rotatedShape;
    }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendFormat("Shape dimensions:\n");
        output.AppendFormat("Width: {0}\n", this.Width);
        output.AppendFormat("Height: {0}", this.Height);
        return output.ToString();
    }
}