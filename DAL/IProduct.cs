using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProduct
    {
        public void AddProductDetail(Product Product);
        public void DeleteProductDetail(Product Product);
        public void UpdateProductDetail(Product Product);
    }
}
