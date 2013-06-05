using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SiteStructure oneSite = SiteStructure.Instance; //create an instance of the class
            string test = "Test";
            oneSite.AddObject(test); //add an object in the class
            SiteStructure otherSite = SiteStructure.Instance; //create another instance of the class

            //Two referances to a single instance of the class.
            Console.WriteLine(oneSite.ToString());
            Console.WriteLine(otherSite.ToString());
        }
    }
}