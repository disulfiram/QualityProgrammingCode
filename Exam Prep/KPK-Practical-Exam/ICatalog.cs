namespace FreeContent
{
    using System;
    using System.Collections.Generic;
    
    public interface ICatalog
    {
        void Add(IContent content);

        IEnumerable<IContent> GetListContent(string title, Int32 numberOfContentElementsToList);

        Int32 UpdateContent(string oldUrl, string newUrl);
    }
}