using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FreeContent;
using System.Linq;

namespace FeeContentTests
{
    [TestClass]
    public class CatalogTests
    {
        [TestMethod]
        [Timeout(100)]
        public void Add_SingleItem()
        {
            Catalog testCatalog = new Catalog();
            Content contentToAdd = new Content(ContentType.Song, new string[] { "One", "Metallica", "8771120", "http://goo.gl/dIkth7gs" });
            testCatalog.Add(contentToAdd);
            int actual = testCatalog.Count;
            
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Add_MultiItems()
        {
            Catalog testCatalog = new Catalog();
            Content firstContentToAdd = new Content(ContentType.Song, new string[] { "One", "Metallica", "8771120", "http://goo.gl/dIkth7gs" });
            Content secondContentToAdd = new Content(ContentType.Song, new string[] { "Two", "Metallica", "8771120", "http://goo.gl/dIkth7gs" });
            Content thirdContentToAdd = new Content(ContentType.Film, new string[] { "Three", "Lil B", "87711200", "http://goo.gl/dIkth7gs/2" });
            testCatalog.Add(firstContentToAdd);
            testCatalog.Add(secondContentToAdd);
            testCatalog.Add(thirdContentToAdd);
            int actual = testCatalog.Count;
            int expected = 3;
            Assert.AreEqual(actual, expected);
        }
    }
}