namespace Web.Models
{
    using System;
    using Persist;

    public class VehicleEvent : IDocument
    {
        public Guid Id { get; set; }

        public DateTime When { get; set; }

        public string VIN { get; set; }
    }
}