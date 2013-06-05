using System;

namespace SimpleBenchmark
{
    public class IncrementMethods
    {
        public static void IncrementInt()
        {
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
            }
        }

        public static void IncrementLong()
        {
            for (long i = 0; i < BenchmarkProgram.Cicles; i++)
            {
            }
        }

        public static void IncrementFloat()
        {
            for (float i = 0; i < BenchmarkProgram.Cicles; i++)
            {
            }
        }

        public static void IncrementDouble()
        {
            for (double i = 0; i < BenchmarkProgram.Cicles; i++)
            {
            }
        }

        public static void IncrementDecimal()
        {
            for (decimal i = 0; i < BenchmarkProgram.Cicles; i++)
            {
            }
        }
    }
}