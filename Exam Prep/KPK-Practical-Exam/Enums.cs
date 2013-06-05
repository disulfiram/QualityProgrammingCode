namespace FreeContent
{
    using System;

    public enum CommandType
    {
        AddBook,
        AddMovie,
        AddSong,
        AddApplication,
        Update,
        Find,
    }

    public enum ContentType
    {
        Book,
        Film,
        Song,
        Application,
    }

    public enum acpi
    {
        Title = 0,
        Author,
        Size,
        Url,
    }
}