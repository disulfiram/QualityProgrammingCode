using System;
using System.Diagnostics;

namespace ComplexBenchmark
{
    class BenchmarkProgram
    {
        public const int Cicles = 9999;

        static void DisplayExecutionTime(Action method, string typeInfo)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            method();
            stopwatch.Stop();
            Console.WriteLine(typeInfo + " - " + stopwatch.Elapsed);
        }
        
        static void Main(string[] args)
        {
            Console.Title = "Benchmarks for sqrt, ln and sin.";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CompareSqrt();
            CompareLN();
            CompareSin();
     
            stopwatch.Stop();
            Console.WriteLine("Time elapsed for the benchmark: {0}", stopwatch.Elapsed);
        }

        private static void CompareSin()
        {
            Console.WriteLine("* * * Sin * * *");

            DisplayExecutionTime(() =>
            {
                SinMethods.SinFloat(Cicles);
            }, "Float");

            DisplayExecutionTime(() =>
            {
                SinMethods.SinDouble(Cicles);
            }, "Double");

            DisplayExecutionTime(() =>
            {
                SinMethods.SinDeciaml(Cicles);
            }, "Decimal");

            Console.WriteLine();
        }

        private static void CompareLN()
        {
            Console.WriteLine("* * * ln * * *");
            
            DisplayExecutionTime(() =>
            {
                LnMethods.LnFloat(Cicles);
            }, "Float");

            DisplayExecutionTime(() =>
            {
                LnMethods.LnDouble(Cicles);
            }, "Double");

            DisplayExecutionTime(() =>
            {
                LnMethods.LnDecimal(Cicles);
            }, "Decimal");

            Console.WriteLine();
        }

        private static void CompareSqrt()
        {
            Console.WriteLine("* * * SQRT * * *");

            DisplayExecutionTime(() =>
            {
                SqrtMethods.SqrtFloat(Cicles);
            }, "Float");

            DisplayExecutionTime(() =>
            {
                SqrtMethods.SqrtDouble(Cicles);
            }, "Double");

            DisplayExecutionTime(() =>
            {
                SqrtMethods.SqrtDecimal(Cicles);
            }, "Decimal");

            Console.WriteLine();
        }
    }
}