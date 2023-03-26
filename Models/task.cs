using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
namespace TaskCollectionApi.Models;
public class TaskModel{
    //Id is my unique identifier (Bson allows us to use multiple databases and give the elements still unique Ids)
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    [BsonElement("Title")]
    public string Title { get; set; }
    //public DateTime Duration { get; set; }
    //public string Content { get; set; }
    //public double Reward { get; set; }
    //public int Priority { get; set; }
    //public string Status { get; set; }
}