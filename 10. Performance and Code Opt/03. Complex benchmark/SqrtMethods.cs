using System;

namespace ComplexBenchmark
{
    class SqrtMethods
    {
        public static void SqrtFloat(int cicles)
        {
            for (float i = 0; i < cicles; i++)
            {
                Math.Sqrt(i);
            }
        }

        public static void SqrtDouble(int cicles)
        {
            for (double i = 0; i < cicles; i++)
            {
                Math.Sqrt(i);
            }
        }
        
        public static void SqrtDecimal(int cicles)
        {
            for (decimal i = 0; i < cicles; i++)
            {
                Math.Sqrt((double)i);
            }
        }
    }
}