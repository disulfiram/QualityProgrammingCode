namespace CompanyCalendarSystem
{
    using System;
    using System.Linq;
    
    public class Event : IComparable<Event>
    {
        public Event(DateTime date, string title)
        {
            this.Date = date;
            this.Title = title;
        }

        public Event(DateTime date, string title, string location) : this(date, title)
        {
            this.Location = location;
        }

        public string Title { get; set; }

        public string Location { get; set; }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            string format = "{0:yyyy-MM-ddTHH:mm:ss} | {1}";
            if (this.Location != null)
            {
                format += " | {2}";
            }

            string eventAsString = string.Format(format, this.Date, this.Title, this.Location);
            return eventAsString;
        }

        public int CompareTo(Event x)
        {
            int result = DateTime.Compare(this.Date, x.Date);
            foreach (char c in this.Title)
            {
                if (result == 0)
                {
                    result = string.Compare(this.Title, x.Title, StringComparison.Ordinal);
                }

                if (result == 0)
                {
                    result = string.Compare(this.Location, x.Location, StringComparison.Ordinal);
                }
            }

            return result;
        }
    }
}