//using Microsoft.AspNetCore.Http.HttpResults;
//using Microsoft.AspNetCore.Mvc;
//using vRootProject.Custom.MySQL.ProductMysql.ModelsMySql;

//[ApiController]
//[Route("api/[controller]")]
//public class ProductsController : ControllerBase
//{
//    private readonly ProductServiceMysql _productService;

//    public ProductsController(ProductServiceMysql productService)
//    {
//        _productService = productService;
//    }

//    [HttpGet("GetALl")]
//    public async Task<IActionResult> Get() =>
//        Ok(await _productService.GetMongoProductsAsync());

   

//    [HttpPost("Create")]
//    public async Task<IActionResult> Create(ProductMySql newProduct)
//    {
//        await _productService.AddProductToMySqlAsync(newProduct);
//        return Ok(newProduct);
//    }



  

   



  



//}
