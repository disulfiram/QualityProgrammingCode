namespace CompanyCalendarSystem
{
    using System;
    using System.Text;

    public class CalendarSystem
    {
        public static void Main()
        {
            var eventManager = new EventManager();
            var commandProcessor = new CommandProcessor(eventManager);
            StringBuilder output = new StringBuilder();

            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput == "End" || commandInput == null)
                {
                    Console.WriteLine(output);
                    break;
                }

                try
                {
                    output.AppendLine(commandProcessor.ProcessCommand(Command.Parse(commandInput)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}