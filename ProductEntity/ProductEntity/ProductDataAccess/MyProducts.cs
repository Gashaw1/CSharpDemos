using ProductEntity.ProductDBContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductEntity.ProductDataAccess
{
    public class MyProducts
    {
        ProductDbContext pro;
        
        public void produ()
        {
            pro = new ProductDbContext();
            pro.Products.ToString();
        }
        public List<Product> GetAllProduct()
        {
            
            try
            {
                pro = new ProductDbContext();
               
            }
            catch (Exception ex)
            {
                string r = ex.Message;
                
            }
            return pro.Products.ToList();
        }

}
}
