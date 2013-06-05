namespace PokerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Poker;

    [TestClass]
    public class PokerHandsChckerTests
    {
        [TestMethod]
        public void ValidHand()
        {
            Hand validHand = new Hand(new List <ICard>
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Hearts),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(validHand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidHand()
        {
            Hand validHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Hearts),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(validHand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FlushHand()
        {
            Hand flushdHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(flushdHand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotFlushHand()
        {
            Hand flushdHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(flushdHand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourOfAKindFirst()
        {
            Hand fourOfAKindHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(fourOfAKindHand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourOfAKindSecond()
        {
            Hand fourOfAKindHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(fourOfAKindHand);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotFourOfAKind()
        {
            Hand flushdHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(flushdHand);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}