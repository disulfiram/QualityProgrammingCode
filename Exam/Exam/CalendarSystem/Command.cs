namespace CompanyCalendarSystem
{
    using System;

    public struct Command
    {
        public string Name { get; set; }

        public string[] Parameters { get; set; }

        public static Command Parse(string commandInput)
        {
            int commandSeparator = commandInput.IndexOf(' ');
            if (commandSeparator == -1)
            {
                throw new FormatException("Invalid command: " + commandInput);
            }

            string commandName = commandInput.Substring(0, commandSeparator);
            string commandArgumentsJoined = commandInput.Substring(commandSeparator + 1);

            string[] commandArguments = commandArgumentsJoined.Split('|');
            for (int i = 0; i < commandArguments.Length; i++)
            {
                commandArgumentsJoined = commandArguments[i];
                commandArguments[i] = commandArgumentsJoined.Trim();
            }

            var command = new Command { Name = commandName, Parameters = commandArguments };

            return command;
        }
    }
}