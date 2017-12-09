namespace Web.Models
{
    using System;
    using Persist;

    public class SampleDocument : IDocument
    {
        public Guid Id { get; set; }

        public string Property { get; set; }
    }
}