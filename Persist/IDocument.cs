namespace Persist
{
    using System;
    using MongoDB.Bson.Serialization.Attributes;

    public interface IDocument
    {
        [BsonId]
        Guid Id { get; set; }
    }
}