using PruebaClaroDom.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaClaroDom.Server.Interfaces
{
    public interface IProducts
    {
        Task<List<Products>> GetAllProducts();
        Task<Products> GetProduct(int id);
        Task<Products> CreateProduct(Products product);
        Task<Products> UpdateProduct(Products product);
        Task<Products> DeleteProduct(int id);

    }
}
