using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class CanBoGiaoVienBUL
    {
        CanBoGiaoVienDAL myCB = new CanBoGiaoVienDAL();
        public List<CanBoGiaoVienDTO> LayDsCanBo()
        {
            return myCB.LayBangCanBoGiaoVien();
        }

        public DataTable Login(String ten, String mk, String loaitk)
        {
            return myCB.dangnhap(ten, mk, loaitk);
        }
        public bool Them(string MaCanBoGiaoVien, string HoTen, string DiaChi, string SoDienThoai, string TaiKhoan, string MatKhau, string LoaiTaiKhoan)
        {
            return myCB.Them(MaCanBoGiaoVien, HoTen, DiaChi, SoDienThoai, TaiKhoan, MatKhau, LoaiTaiKhoan);
        }
        public bool Sua(string MaCanBoGiaoVien, string HoTen, string DiaChi, string SoDienThoai, string TaiKhoan, string MatKhau, string LoaiTaiKhoan)
        {
            return myCB.Sua(MaCanBoGiaoVien, HoTen, DiaChi, SoDienThoai, TaiKhoan, MatKhau, LoaiTaiKhoan);
        }
        public bool Xoa(string MaCanBoGiaoVien)
        {
            return myCB.Xoa(MaCanBoGiaoVien);

        }
    }
}
