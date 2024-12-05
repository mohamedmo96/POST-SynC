using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Models.ProductTechnology.ProductActions;
using System.ComponentModel.DataAnnotations;
using vRootProject.Custom.Mongo.BranchMongo.BranchMongoModel;

namespace CoreLayer.Models.Business
{
    public class Buddies : BaseEntity
    {
        [Key]
        public int? Key { get; set; }
        public string? ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? R_Code { get; set; }
        public string? Code { get; set; }
        public BuddiesType? BuddiesType { get; set; }
        public BodyTypes? BodyTypes { get; set; }
        public SignupType? SignupType { get; set; }
        public string? DeviceToken { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Mobile { get; set; }
        public string? OtherMobile { get; set; }
        public string? HomePhone { get; set; }
        public string? Photo { get; set; }
        public string? WhatsAppNo { get; set; }
        public double? Rating { get; set; }
        public string? Description { get; set; }
        public int? NumberOfEmployee { get; set; }
        public string? OwnerShip { get; set; }
        public string? Website { get; set; }
        public string? FacebookPage { get; set; }
        public string? LinkedPage { get; set; }
        public string? Email { get; set; }
        public TimeZones? TimeZone { get; set; }
        public string? Address { get; set; }
        public string? NationalID { get; set; }
        public int? InvoiceLimit { get; set; }
        public DateTime? DateLimit { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public double? CreditLimit { get; set; }
        public bool? StopTheSale { get; set; } = false;
        public int? PriceSegment { get; set; }
        public DateTime? WhatsAppSessionDate { get; set; }
        public ProductType? Type { get; set; }
        public bool ?TurnOffAutomaticClassificationSystemForClient { get; set; }
        public int? BranchId { get; set; }
        public int? CompanyId { get; set; }
        public int? BuddiesClassId { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? GovernmentId { get; set; }
        public int? AreaId { get; set; }
        public string? SpecialMark { get; set; }
        public string? ArabicName { get; set; }
        public string? CivilID { get; set; }
        public string? CustomerServiceEmployee { get; set; }
        public string? SalesEmployee { get; set; }
        public string? HouseNumber { get; set; }
        public string? StreetLine1 { get; set; }
        public string? StreetLine2 { get; set; }
        public string? Post_ZipCode { get; set; }
        public string? Image_Driver_License { get; set; }
        public string? Image_National_ID { get; set; }
        public string? Image_Passport { get; set; }
        public int? AccTreeId { get; set; }
        public string? ParentId { get; set; }
        public string? TechnicalId { get; set; }
        public int? OwnerId { get; set; }
        public string? RepresentativeId { get; set; }
        public int? IndustryId { get; set; }
        public bool? AutoCreditLimit { get; set; }
        public int? AutoCreditLimitPaymentDays { get; set; }
        public bool? MaximumLimit { get; set; }
        public double? MaximumLimitAmount { get; set; }
        public int? LeadSourceTypeID { get; set; }
        public string? Bio { get; set; }
        public string? About { get; set; }
        public bool? Account_Approved { get; set; }
        public DateTime? Account_Approved_Date { get; set; }
        public string? Image_Driver_License_Code { get; set; }
        public string? Image_Profile { get; set; }
        public string? Image_Cover { get; set; }
        public string? Image_Hygiene_Cert { get; set; }
        public bool? Is_Hygiene { get; set; }
        public string? Image_Authority_Reg { get; set; }
        public string? Image_Address_Proof { get; set; }
        public string? Image_Risk_Assessment { get; set; }
        public string? Image_Contract { get; set; }
        public string? Image_Driving_License { get; set; }
        public string? Image_Food_Delivery_Insurance { get; set; }
        public string? Image_Profile_1 { get; set; }
        public string? Image_Profile_2 { get; set; }
        public string? Image_Profile_3 { get; set; }
        public string? Image_Profile_4 { get; set; }
        public string? Image_Profile_5 { get; set; }
        public bool ?Pickup_Allowed { get; set; } = true;
        public bool? Pickup_Only { get; set; } = false;
        public string? Image_ID { get; set; }
        public bool? Is_Blacklist { get; set; }
        public bool ?Is_Investors { get; set; }
        public Status_On_Work_Time? Status_On_Work_Time { get; set; }
        public Status_IsActive? Status_IsActive { get; set; }
        public Status_Work? Status_Work { get; set; }
        public string? Twitter_Page { get; set; }
        public string? Langaroo_Page { get; set; }
        public decimal? Address_Latitude { get; set; }
        public decimal? Address_Longitude { get; set; }
        public string? Image_Bank_Statement { get; set; }
        public string? Image_Evidence_Of_Residence { get; set; }
        public bool? Mobile_Verified { get; set; } = false;
        public DateTime? Mobile_Verified_Date { get; set; }
        public string? Mobile_OTP { get; set; }
        public DateTime? Mobile_OTP_Date { get; set; }
        public bool? Contract_Approved { get; set; }
        public DateTime? Contract_Approved_Date { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

    }
}

