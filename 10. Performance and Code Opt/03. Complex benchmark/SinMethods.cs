using System;

namespace ComplexBenchmark
{
    class SinMethods
    {
        public static void SinFloat(int cicles)
        {
            for (float i = 0; i < cicles; i++)
            {
                Math.Sin(i);
            }
        }

        public static void SinDouble(int cicles)
        {
            for (double i = 0; i < cicles; i++)
            {
                Math.Sin(i);
            }
        }

        public static void SinDeciaml(int cicles)
        {
            for (decimal i = 0; i < cicles; i++)
            {
                Math.Sin((double)i);
            }
        }
    }
}