using DALImpl;

namespace BE_2505_Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t ---- CHƯƠNG TRÌNH QUẢN LÝ MÁY TÍNH ----");
                Console.WriteLine("1. Thêm thông tin loại sản phẩm.");
                Console.WriteLine("2. Sửa thông tin loại sản phẩm.");
                Console.WriteLine("3. Xóa thông tin loại sản phẩm.");
                Console.WriteLine("4. Thêm thông tin sản phẩm.");
                Console.WriteLine("5. Sửa thông tin sản phẩm.");
                Console.WriteLine("6. Xóa thông tin sản phẩm.");
                Console.WriteLine("0. Nhập 0 để thoát khỏi chương trình!");
                Console.WriteLine("\t\t ---- END ----");

                Console.Write("Nhập lựa chọn: ");
                int luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
