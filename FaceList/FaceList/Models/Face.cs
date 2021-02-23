using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FaceList.Models
{
    public class Face
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string UserName { get; set; }

        [BsonElement("TelegramID")]
        public string TGID { get; set; }

        [BsonElement("Joined")]
        public string DateJoined { get; set; }
    }
}
