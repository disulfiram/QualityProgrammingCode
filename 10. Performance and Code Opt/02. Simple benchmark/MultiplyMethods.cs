using System;

namespace SimpleBenchmark
{
    public class MultiplyMethods
    {
        public static void MultiplyInt(int multiplyNumber)
        {
            int product = 1;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                product *= multiplyNumber;
            }
        }

        public static void MultiplyLong(long multiplyNumber)
        {
            long product = 1L;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                product *= multiplyNumber;
            }
        }

        public static void MultiplyFloat(float multiplyNumber)
        {
            float product = 1.0f;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                product *= multiplyNumber;
            }
        }

        public static void MultiplyDouble(double multiplyNumber)
        {
            double product = 1.0d;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                product *= multiplyNumber;
            }
        }

        public static void MultiplyDecimal(decimal multiplyNumber)
        {
            decimal product = 1.0m;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                product *= multiplyNumber;
            }
        }
    }
}