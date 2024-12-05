using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using vRootProject.Custom.Mongo.InvoiceMongo.InvoiceDto;
using vRootProject.Custom.Mongo.ProductMongoFile.ProductsSrveise;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBranch;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployee;
using vRootProject.Custom.Mongo.ProductsMongo.ProductsMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ControllersInvoiceMongo
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceMongoController : ControllerBase
    {
        private readonly ServicesInvoiceMongo _ModelService;
        private readonly IMongoCollection<InvoiceColection> _invoiceCollection;


        public InvoiceMongoController(ServicesInvoiceMongo Service ,IMongoDatabase database)
        {
            _ModelService = Service;
            _invoiceCollection = database.GetCollection<InvoiceColection>("Invoices");

        }



        [HttpGet("GetALl")]
        public async Task<IActionResult> Get() =>
            Ok(await _ModelService.GetMongoModelsAsync());



        [HttpGet("GetCashierInvoiceByDateAndBranchId")]
        public async Task<IActionResult> GetCashierInvoiceByDate([FromQuery] DateTime date , int branchId)
        {
            if (date == DateTime.MinValue)
            {
                return BadRequest("Please provide a valid date.");
            }

            var invoices = await _ModelService.GetInvoicesByDateAndBranchAsync(date , branchId);

            if (invoices == null || !invoices.Any())
            {
                return NotFound("No invoices found for the specified date.");
            }

            return Ok(invoices);
        }
        [HttpGet("GetCashierInvoiceByDelivery")]
        public async Task<IActionResult> GetCashierInvoiceByDelivery([FromQuery] string deliveryId)
        {
            if (string.IsNullOrWhiteSpace(deliveryId))
            {
                return BadRequest("DeliveryId is required.");
            }

            var invoices = await _ModelService.GetInvoicesByDeliveryAsync(deliveryId);

            if (invoices == null || !invoices.Any())
            {
                return NotFound("No invoices found for the specified delivery ID.");
            }

            return Ok(invoices);
        }

        [HttpGet("GetCashierInvoiceByEmployee")]
        public async Task<IActionResult> GetCashierInvoiceByEmployee([FromQuery] string employeeId)
        {
            if (employeeId =="0")
            {
                return BadRequest("EmployeeId is required and must be a positive number.");
            }

            var invoices = await _ModelService.GetInvoicesByEmployeeAsync(employeeId);

            if (invoices == null || !invoices.Any())
            {
                return NotFound("No invoices found for the specified employee.");
            }

            return Ok(invoices);
        }

        [HttpGet("GetShiftCashierInvoice")]
        public async Task<IActionResult> GetInvoicesByTimePeriod(DateTime startTimeShift, DateTime endTimeShift)
        {
            try
            {
                var invoices = await _ModelService.GetInvoicesByShiftsAndTimePeriod(startTimeShift, endTimeShift);
                return Ok(invoices); 
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

      

        [HttpGet("GetInvoiceTotals")]
        public async Task<IActionResult> GetInvoiceTotals()
        {
            try
            {
                var totals = await _ModelService.GetInvoiceTotalsAsync();

                if (totals == null)
                {
                    return NotFound("No invoices found.");
                }

                return Ok(totals);
            }
            catch (Exception ex)
            {
                // Log the exception (using ILogger or any logging mechanism)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [ HttpGet("GetInvoicesdata")]
        public async Task<IActionResult> GetInvoices(int branchid)
        {
            var invoices = await _ModelService.GetInvoicesByBranchWithBuddiesAsync(branchid);
            return Ok(invoices);
        }
    }

}
