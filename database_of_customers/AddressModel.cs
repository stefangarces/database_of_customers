using MongoDB.Bson.Serialization.Attributes;

namespace database_of_customers
{
    public class AddressModel
    {
        [BsonElement("Gatunamn")]
        public string StreetAdress { get; set; }
        [BsonElement("Stad")]
        public string City { get; set; }
        [BsonElement("Postnummer")]
        public int ZipCode { get; set; }
    }
}
