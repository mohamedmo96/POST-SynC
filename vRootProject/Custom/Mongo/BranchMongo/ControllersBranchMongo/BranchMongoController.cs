using CoreLayer.Enum.BusinessEnums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBranch;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ControllersBranchMongo
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchMongoController : ControllerBase
    {
        private readonly ServicesBranchMongo _branchService;

        public BranchMongoController(ServicesBranchMongo productService)
        {
            //h
            _branchService = productService;
        }



        [HttpGet("GetALl")]
        public async Task<IActionResult> Get() =>
            Ok(await _branchService.GetMongoBranchAsync());


        [HttpGet("GetBranchByIdWithChilds")]
        public async Task<IActionResult> GetBranchByIdWithChilds(int type, int? branchId=null )
        {
            var branchType = (ProductType)type;

            var branches = await _branchService.GetBranchesByTypeAsync(branchType, branchId);

            return Ok(branches);
        }



        [HttpGet("get list of company branchs according to logged user if user branch shared")]
        public async Task<IActionResult> GetBranches(int userBranchId, int userBranchType, int companyId)
        {
            if (userBranchId == 0 || companyId == 0)
            {
                return BadRequest("UserBranchId and CompanyId are required.");
            }

            var branches = await _branchService.GetBranchesAsync(userBranchId, userBranchType, companyId);

            if (branches == null || !branches.Any())
            {
                return NotFound("No branches found for the specified criteria.");
            }

            return Ok(branches);
        }

        [HttpGet("GetBranchBytype")]
        public async Task<IActionResult> GetBranchesByTypeAsync([FromQuery] int type)
        {
            try
            {
                var branches = await _branchService.GetBranchesByTypeAsync(type);

                return Ok(branches); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

}
