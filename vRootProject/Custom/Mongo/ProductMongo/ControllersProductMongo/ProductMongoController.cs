using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vRootProject.Custom.Mongo.ProductMongoFile.ServicesProductMongo;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ControllersProductMongo
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductMongoController : ControllerBase
    {
        private readonly ServicesProductMong _productService;

        public ProductMongoController(ServicesProductMong productService)
        {
            _productService = productService;
        }



        [HttpGet("GetALl")]
        public async Task<IActionResult> Get() =>
            Ok(await _productService.GetMongoProductsAsync());


    }

}
