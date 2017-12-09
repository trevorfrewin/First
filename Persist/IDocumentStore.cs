namespace Persist
{
    using System;
    using System.Collections.Generic;
    
    public interface IDocumentStore
    {
        void Command(IDocument document);

        IEnumerable<IDocument> Query(Predicate<IDocument> predicate);
    }
}