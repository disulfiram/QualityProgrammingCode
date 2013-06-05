using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsHomework
{
    class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("The array cannot be null!");
            }
            else if (arr.Length <= 0)
            {
                throw new ArgumentOutOfRangeException("The array cannot be empty!");
            }
            else if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Start index cannot be negative!");
            }
            else if (startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("Number of elements in the subsequence cannot be bigger than length of the array!");
            }
            else if (count < 0)
            {
                throw new ArgumentOutOfRangeException("Number of elements in the subsequence cannot be negative!");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("Count of the ending symbols cannot be bigger than length of the string!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }
            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main()
        {
            try
            {
                var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
                Console.WriteLine(substr);

                var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
                Console.WriteLine(String.Join(" ", subarr));

                var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
                Console.WriteLine(String.Join(" ", allarr));

                var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
                Console.WriteLine(String.Join(" ", emptyarr));

                var emptyarrException = Subsequence(new int[] { -1, 3, 2, 1 }, -1, 0);
                Console.WriteLine(String.Join(" ", emptyarr));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine(ExtractEnding("I love C#", 2));
                Console.WriteLine(ExtractEnding("Nakov", 4));
                Console.WriteLine(ExtractEnding("beer", 4));
                Console.WriteLine(ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                bool isPrime = CheckPrime(23);
                Console.WriteLine("23 is prime. -->{0}", isPrime);

                isPrime = CheckPrime(33);
                Console.WriteLine("33 is prime. -->{0}", isPrime);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                List<Exam> peterExams = new List<Exam>()
                {
                    new SimpleMathExam(2),
                    new CSharpExam(55),
                    new CSharpExam(100),
                    new SimpleMathExam(1),
                    new CSharpExam(0),
                };

                Student peter = new Student("Peter", "Petrov", peterExams);
                double peterAverageResult = peter.CalcAverageExamResultInPercents();
                Console.WriteLine("Average results = {0:p0}", peterAverageResult);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}