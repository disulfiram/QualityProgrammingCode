using System;

namespace SimpleBenchmark
{
    public class SubtractMethods
    {
        public static void SubtractInt(int subtractNumber)
        {
            int difference = 0;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                difference -= subtractNumber;
            }
        }

        public static void SubtractLong(long subtractNumber)
        {
            long difference = 0L;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                difference -= subtractNumber;
            }
        }

        public static void SubtractFloat(float subtractNumber)
        {
            float difference = 0.0f;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                difference -= subtractNumber;
            }
        }

        public static void SubtractDouble(double subtractNumber)
        {
            double difference = 0.0d;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                difference -= subtractNumber;
            }
        }

        public static void SubtractDecimal(decimal subtractNumber)
        {
            decimal difference = 0.0m;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                difference -= subtractNumber;
            }
        }
    }
}