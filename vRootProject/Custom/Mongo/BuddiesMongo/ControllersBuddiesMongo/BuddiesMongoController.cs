using Microsoft.AspNetCore.Mvc;
using vRootProject.Custom.Mongo.BuddiesMongo.BuddiesMongoModel;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBuddies;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ControllersBuddiesMongo
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuddiesMongoController : ControllerBase
    {
        private readonly ServicesBuddiesMongo _ModelService;

        public BuddiesMongoController(ServicesBuddiesMongo Service)
        {
            _ModelService = Service;
        }



        [HttpGet("GetALl")]
        public async Task<IActionResult> Get() =>
            Ok(await _ModelService.GetMongoModelsAsync());

        [HttpGet("getAllDeliveriesInCompanyAsync")]
        public async Task<IActionResult> GetAllDeliveriesInCompanyAsync()
        {
            try
            {
                var deliveries = await _ModelService.GetAllDeliveriesAsync();
                return Ok(deliveries); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetDeliveries-userBranchId-userBranchType")]
        public async Task<IActionResult> GetDeliveries(int userBranchId, int userBranchType, int companyId)
        {
            try
            {
                var deliveries = await _ModelService.GetDeliveriesAsync(userBranchId, userBranchType, companyId);
                return Ok(deliveries);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }

}
