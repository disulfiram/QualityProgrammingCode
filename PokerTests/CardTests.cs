namespace PokerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void JackOfDiamondsToString()
        {
            CardFace face = CardFace.Jack;
            CardSuit suit = CardSuit.Diamonds;
            Card jackOfDiamonds = new Card(face, suit);
            string actual = jackOfDiamonds.ToString();
            string expected = "Jack of Diamonds";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QueenOfSpadesToString()
        {
            CardFace face = CardFace.Queen;
            CardSuit suit = CardSuit.Spades;
            Card jackOfDiamonds = new Card(face, suit);
            string actual = jackOfDiamonds.ToString();
            string expected = "Queen of Spades";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AceOfSpadesToString()
        {
            CardFace face = CardFace.Ace;
            CardSuit suit = CardSuit.Spades;
            Card jackOfDiamonds = new Card(face, suit);
            string actual = jackOfDiamonds.ToString();
            string expected = "Ace of Spades";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoOfClubsToString()
        {
            CardFace face = CardFace.Two;
            CardSuit suit = CardSuit.Clubs;
            Card jackOfDiamonds = new Card(face, suit);
            string actual = jackOfDiamonds.ToString();
            string expected = "Two of Clubs";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QueenOfHeartsToString()
        {
            CardFace face = CardFace.Queen;
            CardSuit suit = CardSuit.Hearts;
            Card jackOfDiamonds = new Card(face, suit);
            string actual = jackOfDiamonds.ToString();
            string expected = "Queen of Hearts";
            Assert.AreEqual(expected, actual);
        }
    }
}