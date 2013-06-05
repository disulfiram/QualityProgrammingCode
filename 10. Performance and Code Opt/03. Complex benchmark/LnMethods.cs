using System;

namespace ComplexBenchmark
{
    class LnMethods
    {
        public static void LnFloat(int cicles)
        {
            for (float i = 0; i < cicles; i++)
            {
                Math.Log(i);
            }
        }

        public static void LnDouble(int cicles)
        {
            for (double i = 0; i < cicles; i++)
            {
                Math.Log(i);
            }
        }

        public static void LnDecimal(int cicles)
        {
            for (decimal i = 0; i < cicles; i++)
            {
                Math.Log((double)i);
            }
        }
    }
}