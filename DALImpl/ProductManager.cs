using DAL;
using DTO;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALImpl
{
    public class ProductManager : IProduct
    {
        void IProduct.AddProductDetail(Product Product)
        {
            using (var context = new SanPhamDbContext())
            {
                Console.WriteLine("Nhập tên sản phẩm:");
                string tenSanPham = Console.ReadLine();

                var sanPham = new Product
                {
                    Name = tenSanPham,
                };
                context.Products.Add(sanPham);
                context.SaveChanges();
                Console.WriteLine("Thêm sản phẩm thành công.");
            }
        }

        void IProduct.DeleteProductDetail(Product Product)
        {
            using (var context = new SanPhamDbContext())
            {
                Console.WriteLine("Nhập ID sản phẩm cần xóa:");
                int IDSanPham = int.Parse(Console.ReadLine());
                var sanPham = context.Products.FirstOrDefault(sp => sp.ProductId == IDSanPham);
                if (sanPham != null)
                {
                    context.Products.Remove(sanPham);
                    context.SaveChanges();
                    Console.WriteLine("Xóa sản phẩm thành công.");
                }
                else
                {
                    Console.WriteLine("Sản phẩm không tồn tại.");
                }
            }
        }

        void IProduct.UpdateProductDetail(Product Product)
        {
            using (var context = new SanPhamDbContext())
            {
                Console.WriteLine("Nhập ID sản phẩm cần sửa:");
                int IDSanPham = int.Parse(Console.ReadLine());
                var sanPham = context.Products.FirstOrDefault(sp => sp.ProductId == IDSanPham);
                if (sanPham != null)
                {
                    Console.WriteLine("Nhập tên sản phẩm mới:");
                    sanPham.Name = Console.ReadLine();
                    context.SaveChanges();
                    Console.WriteLine("Sửa sản phẩm thành công.");
                }
                else
                {
                    Console.WriteLine("Sản phẩm không tồn tại.");
                }
            }
        }
    }
}
