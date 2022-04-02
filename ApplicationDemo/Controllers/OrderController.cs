using ApplicationDemo.Data;
using ApplicationDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDBContex _context;
        public OrderController(ApplicationDBContex context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("order")]
       public async Task<IActionResult> SaveOrder(Order3 model)
        {

            try
            {
                //foreach (var item in model.OrderDetails)
                //{
                //    item.ProductId = item.Product.Id;
                //}
                _ = _context.Order3.Add(model);
                //_context.Order3Details.AddRange(model.OrderDetails);
               var result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                var aa = ex.ToString();
                throw;
            }
            return Ok(1);
        }


        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            try
            {
                var query = from order in _context.Order3.AsNoTracking()
                             join orderDetail in _context.Order3Details.AsNoTracking() on order.Id equals orderDetail.Id
                             join product in _context.Products.AsNoTracking() on orderDetail.ProductId equals product.Id
                             select new
                             {
                                 orderId = order.Id,
                                 orderDetail = orderDetail.Id,
                                 productName = product.Name,
                                 productPrice = product.Price
                             };

                var result = await query.ToListAsync();
                var result2 = await Task.FromResult(query.ToList());
                var result3 = await Task.FromResult( await query.ToListAsync());


                var ddd = _context.Order3.Join(_context.Order3Details,
                    order => order.Id,
                    orderDetail => orderDetail.Id,
                    (order, orderDetail) => new { 
                        id = order.Id,
                        prod=orderDetail.ProductId,
                        asd = orderDetail.Product.Name
                    }
                    ).ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
