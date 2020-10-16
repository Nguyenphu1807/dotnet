using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice_dotnet.Models;
using Practice_dotnet.Services;

namespace Practice_dotnet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {

        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<product> Get()
        {
            return ProductService.GetProducts();
        }

        //[HttpPath] "[FromBody]"
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] String ProductId,
            [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}
