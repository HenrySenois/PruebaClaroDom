using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaClaroDom.Model.Models;
using PruebaClaroDom.Server.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaClaroDom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly PruebaDbContext _context;
        private readonly IProducts _products;

        public ProductsController(PruebaDbContext context, IProducts products)
        {
            _context = context;
            this._products = products;
        }

        [HttpGet("GetAll")]
        public async Task<List<Products>> GetProducts()
        {
            var productsList = await products.GetAllProducts();
            return Ok(productsList);
        }

        [HttpGet("GetById")]
        public async Task<Products> GetProductById(int id)
        {
            var product = await products.GetProduct(id);
            return Ok(product);
        }

        [HttpPost("Create")]
        public async Task<Products> Create(Products Product)
        {
            var product = await products.CreateProduct(Product);
            return Ok(product);
        }

        [HttpPut("Update")]
        public async Task<Products> Update(Products Product)
        {
            var product = await products.UpdateProduct(Product);
            return Ok(product);
        }

        [HttpDelete("Delete")]
        public async Task<Products> Delete(int id)
        {
            var product = await products.DeleteProduct(id);
            return Ok(product);
        }
    }
}
