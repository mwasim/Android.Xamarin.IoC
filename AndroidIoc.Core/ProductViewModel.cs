using System.Collections.Generic;

namespace AndroidIoc.Core
{
    public class ProductViewModel
    {
        private readonly IProductService _service;
        public ProductViewModel(IProductService service)
        {
            _service = service;
        }

        public IEnumerable<Product> ProductList
        {
            get { return _service.GetAll(); }
        }

    }
}
