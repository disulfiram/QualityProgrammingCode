using System;

namespace SimpleBenchmark
{
    public class AddMethods
    {
        public static void AddInt(int addNumber)
        {
            int sum = 0;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                sum += addNumber;
            }
        }

        public static void AddLong(long addNumber)
        {
            long sum = 0L;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                sum += addNumber;
            }
        }

        public static void AddFloat(float addNumber)
        {
            float sum = 0.0f;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                sum += addNumber;
            }
        }

        public static void AddDouble(double addNumber)
        {
            double sum = 0.0d;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                sum += addNumber;
            }
        }

        public static void AddDecimal(decimal addNumber)
        {
            decimal sum = 0.0m;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                sum += addNumber;
            }
        }
    }
}