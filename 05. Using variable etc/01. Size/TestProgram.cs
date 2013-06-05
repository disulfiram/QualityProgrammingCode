using System;

class TestProgram
{
    static void Main()
    {
        Console.Write("Shape width: ");
        double width;
        double.TryParse(Console.ReadLine(), out width);

        Console.Write("Shape height: ");
        double height;
        double.TryParse(Console.ReadLine(), out height);

        Console.Write("Rotation angle in radians: ");
        double rotationAngle;
        double.TryParse(Console.ReadLine(), out rotationAngle);

        Shape testShape = new Shape(width, height);

        Shape rotatedShape = testShape.GetRotatedSize(rotationAngle);
        Console.WriteLine(rotatedShape.ToString());
    }
}