namespace PokerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void FullHouseToString()
        {
            Hand fullHouse = new Hand(new List <ICard>
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Hearts),
            });
            string actual = fullHouse.ToString();
            string expected = "* * * Hand * * *\r\nTwo of Clubs\r\nTwo of Diamonds\r\nThree of Clubs\r\nThree of Diamonds\r\nThree of Hearts";
            Assert.AreEqual(expected, actual);
        }
    }
}