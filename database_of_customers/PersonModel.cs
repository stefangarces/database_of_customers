using MongoDB.Bson.Serialization.Attributes;
using System;

namespace database_of_customers
{
    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Email { get; set; }
        public string SwishNumber { get; set; }
        public AddressModel Address { get; set; }
    }
}
