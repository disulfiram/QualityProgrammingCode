namespace FreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog contentCatalog, ICommand command, StringBuilder output)
        {
            switch (command.Type)
            {
                case CommandType.AddBook:
                    contentCatalog.Add(new Content(ContentType.Book, command.Parameters));
                    output.AppendLine("Book Added");
                    break;
                case CommandType.AddMovie:
                    contentCatalog.Add(new Content(ContentType.Film, command.Parameters));
                    output.AppendLine("Movie added");
                    break;
                case CommandType.AddSong:
                    contentCatalog.Add(new Content(ContentType.Song, command.Parameters));
                    output.AppendLine("Song added");
                    break;
                case CommandType.AddApplication:
                    contentCatalog.Add(new Content(ContentType.Application, command.Parameters));
                    output.AppendLine("Application added");
                    break;
                case CommandType.Update:
                    if (command.Parameters.Length != 2)
                    {
                        throw new FormatException("Invalid parameters!");
                    }
                    output.AppendLine(String.Format("{0} items updated", contentCatalog.UpdateContent(command.Parameters[0], command.Parameters[1])));
                    break;
                case CommandType.Find:
                    if (command.Parameters.Length != 2)
                    {
                        throw new FormatException("Invalid number of parameters!");
                    }

                    Int32 numberOfElementsToList = Int32.Parse(command.Parameters[1]);

                    IEnumerable<IContent> foundContent = contentCatalog.GetListContent(command.Parameters[0], numberOfElementsToList);

                    if (foundContent.Count() == 0)
                    {
                        output.AppendLine("No items found");
                    }
                    else
                    {
                        foreach (IContent content in foundContent)
                        {
                            output.AppendLine(content.TextRepresentation);
                        }
                    }

                    break;
                default:
                    throw new InvalidCastException("Unknown command!");
            }
        }
    }
}