using System.Collections.Generic;

namespace AndroidIoc.Core
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();       
    }
}
