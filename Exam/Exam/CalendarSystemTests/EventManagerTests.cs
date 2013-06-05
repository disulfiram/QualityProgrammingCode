namespace CalendarSystemTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CompanyCalendarSystem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Wintellect.PowerCollections;
    using MD = Wintellect.PowerCollections.MultiDictionary<string, CompanyCalendarSystem.Event>;
    
    [TestClass]
    public class EventManagerTests
    {
        [TestMethod]
        public void AddEvent_OneEventSame()
        {
            EventManagerFast testManager = new EventManagerFast();
            Event expected = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            testManager.AddEvent(expected);
            List<Event> eventList = testManager.ListEvents(DateTime.Parse("2000-01-01T01:00:00"), 1).ToList();
            Event actual = eventList[0];
            Assert.AreSame(expected, actual);
        }

        [TestMethod]
        public void AddEvent_OneEventCount()
        {
            EventManagerFast testManager = new EventManagerFast();
            Event testEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            testManager.AddEvent(testEvent);
            MD eventList = testManager.EventList;
            int actual = eventList.Count;
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void AddEvent_OneEvent()
        {
            EventManagerFast testManager = new EventManagerFast();
            Event testEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            testManager.AddEvent(testEvent);
            List<Event> actual = testManager.ListEvents(DateTime.Parse("2000-01-01T01:00:00"), 1).ToList();
            Assert.AreSame(testEvent, actual[0]);
        }
        
        [TestMethod]
        public void DeleteEvent_OneEvent()
        {
            EventManagerFast testManager = new EventManagerFast();
            Event testEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            testManager.AddEvent(testEvent);
            testManager.DeleteEventsByTitle("party Viki");
            MD eventList = testManager.EventList;
            int actual = eventList.Count;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEvent_SeveralReturn()
        {
            EventManagerFast testManager = new EventManagerFast();
            Event firstTestEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            Event secondTestEvent = new Event(DateTime.Parse("2012-03-26T09:00:00"), "Party Viki");
            Event thirdTestEvent = new Event(DateTime.Parse("2013-03-29T10:00:00"), "viki Party", "Home");
            Event forthTestEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            Event fifthTestEvent = new Event(DateTime.Parse("2014-03-01T01:20:30"), "Birthday", "Park");
            testManager.AddEvent(firstTestEvent);
            testManager.AddEvent(firstTestEvent);
            testManager.AddEvent(secondTestEvent);
            testManager.AddEvent(thirdTestEvent);
            testManager.AddEvent(forthTestEvent);
            testManager.AddEvent(fifthTestEvent);
            int actual = testManager.DeleteEventsByTitle("party Viki");
            List<Event> eventList = testManager.ListEvents(DateTime.Parse("2000-01-01T01:00:00"), 1).ToList();
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEvent_SeveralCount()
        {
            EventManagerFast testManager = new EventManagerFast();
            Event firstTestEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            Event secondTestEvent = new Event(DateTime.Parse("2012-03-26T09:00:00"), "Party Viki");
            Event thirdTestEvent = new Event(DateTime.Parse("2013-03-29T10:00:00"), "viki Party", "Home");
            Event forthTestEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            Event fifthTestEvent = new Event(DateTime.Parse("2014-03-01T01:20:30"), "Birthday", "Park");
            testManager.AddEvent(firstTestEvent);
            testManager.AddEvent(firstTestEvent);
            testManager.AddEvent(secondTestEvent);
            testManager.AddEvent(thirdTestEvent);
            testManager.AddEvent(forthTestEvent);
            testManager.AddEvent(fifthTestEvent);
            testManager.DeleteEventsByTitle("party Viki");
            MD eventList = testManager.EventList;
            int actual = eventList.Count;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEvent_OneEventWithZeroEvents()
        {
            EventManagerFast testManager = new EventManagerFast();
            testManager.DeleteEventsByTitle("party Viki");
            MD eventList = testManager.EventList;
            int actual = eventList.Count;
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void ListEvents_EmptyList()
        {
            EventManagerFast testManager = new EventManagerFast();
            List<Event> eventList = testManager.ListEvents(DateTime.Parse("2014-03-01T01:20:30"), 10).ToList();
            int actual = eventList.Count;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListEvents_NoResults()
        {
            EventManagerFast testManager = new EventManagerFast();
            Event firstTestEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            Event secondTestEvent = new Event(DateTime.Parse("2012-03-26T09:00:00"), "Party Viki");
            Event thirdTestEvent = new Event(DateTime.Parse("2013-03-29T10:00:00"), "viki Party", "Home");
            Event forthTestEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            Event fifthTestEvent = new Event(DateTime.Parse("2014-03-01T01:20:30"), "Birthday", "Park");
            testManager.AddEvent(firstTestEvent);
            testManager.AddEvent(firstTestEvent);
            testManager.AddEvent(secondTestEvent);
            testManager.AddEvent(thirdTestEvent);
            testManager.AddEvent(forthTestEvent);
            testManager.AddEvent(fifthTestEvent);
            List<Event> eventList = testManager.ListEvents(DateTime.Parse("2014-04-01T01:20:30"), 10).ToList();
            int actual = eventList.Count;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListEvents_FourResults()
        {
            EventManagerFast testManager = new EventManagerFast();
            Event firstTestEvent = new Event(DateTime.Parse("2000-01-01T01:20:30"), "party Viki", "home");
            Event secondTestEvent = new Event(DateTime.Parse("2012-03-26T09:00:00"), "Party Viki");
            Event thirdTestEvent = new Event(DateTime.Parse("2000-01-01T01:20:30"), "viki Party", "Home");
            Event forthTestEvent = new Event(DateTime.Parse("2000-01-01T01:00:00"), "party Viki", "home");
            Event fifthTestEvent = new Event(DateTime.Parse("2000-01-01T01:20:30"), "Birthday", "Park");
            testManager.AddEvent(firstTestEvent);
            testManager.AddEvent(firstTestEvent);
            testManager.AddEvent(secondTestEvent);
            testManager.AddEvent(thirdTestEvent);
            testManager.AddEvent(forthTestEvent);
            testManager.AddEvent(fifthTestEvent);
            List<Event> eventList = testManager.ListEvents(DateTime.Parse("2000-01-01T01:20:30"), 2).ToList();
            int actual = eventList.Count;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}