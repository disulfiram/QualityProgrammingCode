namespace CompanyCalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class CommandProcessor
    {
        private readonly IEventsManager eventManager;

        public CommandProcessor(IEventsManager eventManager)
        {
            this.eventManager = eventManager;
        }

        public IEventsManager EventsProcessor
        {
            get
            {
                return this.eventManager;
            }
        }

        public string ProcessCommand(Command command)
        {
            bool validCommand = true;
            
            switch (command.Name)
            {
                case "AddEvent":
                    if (command.Parameters.Length != 2 & command.Parameters.Length != 3)
                    {
                        break;
                    }

                    return this.AddEvent(command);
                    
                case "DeleteEvents":
                    if (command.Parameters.Length != 1)
                    {
                        break;
                    }

                    int c = this.eventManager.DeleteEventsByTitle(command.Parameters[0]);

                    if (c == 0)
                    {
                        return "No events found";
                    }

                    return c + " events deleted";
                case "ListEvents":
                    if (command.Parameters.Length != 2)
                    {
                        break;
                    }

                    DateTime date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                    int amountOfEvents = int.Parse(command.Parameters[1]);
                    List<Event> events = this.eventManager.ListEvents(date, amountOfEvents).ToList();
                    StringBuilder result = new StringBuilder();

                    if (!events.Any())
                    {
                        return "No events found";
                    }

                    foreach (var calendarEvent in events)
                    {
                        result.AppendLine(calendarEvent.ToString());
                    }

                    return result.ToString().Trim();
                default:
                    break;
            }

            if (!validCommand)
            {
                throw new ArgumentException("'" + command.Name + "'" + " requires different amount of parameters. {0} have been input.",
                                            command.Parameters.Length.ToString());
            }

            throw new Exception("'" + command.Name + "' not a valid command.");
        }

        private string AddEvent(Command command)
        {
            DateTime date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            string title = command.Parameters[1];
            string location = null;

            if (command.Parameters.Length == 3)
            {
                location = command.Parameters[2];
            }

            Event calendarEvent = new Event(date, title, location);
            this.eventManager.AddEvent(calendarEvent);
            return "Event added";
        }
    }
}