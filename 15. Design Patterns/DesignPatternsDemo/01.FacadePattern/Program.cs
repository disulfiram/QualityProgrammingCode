using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Without a Facade
            //SubSystemOne one = new SubSystemOne();
            //one.MethodOne();
            //SubSystemThree three = new SubSystemThree();
            //three.MethodThree();
            //SubSystemFive five = new SubSystemFive();
            //five.MethodFive();


            ////With a Facade
            SimpleFacade facade = new SimpleFacade();
            facade.FacadeMethod();
        }
    }
}
