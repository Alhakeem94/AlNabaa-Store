using AlNabaa_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlNabaa_Store.BackEnd.InterFaces
{
   public interface IProducts
    {

        public Task<string> AddProduct(ProductsModel NewProduct);
        public Task<List<ProductsModel>> GetAllProducts();
        public Task<ProductsModel> GetProductDetails(int Id);
        public Task<string> EditProduct(ProductsModel NewProduct);






    }
}
