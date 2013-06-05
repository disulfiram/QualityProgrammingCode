using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool result = true;
            byte length = (byte)hand.Cards.Count;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            bool result = false;
            byte length = (byte)hand.Cards.Count;
            byte counter;
            for (int i = 0; i < length - 3; i++)
            {
                counter = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        counter++;
                    }
                }
                if (counter == 4)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            bool result = true;
            byte length = (byte)hand.Cards.Count;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (hand.Cards[i].Suit != hand.Cards[j].Suit)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}