using System;
using System.Collections.Generic;
using System.Text;

namespace Exe.Core.EF
{
    public class ProductRepository : IRepository<Product>
    {
        public bool Add(Product p)
        {
            using (var _ctx = new ProductContext())
            {
                if (p == null)
                    return false;

                _ctx.Products.Add(p);
                _ctx.SaveChanges();

                return true;
            }
        }
    }
}
