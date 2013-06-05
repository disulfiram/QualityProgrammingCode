namespace CompanyCalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;
    using MD = Wintellect.PowerCollections.MultiDictionary<string, CompanyCalendarSystem.Event>;

    public class EventManagerFast : IEventsManager
    {
        internal readonly MD EventList = new MD(true);
        internal readonly OrderedMultiDictionary<DateTime, Event> OrderedEventsList =
            new OrderedMultiDictionary<DateTime, Event>(true);

        public void AddEvent(Event eventToAdd)
        {
            string eventTitleLowerCase = eventToAdd.Title.ToLowerInvariant();
            this.EventList.Add(eventTitleLowerCase, eventToAdd);
            this.OrderedEventsList.Add(eventToAdd.Date, eventToAdd);
        }

        public int DeleteEventsByTitle(string title)
        {
            string lowerCaseTitle = title.ToLowerInvariant();
            var eventsPendingDeletion = this.EventList[lowerCaseTitle];
            int numberOfEventsBiengDeleted = eventsPendingDeletion.Count;

            foreach (var calendarEvent in eventsPendingDeletion)
            {
                this.OrderedEventsList.Remove(calendarEvent.Date, calendarEvent);
            }

            this.EventList.Remove(lowerCaseTitle);

            return numberOfEventsBiengDeleted;
        }

        public IEnumerable<Event> ListEvents(DateTime date, int amountToList)
        {
            var eventsToList =
                              from calendarEvent in this.OrderedEventsList.RangeFrom(date, true).Values
                              select calendarEvent;
            var events = eventsToList.Take(amountToList);
            return events;
        }
    }
}