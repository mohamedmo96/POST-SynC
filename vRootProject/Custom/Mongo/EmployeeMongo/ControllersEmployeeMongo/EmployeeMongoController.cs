using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBranch;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployee;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ControllersEmployeeMongo
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeMongoController : ControllerBase
    {
        private readonly ServicesEmployeeMongo _ModelService;

        public EmployeeMongoController(ServicesEmployeeMongo Service )
        {
            _ModelService = Service;
        }



        [HttpGet("GetALl")]
        public async Task<IActionResult> Get() =>
            Ok(await _ModelService.GetMongoModelsAsync());

        [HttpGet("GetAllEmployeesByBranchDropList")]
        public async Task<IActionResult> Get([FromQuery] int branchId)
        {
            if (branchId!=null)
            {
                var employeesByBranch = await _ModelService.GetEmployeesByBranchIdAsync(branchId);
                return Ok(employeesByBranch);
            }

            var allEmployees = await _ModelService.GetMongoModelsAsync();
            return Ok(allEmployees);
        }

        [HttpGet("get list of branch employess & shared branchs employess")]
        public async Task<IActionResult> GetEmployees(int userBranchId, int userBranchType, int companyId)
        {
            if (userBranchId == 0 || companyId == 0)
            {
                return BadRequest("UserBranchId and CompanyId are required.");
            }

            var employees = await _ModelService.GetEmployeesAsync(userBranchId, userBranchType, companyId);

            if (employees == null || !employees.Any())
            {
                return NotFound("No employees found for the specified criteria.");
            }

            return Ok(employees);
        }


    }

}
