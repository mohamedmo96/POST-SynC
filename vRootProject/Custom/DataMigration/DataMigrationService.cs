using CoreLayer.Models.ProductTechnology;
using vRootProject.Custom.Mongo.EmployeeShiftMongo.EmployeeShiftMongoModel;
using vRootProject.Custom.Mongo.ProductMongo.ProductModelMongo;
using vRootProject.Custom.Mongo.ProductMongoFile.ProductsSrveise;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBranch;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBuddies;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployee;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployeeShift;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesProductMongo;
using vRootProject.Custom.Mongo.ProductMongoFile.TransactionFlowSrveise;
using vRootProject.Custom.Mongo.ProductsMongo.ProductsMongoModel;
using vRootProject.Custom.Mongo.ProductVarintMongo.ProductVarintMongoModel;
using vRootProject.Custom.MySQL.BranchMysql.BranchServiceMysql;
using vRootProject.Custom.MySQL.EmployeeShiftMysql.EmployeeShiftServiceMysql;
using vRootProject.Custom.MySQL.ProductMysql.ProductServiceMysql;
using vRootProject.Custom.MySQL.ProductsMysql.ProductsServiceMysql;

namespace vRootProject.Custom.DataMigration
{
    public class DataMigrationService
    {
        private readonly BranchServiceMysqlService _productServiceSQL;
        private readonly ProductServiceMysq productsq;
        private readonly ServicesProductMong mongpro;
        private readonly ServicesBranchMongo _productServiceMongo;
        private readonly EmpServiceMysqlService empService;
        private readonly ServicesEmployeeMongo employeeMongo;
        private readonly BuddiesServiceMysqlService buddiesService;
        private readonly ServicesBuddiesMongo buddiesMongo;
        private readonly ServicesEmployeeShiftMongo employeeShiftMongo;
        private readonly EmployeeShiftServiceMysqlService mysqlService;
        private readonly ServicesProductsMongo productsMongo;
        private readonly ProductsServiceMysqlService productsService;
        private readonly ServicesProductVarintMongo varintMongo;
        private readonly ProductVarintServiceMysqlService productVarintService;
        private readonly ServicesInvoiceMongo invoiceMongo;
        private readonly InvoiceServiceMysqlService invoiceService;
        private readonly InvoiceDetailsServiceMysqlService invoiceDetailsServiceMysql;
        private readonly ServicesInvoiceDetailsMongo detailsMongo;
        private readonly ServicesTransactionFlowMongo transactionFlowMongo;
        private readonly TransactionFlowServiceMysqlService transactionFlow;

        public DataMigrationService(BranchServiceMysqlService productServiceMySql,
            ProductServiceMysq productsq , ServicesProductMong mongpro , 
            ServicesBranchMongo productServiceMongo, EmpServiceMysqlService empService,
            ServicesEmployeeMongo employeeMongo, BuddiesServiceMysqlService buddiesService, ServicesBuddiesMongo buddiesMongo,
            ServicesEmployeeShiftMongo employeeShiftMongo, EmployeeShiftServiceMysqlService mysqlService,
            ServicesProductsMongo productsMongo, ProductsServiceMysqlService productsService,
            ServicesProductVarintMongo varintMongo, ProductVarintServiceMysqlService productVarintService,
            ServicesInvoiceMongo invoiceMongo, InvoiceServiceMysqlService invoiceService,
            InvoiceDetailsServiceMysqlService invoiceDetailsServiceMysql, ServicesInvoiceDetailsMongo detailsMongo,
            ServicesTransactionFlowMongo transactionFlowMongo, TransactionFlowServiceMysqlService transactionFlow
            )
        {
            _productServiceSQL = productServiceMySql;
            this.productsq = productsq;
            this.mongpro = mongpro;
            _productServiceMongo = productServiceMongo;
            this.empService = empService;
            this.employeeMongo = employeeMongo;
            this.buddiesService = buddiesService;
            this.buddiesMongo = buddiesMongo;
            this.employeeShiftMongo = employeeShiftMongo;
            this.mysqlService = mysqlService;
            this.productsMongo = productsMongo;
            this.productsService = productsService;
            this.varintMongo = varintMongo;
            this.productVarintService = productVarintService;
            this.invoiceMongo = invoiceMongo;
            this.invoiceService = invoiceService;
            this.invoiceDetailsServiceMysql = invoiceDetailsServiceMysql;
            this.detailsMongo = detailsMongo;
            this.transactionFlowMongo = transactionFlowMongo;
            this.transactionFlow = transactionFlow;
        }

        public async Task MigrateDataAsync()
        {
            //   var Branch = await _productServiceSQL.GetMySqlProductsAsync();
              var Branch = await productsq.GetMySqlProductsAsync();
            //var mysqlEmp = await empService.GetMySqlModelAsync();
            //  var mysqlEmpShift = await mysqlService.GetMySqlModelAsync();
            // var mysqlProducts = await productsService.GetMySqlModelAsync();

            //  var mysqlProductsV = await productVarintService.GetMySqlModelAsync();
            // var mysqlBuddies = await buddiesService.GetMySqlModelAsync();
            //var mysqlinvoice = await invoiceService.GetMySqlModelAsync();
            //var mysqlinvoiceDetails = await invoiceDetailsServiceMysql.GetMySqlModelAsync();
            //      var mysqlTransactionFlow = await transactionFlow.GetMySqlModelAsync();

            var mongoProduct = Branch.Select(b => new ProductMong
            {
                Name = b.Name,
                Description=b.Description,
                Price=b.Price,
                Category=b.Category,
                InStock=b.InStock
              
             
            }).ToList();

            // var mongoBranch = Branch.Select(b => new Branch
            //{
            //    BranchId = b.BranchId,
            //    Name = b.Name,
            //    R_Code = b.R_Code,
            //    Phone = b.Phone,
            //    Fax = b.Fax,
            //    Mobile = b.Mobile,
            //    OtherMobile = b.OtherMobile,
            //    HomePhone = b.HomePhone,
            //    Photo = b.Photo,
            //    WhatsAppNo = b.WhatsAppNo,
            //    Rating = b.Rating,
            //    Description = b.Description,
            //    NumberOfEmployee = b.NumberOfEmployee,
            //    OwnerShip = b.OwnerShip,
            //    Website = b.Website,
            //    FacebookPage = b.FacebookPage,
            //    LinkedPage = b.LinkedPage,
            //    Email = b.Email,
            //    TimeZone = b.TimeZone,
            //    Type = b.Type,
            //    Address = b.Address,
            //    CountryId = b.CountryId,
            //    CityId = b.CityId,
            //    GovernmentId = b.GovernmentId,
            //    AreaId = b.AreaId,
            //    SpecialMark = b.SpecialMark,
            //    CompanyId = b.CompanyId,
            //    IndustryId = b.IndustryId,
            //    CreatedBy = b.CreatedBy,
            //    UpdatedBy = b.UpdatedBy,

            //    UpdateDate=b.UpdateDate,
            //    CreateDate=b.CreateDate,
            //    IsActive=b.IsActive,
            //    IsDeleted=b.IsDeleted,
            //}).ToList();

            //var mongoEmp = mysqlEmp.Select(b => new EmployeeColection
            //{
            //    EmployeeId = b.EmployeeId,
            //    FirstName = b.FirstName,
            //    LastName = b.LastName,
            //    Phone = b.Phone,
            //    Fax = b.Fax,
            //    Mobile = b.Mobile,
            //    OtherMobile = b.OtherMobile,
            //    HomePhone = b.HomePhone,
            //    Photo = b.Photo,
            //    WhatsAppNo = b.WhatsAppNo,
            //    Rating = b.Rating,
            //    Description = b.Description,
            //    FacebookPage = b.FacebookPage,
            //    LinkedPage = b.LinkedPage,
            //    Email = b.Email,
            //    HasTreasury = b.HasTreasury,
            //    TimeZone = b.TimeZone,
            //    Address = b.Address,
            //    URL_Path = b.URL_Path,
            //    R_Code = b.R_Code,
            //    CountryId = b.CountryId,
            //    CityId = b.CityId,
            //    GovernmentId = b.GovernmentId,
            //    AreaId = b.AreaId,
            //    SpecialMark = b.SpecialMark,
            //    Type = b.Type,
            //    BranchId = b.BranchId,
            //    CompanyId = b.CompanyId,
            //    AccTreeId = b.AccTreeId,
            //    CreatedBy = b.CreatedBy,
            //    UpdatedBy = b.UpdatedBy,

            //    UpdateDate = b.UpdateDate,
            //    CreateDate = b.CreateDate,
            //    IsActive = b.IsActive,
            //    IsDeleted = b.IsDeleted,
            //}).ToList();

            //var mongoBuddies = mysqlBuddies.Select(b => new BuddiesColection
            //{

            //   ID = b.ID,
            //    Key = b.Key,
            //    FirstName = b.FirstName,
            //    LastName = b.LastName,
            //    R_Code = b.R_Code,
            //    Code = b.Code,
            //    BuddiesType = b.BuddiesType,
            //    BodyTypes = b.BodyTypes,
            //    SignupType = b.SignupType,
            //    DeviceToken = b.DeviceToken,
            //    Phone = b.Phone,
            //    Fax = b.Fax,
            //    Mobile = b.Mobile,
            //    OtherMobile = b.OtherMobile,
            //    HomePhone = b.HomePhone,
            //    Photo = b.Photo,
            //    WhatsAppNo = b.WhatsAppNo,
            //    Rating = b.Rating,
            //    Description = b.Description,
            //    NumberOfEmployee = b.NumberOfEmployee,
            //    OwnerShip = b.OwnerShip,
            //    Website = b.Website,
            //    FacebookPage = b.FacebookPage,
            //    LinkedPage = b.LinkedPage,
            //    Email = b.Email,
            //    TimeZone = b.TimeZone,
            //    Address = b.Address,
            //    NationalID = b.NationalID,
            //    InvoiceLimit = b.InvoiceLimit,
            //    DateLimit = b.DateLimit,
            //    DateOfBirth = b.DateOfBirth,
            //    CreditLimit = b.CreditLimit,
            //    StopTheSale = b.StopTheSale,
            //    PriceSegment = b.PriceSegment,
            //    WhatsAppSessionDate = b.WhatsAppSessionDate,
            //    Type = b.Type,
            //    TurnOffAutomaticClassificationSystemForClient = b.TurnOffAutomaticClassificationSystemForClient,
            //    BranchId = b.BranchId,
            //    CompanyId = b.CompanyId,
            //    BuddiesClassId = b.BuddiesClassId,
            //    CountryId = b.CountryId,
            //    CityId = b.CityId,
            //    GovernmentId = b.GovernmentId,
            //    AreaId = b.AreaId,
            //    SpecialMark = b.SpecialMark,
            //    ArabicName = b.ArabicName,
            //    CivilID = b.CivilID,
            //    CustomerServiceEmployee = b.CustomerServiceEmployee,
            //    SalesEmployee = b.SalesEmployee,
            //    HouseNumber = b.HouseNumber,
            //    StreetLine1 = b.StreetLine1,
            //    StreetLine2 = b.StreetLine2,
            //    Post_ZipCode = b.Post_ZipCode,
            //    Image_Driver_License = b.Image_Driver_License,
            //    Image_National_ID = b.Image_National_ID,
            //    Image_Passport = b.Image_Passport,
            //    AccTreeId = b.AccTreeId,
            //    ParentId = b.ParentId,
            //    TechnicalId = b.TechnicalId,
            //    OwnerId = b.OwnerId,
            //    RepresentativeId = b.RepresentativeId,
            //    IndustryId = b.IndustryId,
            //    AutoCreditLimit = b.AutoCreditLimit,
            //    AutoCreditLimitPaymentDays = b.AutoCreditLimitPaymentDays,
            //    MaximumLimit = b.MaximumLimit,
            //    MaximumLimitAmount = b.MaximumLimitAmount,
            //    LeadSourceTypeID = b.LeadSourceTypeID,
            //    Bio = b.Bio,
            //    About = b.About,
            //    Account_Approved = b.Account_Approved,
            //    Account_Approved_Date = b.Account_Approved_Date,
            //    Image_Driver_License_Code = b.Image_Driver_License_Code,
            //    Image_Profile = b.Image_Profile,
            //    Image_Cover = b.Image_Cover,
            //    Image_Hygiene_Cert = b.Image_Hygiene_Cert,
            //    Is_Hygiene = b.Is_Hygiene,
            //    Image_Authority_Reg = b.Image_Authority_Reg,
            //    Image_Address_Proof = b.Image_Address_Proof,
            //    Image_Risk_Assessment = b.Image_Risk_Assessment,
            //    Image_Contract = b.Image_Contract,
            //    Image_Driving_License = b.Image_Driving_License,
            //    Image_Food_Delivery_Insurance = b.Image_Food_Delivery_Insurance,
            //    Image_Profile_1 = b.Image_Profile_1,
            //    Image_Profile_2 = b.Image_Profile_2,
            //    Image_Profile_3 = b.Image_Profile_3,
            //    Image_Profile_4 = b.Image_Profile_4,
            //    Image_Profile_5 = b.Image_Profile_5,
            //    Pickup_Allowed = b.Pickup_Allowed,
            //    Pickup_Only = b.Pickup_Only,
            //    Image_ID = b.Image_ID,
            //    Is_Blacklist = b.Is_Blacklist,
            //    Is_Investors = b.Is_Investors,
            //    Status_On_Work_Time = b.Status_On_Work_Time,
            //    Status_IsActive = b.Status_IsActive,
            //    Status_Work = b.Status_Work,
            //    Twitter_Page = b.Twitter_Page,
            //    Langaroo_Page = b.Langaroo_Page,
            //    Address_Latitude = b.Address_Latitude,
            //    Address_Longitude = b.Address_Longitude,
            //    Image_Bank_Statement = b.Image_Bank_Statement,
            //    Image_Evidence_Of_Residence = b.Image_Evidence_Of_Residence,
            //    Mobile_Verified = b.Mobile_Verified,
            //    Mobile_Verified_Date = b.Mobile_Verified_Date,
            //    Mobile_OTP = b.Mobile_OTP,
            //    Mobile_OTP_Date = b.Mobile_OTP_Date,
            //    Contract_Approved = b.Contract_Approved,
            //    Contract_Approved_Date = b.Contract_Approved_Date,
            //    CreatedBy = b.CreatedBy,
            //    UpdatedBy = b.UpdatedBy,


            //    UpdateDate = b.UpdateDate,
            //    CreateDate = b.CreateDate,
            //    IsActive = b.IsActive,
            //    IsDeleted = b.IsDeleted,

            //}).ToList();

            //var mongoEmpShifts = mysqlEmpShift.Select(b => new EmployeeShiftColection
            //{
            //    BranchId = b.BranchId,
            //    EmployeeShiftId = b.EmployeeShiftId,
            //    EmployeeId = b.EmployeeId,
            //    Flag = b.Flag,
            //    Status = b.Status,
            //    StartTime = b.StartTime,
            //    EndTime =b.EndTime,



            //}).ToList();
            //var mongoProducts = mysqlProducts.Select(b => new ProductsColection
            //{
            //    ProductId = b.ProductId,
            //    Name = b.Name,
            //    Description = b.Description,
            //    Photo = b.Photo,
            //    MainProductUnitID = b.MainProductUnitID,
            //    PurchaseDefaultProductUnitID = b.PurchaseDefaultProductUnitID,
            //    SalesDefaultProductUnitID = b.SalesDefaultProductUnitID,
            //    Stackable = b.Stackable,
            //    ClassificationId = b.ClassificationId,
            //    NotReturnable = b.NotReturnable,
            //    DiscountListType = b.DiscountListType,
            //    ContainerType = b.ContainerType,
            //    WarrantyType = b.WarrantyType,
            //    WarrantyNumber = b.WarrantyNumber,
            //    IsSerial = b.IsSerial,
            //    IsExpire = b.IsExpire,
            //    TaxValue = b.TaxValue,
            //    Code = b.Code,
            //    Int_Barcode = b.Int_Barcode,
            //    Barcode = b.Barcode,
            //    QRCode = b.QRCode,
            //    R_Code = b.R_Code,
            //    MainUnitR_Code = b.MainUnitR_Code,
            //    ClassificationR_Code = b.ClassificationR_Code,
            //    BrandR_Code = b.BrandR_Code,
            //    BrandId = b.BrandId,
            //    BranchId = b.BranchId,
            //    CompanyId = b.CompanyId,
            //    Type = b.Type,
            //    Flags = b.Flags,
            //    CreatedBy = b.CreatedBy,
            //    UpdatedBy = b.UpdatedBy,
            //    UpdateDate = b.UpdateDate,
            //    CreateDate = b.CreateDate,
            //    IsActive = b.IsActive,
            //    IsDeleted = b.IsDeleted
            //}).ToList();

            //var mongoProductsv = mysqlProductsV.Select(b => new ProductVarintColection
            //{
            //    ProductVarintId = b.ProductVarintId,
            //    Name = b.Name,
            //    Barcode = b.Barcode,
            //    Int_Barcode = b.Int_Barcode,
            //    Code = b.Code,
            //    R_Code = b.R_Code,
            //    Description = b.Description,
            //    Photo = b.Photo,
            //    ConsumerPrice = b.ConsumerPrice,
            //    DefaultStock = b.DefaultStock,
            //    DefaultSecStock = b.DefaultSecStock,
            //    MaximumLimitForBranch = b.MaximumLimitForBranch,
            //    MinimumLimitForBranch = b.MinimumLimitForBranch,
            //    MaximumLimitForCompany = b.MaximumLimitForCompany,
            //    MinimumLimitForCompany = b.MinimumLimitForCompany,
            //    MaximumOrder = b.MaximumOrder,
            //    ExchangeLimit = b.ExchangeLimit,
            //    ImagePath = b.ImagePath,
            //    NewPurchasePriceTurnOffFromPurchase = b.NewPurchasePriceTurnOffFromPurchase,
            //    NewPurchasePrice = b.NewPurchasePrice,
            //    NewPurchaseTurnOffNote = b.NewPurchaseTurnOffNote,
            //    NewPurchaseDate = b.NewPurchaseDate,
            //    Isasleep = b.Isasleep,
            //    PurchasePrice = b.PurchasePrice,
            //    SalesPrice1 = b.SalesPrice1,
            //    SalesPrice2 = b.SalesPrice2,
            //    SalesPrice3 = b.SalesPrice3,
            //    SalesPrice4 = b.SalesPrice4,
            //    SalesPrice5 = b.SalesPrice5,
            //    SalesPrice6 = b.SalesPrice6,
            //    SalesPrice7 = b.SalesPrice7,
            //    SalesPrice8 = b.SalesPrice8,
            //    SalesPrice9 = b.SalesPrice9,
            //    SalesPrice10 = b.SalesPrice10,
            //    Price = b.Price,
            //    Calories_Value = b.Calories_Value,
            //    Portion_Persons = b.Portion_Persons,
            //    Is_Order = b.Is_Order,
            //    Is_Pre_Order = b.Is_Pre_Order,
            //    ProductId = b.ProductId,
            //    BranchId = b.BranchId,
            //    CompanyId = b.CompanyId,
            //    Type = b.Type,
            //    Flags = b.Flags,
            //    CreatedBy = b.CreatedBy,
            //    UpdatedBy = b.UpdatedBy,
            //    UpdateDate = b.UpdateDate,
            //    CreateDate = b.CreateDate,
            //    IsActive = b.IsActive,
            //    IsDeleted = b.IsDeleted
            //}).ToList();


            //var mongoInvoices = mysqlinvoice.Select(b => new InvoiceColection
            //{
            //    InvoiceId = b.InvoiceId,
            //    InvoiceType = b.InvoiceType,
            //    PermissionStatus = b.PermissionStatus,
            //    InvoiceStatus = b.InvoiceStatus,
            //    InvoiceStatusFlag = b.InvoiceStatusFlag,
            //    BuddiesId = b.BuddiesId,
            //    TechnicalId = b.TechnicalId,
            //    DeliveryId = b.DeliveryId,
            //    WaiterId = b.WaiterId,
            //    Driver_ID = b.Driver_ID,
            //    Chef_ID = b.Chef_ID,
            //    FlagByDateCompany = b.FlagByDateCompany,
            //    FlagByDateBranch = b.FlagByDateBranch,
            //    EmployeeNote = b.EmployeeNote,
            //    ClientNote = b.ClientNote,
            //    PreparationNotes = b.PreparationNotes,
            //    Photo = b.Photo,
            //    FinalPrice = b.FinalPrice,
            //    Commission = b.Commission,
            //    TotalPrice = b.TotalPrice,
            //    TotalProductVarintTax = b.TotalProductVarintTax,
            //    TotalProductVarintDiscountListPrice = b.TotalProductVarintDiscountListPrice,
            //    TotalProductVarintDiscountExtraPrice = b.TotalProductVarintDiscountExtraPrice,
            //    InvoiceTax = b.InvoiceTax,
            //    InvoiceDiscount = b.InvoiceDiscount,
            //    DeliveryAreaPrice = b.DeliveryAreaPrice,
            //    DeliveryCostPrice = b.DeliveryCostPrice,
            //    ServicePrice = b.ServicePrice,
            //    WillShipping = b.WillShipping,
            //    WillPreparing = b.WillPreparing,
            //    SellerId = b.SellerId,
            //    StockPermissinId = b.StockPermissinId,
            //    OrderId = b.OrderId,
            //    BranchId = b.BranchId,
            //    ToBranchId = b.ToBranchId,
            //    CompanyId = b.CompanyId,
            //    TableNumber = b.TableNumber,
            //    InvoiceCode = b.InvoiceCode,
            //    Is_Schedule = b.Is_Schedule,
            //    Schedule_Date = b.Schedule_Date,
            //    Type = b.Type,
            //    Status = b.Status,
            //    PaymentType = b.PaymentType,
            //    DeletedBy = b.DeletedBy,
            //    DeletedDate = b.DeletedDate,
            //    CreatedBy = b.CreatedBy,
            //    UpdatedBy = b.UpdatedBy,
            //    UpdateDate = b.UpdateDate,
            //    CreateDate = b.CreateDate,
            //    IsActive = b.IsActive,
            //    IsDeleted = b.IsDeleted
            //}).ToList();


            //var mongoInvoiceDetails = mysqlinvoiceDetails.Select(b => new InvoiceDetailsColection
            //{
            //    InvoiceDetailsId = b.InvoiceDetailsId,
            //    ProductVarintId = b.ProductVarintId,
            //    ProductUnitId = b.ProductUnitId,
            //    Quantity = b.Quantity,
            //    QuantityOfmainUnit = b.QuantityOfmainUnit,
            //    ProductVarintPrice = b.ProductVarintPrice,
            //    ProductVarintDiscount = b.ProductVarintDiscount,
            //    ProductVarintDiscountPercent = b.ProductVarintDiscountPercent,
            //    ProductVarintTax = b.ProductVarintTax,
            //    ProductVarintTaxPercent = b.ProductVarintTaxPercent,
            //    ProductVarintFinalPrice = b.ProductVarintFinalPrice,
            //    TotalProductVarintFinalPrice = b.TotalProductVarintFinalPrice,
            //    Notes = b.Notes,
            //    ImageTempId = b.ImageTempId,
            //    StockId = b.StockId,
            //    InvoiceId = b.InvoiceId,
            //    ReturnInvoiceId = b.ReturnInvoiceId,
            //    DiscountListId = b.DiscountListId,
            //    DiscountListValue = b.DiscountListValue,

            //    Note = b.Note,
            //    DeletedBy = b.DeletedBy,
            //    DeletedDate = b.DeletedDate,
            //    CreatedBy = b.CreatedBy,
            //    UpdatedBy = b.UpdatedBy,
            //    UpdateDate = b.UpdateDate,
            //    CreateDate = b.CreateDate,
            //    IsActive = b.IsActive,
            //    IsDeleted = b.IsDeleted
            //}).ToList();


            //var mongoTransactionFlows = mysqlTransactionFlow.Select(b => new TransactionFlowColection
            //{
            //    TransactionFlowId = b.TransactionFlowId,
            //    Status =(int) b.Status,
            //    TransactionType = (int)b.TransactionType,
            //    PaymentType = (int)b.PaymentType,
            //    InvoicePrice = b.InvoicePrice ?? 0.0,
            //    InvoiceTax = b.InvoiceTax ?? 0.0,
            //    TotalPrice = b.TotalPrice ?? 0.0,
            //    Tax = b.Tax ?? 0.0,
            //    ExtraDiscount = b.ExtraDiscount ?? 0.0,
            //    ExtraTaxValue = b.ExtraTaxValue ?? 0.0,
            //    AmountPaid = b.AmountPaid ?? 0.0,
            //    EmployeeShiftId = b.EmployeeShiftId,
            //    BranchId = b.BranchId,
            //    BuddiesId = b.BuddiesId ?? string.Empty,
            //    OrderId = b.OrderId,
            //    StockPermissionId = b.StockPermissionId,
            //    InvoiceId = b.InvoiceId,
            //    VisaId = b.VisaId,
            //    WalletId = b.WalletId,
            //    BankId = b.BankId,
            //    TreasuryId = b.TreasuryId,
            //    TreasuryAmountPaid = b.TreasuryAmountPaid ?? 0.0,
            //    BankAmountPaid = b.BankAmountPaid ?? 0.0,
            //    VisaAmountPaid = b.VisaAmountPaid ?? 0.0,
            //    WalletAmountPaid = b.WalletAmountPaid ?? 0.0,
            //    Note = b.Note ?? string.Empty,
            //    TransactionDateNote = b.TransactionDateNote ?? string.Empty,
            //    Photo = b.Photo ?? string.Empty,
            //    Code = b.Code ?? string.Empty,
            //    OperationId = b.OperationId,
            //    TransferredTreasuryId = b.TransferredTreasuryId,
            //    TransferredBankId = b.TransferredBankId,
            //    EmployeeId = b.EmployeeId,
            //    ShareCapitalId = b.ShareCapitalId,
            //    StockId = b.StockId,
            //    TransferredStockId = b.TransferredStockId,
            //    CustomerPaymentAmount = b.CustomerPaymentAmount ?? 0.0,
            //    ScheduleDate = b.ScheduleDate,
            //    CreatedDate = b.CreatedDate,
            //    OperationDate = b.OperationDate,
            //    SameDate = b.SameDate ?? false,
            //    IsModified = b.IsModified ?? false,
            //    IsDeleted = b.IsDeleted ?? false,
            //    DeletedId = b.DeletedId,
            //    ModifiedId = b.ModifiedId,
            //    OriginalId = b.OriginalId,
            //    UpdatedDate = b.UpdatedDate,
            //    ClosedDate = b.ClosedDate,
            //    NextTransactionId = b.NextTransactionId,
            //    DeletedDate = b.DeletedDate,
            //    CreatedBy = b.CreatedBy ?? string.Empty,
            //    UpdatedBy = b.UpdatedBy ?? string.Empty
            //}).ToList();


            foreach (var item in mongoProduct)
            {
                await mongpro.CreateMongoProductAsync(item);
            }
            //foreach (var item in mongoBranch)
            //{
            //    await _productServiceMongo.CreateMongoProductAsync(item);
            //}
            //foreach (var Model in mongoEmp)
            //{
            //    await employeeMongo.CreateMongoModelAsync(Model);
            //}
            //foreach (var Model in mongoBuddies)
            //{
            //    await buddiesMongo.CreateMongoModelAsync(Model);
            //}
            //foreach (var Model in mongoEmpShifts)
            //{
            //    await employeeShiftMongo.CreateMongoModelAsync(Model);
            //}
            //foreach (var Model in mongoProducts)
            //{
            //    await productsMongo.CreateMongoModelAsync(Model);
            //}
            //foreach (var Model in mongoProductsv)
            //{
            //    await varintMongo.CreateMongoModelAsync(Model);
            //}
            //foreach (var Model in mongoInvoices)
            //{
            //    await invoiceMongo.CreateMongoModelAsync(Model);
            //}
            //foreach (var Model in mongoInvoiceDetails)
            //{
            //    await detailsMongo.CreateMongoModelAsync(Model);
            //}
            //foreach (var Model in mongoTransactionFlows)
            //{
            //    await transactionFlowMongo.CreateMongoModelAsync(Model);
            //}

        }

    }


}
