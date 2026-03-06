using System.Collections.Generic;
using System.Linq;

namespace Test2
{
    public class SanPhamService
    {
        List<SanPham> list = new List<SanPham>();

        public SanPhamService()
        {
            list.Add(new SanPham
            {
                ma = "SP1",
                ten = "Laptop",
                namBaoHanh = 2,
                gia = 1000,
                soLuong = 10,
                danhMuc = "Điện tử"
            });
        }

        public string Sua(string ma, SanPham spMoi)
        {
            var sp = list.FirstOrDefault(x => x.ma == ma);

            if (sp == null)
            {
                return "Không tìm thấy";
            }

            sp.ten = spMoi.ten;
            sp.namBaoHanh = spMoi.namBaoHanh;
            sp.gia = spMoi.gia;
            sp.soLuong = spMoi.soLuong;
            sp.danhMuc = spMoi.danhMuc;

            return "Sửa thành công";
        }
    }
}