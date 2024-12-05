using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using vRootProject.Custom.DataMigration;
using vRootProject.Custom.Mongo.MongoConnection;
using vRootProject.Custom.Mongo.ProductMongoFile.ProductsSrveise;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBranch;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBuddies;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployee;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployeeShift;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesProductMongo;
using vRootProject.Custom.Mongo.ProductMongoFile.TransactionFlowSrveise;
using vRootProject.Custom.MySQL.BranchMysql.BranchServiceMysql;
using vRootProject.Custom.MySQL.EmployeeShiftMysql.EmployeeShiftServiceMysql;
using vRootProject.Custom.MySQL.ProductMysql.ProductServiceMysql;
using vRootProject.Custom.MySQL.ProductsMysql.ProductsServiceMysql;

namespace vRootProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.Configure<MongoDBSettings>(
                builder.Configuration.GetSection("MongoDBSettings"));

            builder.Services.AddSingleton<IMongoClient>(s =>
                new MongoClient(builder.Configuration.GetValue<string>("MongoDBSettings:ConnectionString")));

            builder.Services.AddScoped(s =>
               s.GetRequiredService<IMongoClient>().GetDatabase(
                   builder.Configuration.GetValue<string>("MongoDBSettings:DatabaseName")));

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
              options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
                  new MySqlServerVersion(new Version(8, 0, 23))));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ServicesEmployeeMongo>();
            builder.Services.AddScoped<ServicesProductMong>();
            builder.Services.AddScoped<ServicesBranchMongo>();
            builder.Services.AddScoped<ServicesBuddiesMongo>();
            builder.Services.AddScoped<ServicesEmployeeShiftMongo>();
            builder.Services.AddScoped<ServicesProductsMongo>();
            builder.Services.AddScoped<ServicesProductVarintMongo>();
            builder.Services.AddScoped<ServicesInvoiceMongo>();
            builder.Services.AddScoped<ServicesInvoiceDetailsMongo>();
            builder.Services.AddScoped<ServicesTransactionFlowMongo>();

            builder.Services.AddScoped<ProductServiceMysq>();
            builder.Services.AddScoped<BranchServiceMysqlService>();
            builder.Services.AddScoped<EmpServiceMysqlService>();
            builder.Services.AddScoped<BuddiesServiceMysqlService>();
            builder.Services.AddScoped<EmployeeShiftServiceMysqlService>();
            builder.Services.AddScoped<ProductsServiceMysqlService>();
            builder.Services.AddScoped<ProductVarintServiceMysqlService>();
            builder.Services.AddScoped<InvoiceServiceMysqlService>();
            builder.Services.AddScoped<InvoiceDetailsServiceMysqlService>();
            builder.Services.AddScoped<TransactionFlowServiceMysqlService>();


            builder.Services.AddScoped<DataMigrationService>();
            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                var dataMigrationService = scope.ServiceProvider.GetRequiredService<DataMigrationService>();
                await dataMigrationService.MigrateDataAsync();
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
