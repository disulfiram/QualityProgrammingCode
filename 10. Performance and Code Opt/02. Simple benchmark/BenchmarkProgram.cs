using System;
using System.Diagnostics;

namespace SimpleBenchmark
{
    public class BenchmarkProgram
    {
        public const int Cicles = 1000;

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
            Console.WriteLine("* * * Addition * * *");
            DisplayExecutionTime(() =>
            {
                AddMethods.AddInt(15);
            }, "Int");

            DisplayExecutionTime(() =>
            {
                AddMethods.AddLong(15L);
            }, "Long");

            DisplayExecutionTime(() =>
            {
                AddMethods.AddFloat(15.0f);
            }, "Float");

            DisplayExecutionTime(() =>
            {
                AddMethods.AddDouble(15.0d);
            }, "Double");

            DisplayExecutionTime(() =>
            {
                AddMethods.AddDecimal(15.0m);
            }, "Decimal");

            Console.WriteLine("* * * Subtraction * * *");
            DisplayExecutionTime(() =>
            {
                SubtractMethods.SubtractInt(15);
            }, "Int");

            DisplayExecutionTime(() =>
            {
                SubtractMethods.SubtractLong(15L);
            }, "Long");

            DisplayExecutionTime(() =>
            {
                SubtractMethods.SubtractFloat(15.0f);
            }, "Float");

            DisplayExecutionTime(() =>
            {
                SubtractMethods.SubtractDouble(15.0d);
            }, "Double");

            DisplayExecutionTime(() =>
            {
                SubtractMethods.SubtractDecimal(15.0m);
            }, "Decimal");
            Console.WriteLine();

            Console.WriteLine("* * * Incrementation * * *");
            DisplayExecutionTime(() =>
            {
                IncrementMethods.IncrementInt();
            }, "Int");

            DisplayExecutionTime(() =>
            {
                IncrementMethods.IncrementLong();
            }, "Long");

            DisplayExecutionTime(() =>
            {
                IncrementMethods.IncrementFloat();
            }, "Float");

            DisplayExecutionTime(() =>
            {
                IncrementMethods.IncrementDouble();
            }, "Double");

            DisplayExecutionTime(() =>
            {
                IncrementMethods.IncrementDecimal();
            }, "Decimal");
            Console.WriteLine();

            Console.WriteLine("* * * Multiplication * * *");
            DisplayExecutionTime(() =>
            {
                MultiplyMethods.MultiplyInt(5);
            }, "Int");

            DisplayExecutionTime(() =>
            {
                MultiplyMethods.MultiplyLong(5L);
            }, "Long");

            DisplayExecutionTime(() =>
            {
                MultiplyMethods.MultiplyFloat(5.0f);
            }, "Float");

            DisplayExecutionTime(() =>
            {
                MultiplyMethods.MultiplyDouble(5.0d);
            }, "Double");

            DisplayExecutionTime(() =>
            {
                MultiplyMethods.MultiplyDecimal(5.0m);
            }, "Decimal");
            Console.WriteLine();

            Console.WriteLine("* * * Division * * *");
            DisplayExecutionTime(() =>
            {
                DivisionMethods.DivisionInt(2);
            }, "Int");

            DisplayExecutionTime(() =>
            {
                DivisionMethods.DivisionLong(2L);
            }, "Long");

            DisplayExecutionTime(() =>
            {
                DivisionMethods.DivisionFloat(2.0f);
            }, "Float");

            DisplayExecutionTime(() =>
            {
                DivisionMethods.DivisionDouble(2.0d);
            }, "Double");
            DisplayExecutionTime(() =>
            {
                DivisionMethods.DivisionDecimal(2.0m);
            }, "Decimal");
            Console.WriteLine();
        }
    }
}