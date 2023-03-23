using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TaskCollectionApi.Models;
public class TaskModel{
    //Id is my unique identifier (Bson allows us to use multiple databases and give the elements still unique Ids)
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Title { get; set; }
    public DateTime Duration { get; set; }
    public string Content { get; set; }
    public double Reward { get; set; }
    public int Priority { get; set; }
    public string Status { get; set; }
}