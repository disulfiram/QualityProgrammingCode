using System;
using Cooking;

namespace IfStatements
{
    class IfStatements
    {
        const int MinX = 0;
        const int MaxX = 100;

        const int MinY = 0;
        const int MaxY = 100;

        static void Main(string[] args)
        {
            Potato potato = new Potato();
            //... 
            if (potato != null)
            {
                if (potato.IsPeeled && potato.IsFresh)
                {
                    Cook(potato);
                }
            }

            int x = 50;
            int y = 50;

            bool isXInRange = (MinX <= x && x <= MaxX);
            bool isYInRange = (MinY <= y && y <= MaxY);

            bool shouldVisitCell = true;

            if (isXInRange && isYInRange && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}