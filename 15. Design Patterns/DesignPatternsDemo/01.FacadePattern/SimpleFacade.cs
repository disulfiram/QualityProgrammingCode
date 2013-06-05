using System;

namespace FacadePattern
{
    public class SimpleFacade
    {
        private SubSystemOne one;
        private SubSystemThree three;
        private SubSystemFive five;

        public SimpleFacade()
        {
            this.one = new SubSystemOne();
            this.three = new SubSystemThree();
            this.five = new SubSystemFive();
        }

        public void FacadeMethod()
        {
            Console.WriteLine("Facade Called!\n");

            one.MethodOne();
            three.MethodThree();
            five.MethodFive();
        }
    }
}
