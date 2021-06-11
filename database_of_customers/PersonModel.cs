using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace database_of_customers
{
    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("Förnamn")]
        public string FirstName { get; set; }
        [BsonElement("Efternamn")]
        public string LastName { get; set; }
        [BsonElement("Personnummer")]
        public string socialSecurityNumber { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Mobilnummer kopplat till Swish")]
        public string swishNumber { get; set; }
        public AddressModel Address { get; set; }
    }
}
