using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vRootProject.Custom.Mongo.ProductMongoFile.ProductsSrveise;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesBranch;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployee;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ControllersInvoiceDetailsMongo
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceDetailsMongoController : ControllerBase
    {
        private readonly ServicesInvoiceDetailsMongo _ModelService;

        public InvoiceDetailsMongoController(ServicesInvoiceDetailsMongo Service)
        {
            _ModelService = Service;
        }



        [HttpGet("GetALl")]
        public async Task<IActionResult> Get() =>
            Ok(await _ModelService.GetMongoModelsAsync());

        [HttpGet("GetInvoiceDetails/{invoiceId}")]
        public async Task<IActionResult> GetInvoiceDetails(int invoiceId)
        {
            try
            {
                var invoiceDetails = await _ModelService.GetInvoiceDetailsByInvoiceIdAsync(invoiceId);
                if (invoiceDetails == null || !invoiceDetails.Any())
                {
                    return NotFound(new { message = "No details found for this invoice." });
                }

                return Ok(invoiceDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred.", error = ex.Message });
            }
        }


    }

}
