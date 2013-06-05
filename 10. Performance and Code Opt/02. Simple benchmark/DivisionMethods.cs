using System;

namespace SimpleBenchmark
{
    public class DivisionMethods
    {
        public static void DivisionInt(int divideNumber)
        {
            int ratio = 1000;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                ratio /= divideNumber;
            }
        }

        public static void DivisionLong(long divideNumber)
        {
            long ratio = 1000L;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                ratio /= divideNumber;
            }
        }

        public static void DivisionFloat(float divideNumber)
        {
            float ratio = 1000.0f;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                ratio /= divideNumber;
            }
        }
        
        public static void DivisionDouble(double divideNumber)
        {
            double ratio = 1000.0d;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                ratio /= divideNumber;
            }
        }

        public static void DivisionDecimal(decimal divideNumber)
        {
            decimal ratio = 1000.0m;
            for (int i = 0; i < BenchmarkProgram.Cicles; i++)
            {
                ratio /= divideNumber;
                Console.WriteLine(ratio);
            }
            Console.WriteLine(ratio);
        }
    }
}