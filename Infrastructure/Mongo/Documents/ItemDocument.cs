using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Mongo.Documents
{
    public class ItemDocument
    {
        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid Id { get; set; }
        public int Version { get; set; }
        public int Amount { get; set; }

    }
}
