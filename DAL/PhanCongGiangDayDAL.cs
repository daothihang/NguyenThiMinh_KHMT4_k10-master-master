using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhanCongGiangDayDAL
    {

        public List<PhanCongGiangDayDTO> LayBangPhanCongGiangDay()
        {
            List<PhanCongGiangDayDTO> dspcgd = new List<PhanCongGiangDayDTO>();
            KetNoiCoSoDuLieu.MoKetNoi();
            string sqlSELECT = "SELECT * FROM PhanCongGiangDay";
            SqlCommand cmd = new SqlCommand(sqlSELECT, KetNoiCoSoDuLieu.KetNoi);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                PhanCongGiangDayDTO pcgd = new PhanCongGiangDayDTO(
                     dr["MaLop"].ToString(),
                     dr["MaMon"].ToString(),
                     dr["MaCanBoGiaoVien"].ToString(),
                     dr["NgayPhanCong"].ToString());

                dspcgd.Add(pcgd);
            }
            KetNoiCoSoDuLieu.DongKetNoi();
            return dspcgd;
        }

        public void them(String malop,String mamon,String macbgv,String ngaypc)
        {

            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlthem = "INSERT INTO PhanCongGiangDay VALUES(@malop,@mamon,@Macbgv,@ngaypc)";
            SqlCommand cmd = new SqlCommand(sqlthem, KetNoiCoSoDuLieu.KetNoi);

            cmd.Parameters.AddWithValue("malop", malop);
            cmd.Parameters.AddWithValue("mamon", mamon);
            cmd.Parameters.AddWithValue("Macbgv", macbgv);
            cmd.Parameters.AddWithValue("ngaypc", ngaypc);

            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.DongKetNoi();
        }

        public void sua(PhanCongGiangDayDTO dto)
        {
           KetNoiCoSoDuLieu.MoKetNoi();

            String sqlsua = "UPDATE PhanCongGiangDay SET NgayPhanCong=@ngaypc WHERE MaLop=@malop AND MaMon=@mamon AND MaCanBoGiaoVien=@Macbgv";
            SqlCommand cmd = new SqlCommand(sqlsua, KetNoiCoSoDuLieu.KetNoi);

            cmd.Parameters.AddWithValue("malop", dto.MaLop);
            cmd.Parameters.AddWithValue("mamon", dto.MaMon);
            cmd.Parameters.AddWithValue("Macbgv", dto.MaCanBoGiaoVien);
            cmd.Parameters.AddWithValue("ngaypc", dto.NgayPhanCong);

            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.DongKetNoi();

        }
    }
}
