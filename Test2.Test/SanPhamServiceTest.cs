using NUnit.Framework;
using Test2;

namespace Test2.Test
{
    [TestFixture]
    public class SanPhamServiceTest
    {
        SanPhamService service;

        [SetUp]
        public void Setup()
        {
            service = new SanPhamService();
        }

        [Test]
        public void Sua_SanPham_ThanhCong()
        {
            SanPham sp = new SanPham
            {
                ten = "Laptop Gaming",
                namBaoHanh = 3,
                gia = 2000,
                soLuong = 5,
                danhMuc = "Gaming"
            };

            var result = service.Sua("SP1", sp);

            Assert.That(result, Is.EqualTo("Sửa thành công"));
        }

        [Test]
        public void Sua_KhongTonTai()
        {
            SanPham sp = new SanPham();

            var result = service.Sua("SP999", sp);

            Assert.That(result, Is.EqualTo("Không tìm thấy"));
        }

        [Test]
        public void Sua_GiaBang0()
        {
            SanPham sp = new SanPham
            {
                ten = "Test",
                namBaoHanh = 1,
                gia = 0,
                soLuong = 1,
                danhMuc = "Test"
            };

            var result = service.Sua("SP1", sp);

            Assert.That(result, Is.EqualTo("Sửa thành công"));
        }

        [Test]
        public void Sua_SoLuongLon()
        {
            SanPham sp = new SanPham
            {
                ten = "Test",
                namBaoHanh = 1,
                gia = 100,
                soLuong = 1000,
                danhMuc = "Test"
            };

            var result = service.Sua("SP1", sp);

            Assert.That(result, Is.EqualTo("Sửa thành công"));
        }

        [Test]
        public void Sua_TenRong()
        {
            SanPham sp = new SanPham
            {
                ten = "",
                namBaoHanh = 1,
                gia = 100,
                soLuong = 1,
                danhMuc = "Test"
            };

            var result = service.Sua("SP1", sp);

            Assert.That(result, Is.EqualTo("Sửa thành công"));
        }
    }
}