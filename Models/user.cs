using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using UserCollectionApi.Models;


namespace User;
public class UserDbSetting
{
    //Id is my unique identifier (Bson allows us to use multiple databases and give the elements still unique Ids)
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Email { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; }
    public string Password { get; set; }
    public double Points { get; set; }
    public string Token { get; set; }
}