using System;

namespace Loop
{
    class Loop
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];

            int index = 0;
            int expectedValue = 25;

            for (index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
                if (index % 10 == 0)
                {
                    if (array[index] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
            }
        }
    }
}