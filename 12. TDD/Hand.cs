using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("* * * Hand * * *");
            byte length = (byte)this.Cards.Count;
            for (int i = 0; i < length; i++)
            {
                if (i < 4)
                {
                    result.AppendLine(this.Cards[i].ToString());
                }
                else
                {
                    result.Append(this.Cards[i].ToString());
                }
            }
            
            return result.ToString();
        }
    }
}