using System;
using System.Collections.Generic;
using System.Text;

namespace Exe.Core
{
    public class BusinessLayer
    {

        #region DEPENDENCY INJECTION
        
        private readonly IRepository<Product> productRepo;

        public BusinessLayer(IRepository<Product> productRepo)
        {
            this.productRepo = productRepo; 
        }
        #endregion
        public bool Add(Product p)
        {
           
            try
            {
                if (p != null)
                {
                    var result = productRepo.Add(p);
                    return result;
                }
                else
                {
                    Console.WriteLine("Product can't be null.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
