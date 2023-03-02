using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string getProducts()
        {
            return "This will be list of products";


         }
        [HttpGet("{id}")]
        public string getProduct(int id)
        {
            return "This will be product";
        }
    }
        
}
