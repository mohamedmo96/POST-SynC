using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Models.Business;
using System.ComponentModel.DataAnnotations.Schema;
using CoreLayer.Models.ProductTechnology.ProductActions;
using CoreLayer.Models.ProductTechnology;
using CoreLayer.Models;

namespace vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel
{
  
    public class EmployeeColection: BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int ?EmployeeId { get; set; }
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public string ?Phone { get; set; }
        public string ?Fax { get; set; }
        public string ?Mobile { get; set; }
        public string ?OtherMobile { get; set; }
        public string ?HomePhone { get; set; }
        public string ?Photo { get; set; }
        public string ?WhatsAppNo { get; set; }
        public double ?Rating { get; set; }
        public string ?Description { get; set; }
        public string ?FacebookPage { get; set; }
        public string ?LinkedPage { get; set; }
        public string? Email { get; set; }
        public bool ?HasTreasury { get; set; }
        public TimeZones? TimeZone { get; set; }
        public string ?Address { get; set; }
        public string ?URL_Path { get; set; }
        public string ?R_Code { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? GovernmentId { get; set; }
        public int? AreaId { get; set; }
        public string ?SpecialMark { get; set; }
        public ProductType ?Type { get; set; }
        public int? BranchId { get; set; }
        public int? CompanyId { get; set; }
        public int? AccTreeId { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

    }


}
