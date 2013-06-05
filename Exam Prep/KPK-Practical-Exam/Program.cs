namespace FreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class Program
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();

            foreach (ICommand item in ParseCommand())
            {
                commandExecutor.ExecuteCommand(catalog, item, output); //this is how we do
            }

            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(output); //printing the output
        }

        private static List<ICommand> ParseCommand()
        {
            List<ICommand> commandsList = new List<ICommand>();
            bool end = false;

            do
            {
                string input = Console.ReadLine();
                end = (input.Trim() == "End");
                if (!end)
                {
                    commandsList.Add(new Command(input));
                }
            }
            while (!end);

            return commandsList;
        }
    }
}