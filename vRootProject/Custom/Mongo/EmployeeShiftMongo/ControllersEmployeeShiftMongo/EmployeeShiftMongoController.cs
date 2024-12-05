using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBranch;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployee;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployeeShift;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ControllersBuddiesMongo
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeShiftMongoController : ControllerBase
    {
        private readonly ServicesEmployeeShiftMongo _ModelService;

        public EmployeeShiftMongoController(ServicesEmployeeShiftMongo Service)
        {
            _ModelService = Service;
        }



        [HttpGet("GetALl")]
        public async Task<IActionResult> Get() =>
            Ok(await _ModelService.GetMongoModelsAsync());

        [HttpGet("GetShiftCashierInvoice")]
        public async Task<IActionResult> GetShiftCashierInvoice([FromQuery] int branchId, [FromQuery] int employeeId)
        {
            // تحقق من المدخلات
            if (branchId <= 0 || employeeId <= 0)
            {
                return BadRequest("Invalid BranchId or EmployeeId.");
            }

            // استدعاء الخدمة
            var shifts = await _ModelService.GetEmployeeShiftsAsync(branchId, employeeId);

            if (shifts == null || !shifts.Any())
            {
                return NotFound($"No shifts found for BranchId {branchId} and EmployeeId {employeeId}.");
            }

            return Ok(shifts);
        }

        [HttpGet("GetShifts/{employeeId}")]
        public async Task<IActionResult> GetShifts(int employeeId)
        {
            try
            {
                var shifts = await _ModelService.GetEmployeeShiftsByIDAsync(employeeId);

                if (shifts == null || shifts.Count == 0)
                {
                    return NotFound("No shifts found for the given employee.");
                }

                return Ok(shifts);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

}
