using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductData;

namespace ProductShopping.Controllers
{
    public class ProductsController : ApiController

    {
        public IEnumerable<Product> Get()
        {
            using (Shopping_Cart_dbEntities entities= new Shopping_Cart_dbEntities())
            {
                return entities.Products.ToList();
            }
        }
    }
}
