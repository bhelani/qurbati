/*using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Group;
public class GroupDbSetting{
    //Id is my unique identifier (Bson allows us to use multiple databases and give the elements still unique Ids)
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    [BsonElement("Name")]
    public string Name { get; set; }
    public double TotalPoints { get; set; }
    public List<int> Members { get; set; }
    public int OwnerId { get; set; }
}*/