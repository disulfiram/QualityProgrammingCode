using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
    }

    /// <summary>
    /// Prints statistics on console.
    /// </summary>
    /// <param name="doubleArray">Array containing doubles.</param>
    /// <param name="arraySize">The length of the array.</param>
    public void PrintStatistics(double[] doubleArray, int arraySize)
    {
        double maxValue = FindMaxInArray(doubleArray, arraySize);
        Console.WriteLine("Maximum value in array is: {0}", maxValue);
           
        double minValue = FindMinInArray(doubleArray, arraySize);
        Console.WriteLine("Minimum value in array is: {0}", minValue);

        double average = FindAverageOfArray(doubleArray, arraySize);
        Console.WriteLine("Avarage value in array is: {0}", average);
    }

    /// <summary>
    /// Method for finding the average value in an array of doubles.
    /// </summary>
    /// <param name="doubleArray">Array containing doubles.</param>
    /// <param name="arraySize">The length of the array.</param>
    /// <returns>Average value in the array.</returns>
    private static double FindAverageOfArray(double[] doubleArray, int arraySize)
    {
        double sum = 0;
        for (int i = 0; i < arraySize; i++)
        {
            sum += doubleArray[i];
        }

        double average = sum / arraySize;
        return average;
    }

    /// <summary>
    /// Method for finding the minimal value in an array of doubles.
    /// </summary>
    /// <param name="doubleArray">Array containing doubles.</param>
    /// <param name="arraySize">The length of the array.</param>
    /// <returns>Minimum value in the array.</returns>
    private double FindMinInArray(double[] doubleArray, int arraySize)
    {
        double minValue = double.MaxValue;
        for (int index = 0; index < arraySize; index++)
        {
            if (doubleArray[index] < minValue)
            {
                minValue = doubleArray[index];
            }
        }
            
        return minValue;
    }

    /// <summary>
    /// Method for finding the maximum value in an array of doubles.
    /// </summary>
    /// <param name="doubleArray">Array containing doubles.</param>
    /// <param name="arraySize">The length of the array.</param>
    /// <returns>Maximum value in the array.</returns>
    private static double FindMaxInArray(double[] doubleArray, int arraySize)
    {
        double maxValue = double.MinValue;
        for (int index = 0; index < arraySize; index++)
        {
            if (doubleArray[index] > maxValue)
            {
                maxValue = doubleArray[index];
            }
        }
            
        return maxValue;
    }
}