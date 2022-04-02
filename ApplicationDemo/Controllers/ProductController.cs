using ApplicationDemo.Data;
using ApplicationDemo.Helper;
using ApplicationDemo.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDBContex _context;
        public ProductController(ApplicationDBContex contex)
        {
            _context = contex;
        }
        [HttpPost("SaveProduct")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> SaveProduct(Product product)
        {
            var userid = HttpContext.GetUserId();
            _ = await _context.Products.AddAsync(product);
            _ = await _context.SaveChangesAsync();
            return Ok(1);
        }


       

    }
}
