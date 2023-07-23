using Fullstack.Api.Data;
using Fullstack.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fullstack.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    
    public class ProductsController : Controller
    {
        private FullstackDbContext _fullstackDbContext;

        public ProductsController( FullstackDbContext fullstackDbContext)
        {
            _fullstackDbContext = fullstackDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var Products = await _fullstackDbContext.products.ToListAsync();

            return Ok(Products);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product productRequest)
        {
            
            await _fullstackDbContext.products.AddAsync(productRequest);
            await _fullstackDbContext.SaveChangesAsync();
            return Ok(productRequest);
        }


    }
}
