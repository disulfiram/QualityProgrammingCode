namespace CompanyCalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EventManager : IEventsManager
    {
        private readonly List<Event> eventsList = new List<Event>();

        public void AddEvent(Event eventToAdd)
        {
            this.eventsList.Add(eventToAdd);
        }

        public int DeleteEventsByTitle(string eventTitle)
        {
            return this.eventsList.RemoveAll(
                calendarEvent => calendarEvent.Title.ToLowerInvariant() == eventTitle.ToLowerInvariant());
        }

        public IEnumerable<Event> ListEvents(DateTime date, int amountToList)
        {
            return (from calendarEvent in this.eventsList
                    where calendarEvent.Date >= date
                    orderby calendarEvent.Date, calendarEvent.Title, calendarEvent.Location
                    select calendarEvent).Take(amountToList);
        }
    }
}