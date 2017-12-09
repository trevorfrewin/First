namespace Persist
{
    using System;
    using System.Collections.Generic;
    using MongoDB.Driver;

    public class DocumentStore : IDocumentStore
    {
        public void Command(IDocument document)
        {
            var client = new MongoClient();

            var formattedDatabaseName = document.GetType().Assembly.GetName().Name.Replace('.', '_');
            var database = client.GetDatabase(formattedDatabaseName);
            
            var collection = database.GetCollection<IDocument>(document.GetType().Name);

            collection.InsertOneAsync(document).Wait();
        }

        public IEnumerable<IDocument> Query(Predicate<IDocument> predicate)
        {
            throw new NotImplementedException();
        }
    }
}