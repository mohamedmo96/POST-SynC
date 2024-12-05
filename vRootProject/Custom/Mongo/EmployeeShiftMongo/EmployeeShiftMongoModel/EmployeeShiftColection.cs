using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Models.Business;
using System.ComponentModel.DataAnnotations.Schema;
using CoreLayer.Models.ProductTechnology.ProductActions;
using CoreLayer.Models.ProductTechnology;
using System.ComponentModel.DataAnnotations;
using CoreLayer.Models;

namespace vRootProject.Custom.Mongo.EmployeeShiftMongo.EmployeeShiftMongoModel
{

    public class EmployeeShiftColection
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int? EmployeeShiftId { get; set; }
        public DateTime? StartTime { get; set; } 
        public DateTime? EndTime { get; set; }
        public EmployeeShiftStatus? Status { get; set; } 
        public int? EmployeeId { get; set; }
        public int? BranchId { get; set; }
        public int ?Flag { get; set; }
     
    }


}
