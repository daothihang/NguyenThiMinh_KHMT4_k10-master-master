using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class PhanCongGiangDayBUL
    {

        PhanCongGiangDayDAL myPhanCongDAL = new PhanCongGiangDayDAL();
        public List<PhanCongGiangDayDTO> LayDanhSachPhanCongGiangDay()
        {
            return myPhanCongDAL.LayBangPhanCongGiangDay();
        }


        public void phanCong(String malop, String mamon, String macbgv, String ngaypc)
        {
            myPhanCongDAL.them(malop,mamon,macbgv,ngaypc);

        }
        public void sua(PhanCongGiangDayDTO dto)
        {
            myPhanCongDAL.sua(dto);
        }
    }
}
