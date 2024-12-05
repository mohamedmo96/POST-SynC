using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vRootProject.Custom.MySQL.ProductMysql.ModelsMySql;
using vRootProject.Custom.MySQL.ProductMysql.ProductServiceMysql;

namespace vRootProject.Custom.MySQL.ProductMysql.ControllersProductMysql
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductMysqlController : ControllerBase
    {
        private readonly ProductServiceMysq _productService;

        public ProductMysqlController(ProductServiceMysq productService)
        {
            _productService = productService;
        }

       // [HttpPost("Create")]
        //public async Task<IActionResult> Create(ProductMySql newProduct)
        //{
        //    await _productService.AddProductToMySqlAsync(newProduct);
        //    return Ok(newProduct);
        //}
    }
}
