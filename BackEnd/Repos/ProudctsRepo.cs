using AlNabaa_Store.BackEnd.InterFaces;
using AlNabaa_Store.Data;
using AlNabaa_Store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlNabaa_Store.BackEnd.Repos
{
    public class ProudctsRepo : IProducts
    {
        private ApplicationDbContext _db;
        public ProudctsRepo(ApplicationDbContext Db)
        {
            _db = Db;
        }

        public async Task<string> AddProduct(ProductsModel NewProduct)
        {
           await _db.ProductsTable.AddAsync(NewProduct);
           await _db.SaveChangesAsync();
            return "تمت اضافة المنتج";
        }

        public async Task<string> EditProduct(ProductsModel NewProduct)
        {
            var OldProduct = await _db.ProductsTable.SingleOrDefaultAsync(a => a.Id == NewProduct.Id);
            OldProduct = NewProduct;
            _db.ProductsTable.Update(OldProduct);
           await _db.SaveChangesAsync();

            return "تم تعديل المنتج بنجاح";

        }

        public async Task<List<ProductsModel>> GetAllProducts()
        {
            return await _db.ProductsTable.ToListAsync();
        }

        public async Task<ProductsModel> GetProductDetails(int Id)
        {
            return await _db.ProductsTable.SingleOrDefaultAsync(a => a.Id == Id);
        }
    }




}
