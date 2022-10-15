using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        public List<Product> Get();

        public Product Get(int id);

        void Add(Product product);

        void Update(Product product);

        public List<ProductDetailDto> GetProductDetails();
        
    }
}
