using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaClaroDom.Model.Models;
using PruebaClaroDom.Server.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaClaroDom.Server.Services
{
    public class ProductService: IProducts
    {
        private readonly PruebaDbContext _context;
        public ProductService(PruebaDbContext context)
        {
            _context = context;
        }

        public async Task<List<Products>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Products> GetProduct(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Products> CreateProduct(Products product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Products> UpdateProduct(Products product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Products> DeleteProduct(int id)
        {
            var product = new Products { Id = id };
            _context.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }
}
