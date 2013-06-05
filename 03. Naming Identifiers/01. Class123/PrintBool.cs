using System;

class PrintBool
{
    const int MAX_COUNT = 6;

    class MethodForPrinting
    {
        public void PrintBoolOnConsole(bool inputBool)
        {
            string inputBoolAsString = inputBool.ToString();
            Console.WriteLine(inputBoolAsString);
        }
    }

    public static void Main()
    {
        PrintBool.MethodForPrinting instance = new PrintBool.MethodForPrinting();
        instance.PrintBoolOnConsole(true);
    }
}