using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            //I don't know much about exception handling. I assume what I've done here is not the way to go.
            try
            {
                Console.WriteLine(Utils.GetFileExtension("example"));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(Utils.GetFileExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(Utils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Utils2D.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Utils3D.CalcDistance3D(5, 2, -1, 3, -6, 4));

            int width = 3;
            int height = 4;
            int depth = 5;
            Console.WriteLine("Volume = {0:f2}", Utils3D.CalcVolume(width, height, depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Utils3D.CalcDiagonal3D(width, height, depth));
            Console.WriteLine("Diagonal XY = {0:f2}", Utils2D.CalcDiagonal2D(width, height));
            Console.WriteLine("Diagonal XZ = {0:f2}", Utils2D.CalcDiagonal2D(height, width));
            Console.WriteLine("Diagonal YZ = {0:f2}", Utils2D.CalcDiagonal2D(width, depth));
        }
    }
}