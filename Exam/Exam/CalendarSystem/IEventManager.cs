namespace CompanyCalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Interface for working with events.
    /// </summary>
    public interface IEventsManager
    {
        /// <summary>
        /// Adds new event to calendar.
        /// </summary>
        /// <param name="eventToAdd">Event to be added.</param>
        void AddEvent(Event eventToAdd);
        
        /// <summary>
        /// Deletes all events with a certain title.
        /// </summary>
        /// <param name="eventTitle">Title of events to be deleted.</param>
        /// <returns>The number of events that have been deleted.</returns>
        int DeleteEventsByTitle(string eventTitle);

        /// <summary>
        /// Finds and list a number of <seealso cref="CalendarSystem.Event">events</seealso> from the calendar.
        /// </summary>
        /// <remarks>Searches events by date</remarks>
        /// <param name="date">Date to search for.</param>
        /// <param name="amountOfEventsToList">Amount of events to search for.</param>
        /// <returns>Collection of events on the date that has been searched for.</returns>
        /// <remarks>There will be no more events in the collection than the ammount of events are wanted.</remarks>
        IEnumerable<Event> ListEvents(DateTime date, int amountOfEventsToList);
    }
}