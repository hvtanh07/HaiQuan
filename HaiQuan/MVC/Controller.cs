using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace HaiQuan.MVC
{
    class Controller
    {
        public List<ThongTinPhieu> GetThongtinphieuList(string ma,string type)
        {
            List<ThongTinPhieu> ttpList = new List<ThongTinPhieu>();
            SqlConnection con = new SqlConnection("Data Source=SFT;Initial Catalog=TEST06;Persist Security Info=True;User ID=soft;Password=techlink@!@#");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select TB003,TB004, TB005, TB006, TB008, TB007, TB014, TB012, TB013, TB015 from INVTB  where TB001 = '" + type + "' and TB002 = '" + ma + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        ThongTinPhieu ttp = new ThongTinPhieu();
                        ttp.STT = reader[0].ToString();
                        ttp.MaSP = reader[1].ToString();
                        ttp.TenSP = reader[2].ToString();
                        ttp.QuyCach = reader[3].ToString();
                        ttp.Donvi = reader[4].ToString();
                        ttp.SoLuong = float.Parse(reader[5].ToString());
                        ttp.SoLot = reader[6].ToString();
                        ttp.KhoXuat = reader[7].ToString();
                        ttp.KhoNhap = reader[8].ToString();
                        ttp.STK = reader[9].ToString();
                        ttpList.Add(ttp);
                    }
                }
                con.Close();
                con.Dispose();
            }
            catch(SqlException ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error!");
                con.Close();
                return null;
            }
           
            return ttpList;
        }

        public DataTable getdataforreportView(string ma, string type)
        {
            SqlConnection con = new SqlConnection("Data Source=SFT;Initial Catalog=TEST06;Persist Security Info=True;User ID=soft;Password=techlink@!@#");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select TB003,TB004, TB005, TB006, TB008, TB007, TB014, TB012, TB013, TB015 from INVTB  where TB001 = '" + type + "' and TB002 = '" + ma + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public AutoCompleteStringCollection getPhieuCode (string type)
        {
            AutoCompleteStringCollection codeList = new AutoCompleteStringCollection();
            SqlConnection con = new SqlConnection("Data Source=SFT;Initial Catalog=TEST06;Persist Security Info=True;User ID=soft;Password=techlink@!@#");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select TB002 from INVTB where TB001 = '" + type + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        codeList.Add(reader[0].ToString());
                    }
                }
                con.Close();
                con.Dispose();
            }
            catch (SqlException ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error!");
                con.Close();
                return null;
            }
            return codeList;
        }

        public List<PhieuNghiemThu> GetPhieuNTList(string ma, string type)
        {
            List<PhieuNghiemThu> pntList = new List<PhieuNghiemThu>();
            SqlConnection con = new SqlConnection("Data Source=SFT;Initial Catalog=TEST06;Persist Security Info=True;User ID=soft;Password=techlink@!@#");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select top(100)TH001,TH002, TH003, TH004, TH005, TH007, TH008, TH009, TH010 from purths", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        PhieuNghiemThu ttp = new PhieuNghiemThu();
                        ttp.LoaiDon = reader[0].ToString();
                        ttp.MaDon = reader[1].ToString();
                        ttp.STT = reader[2].ToString();
                        ttp.MaSP = reader[3].ToString();
                        ttp.TenSP = reader[4].ToString();
                        ttp.SoLuong = float.Parse(reader[5].ToString());
                        ttp.Donvi = reader[6].ToString();
                        ttp.Kho = reader[7].ToString();
                        ttp.SoLot = reader[8].ToString();
                        pntList.Add(ttp);
                    }
                }
                con.Close();
                con.Dispose();
            }
            catch (SqlException ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error!");
                con.Close();
                return null;
            }

            return pntList;
        }

        public string GetSTK(string ma)
        {
            string STK="";
            SqlConnection con = new SqlConnection("Data Source=SFT;Initial Catalog=TEST06;Persist Security Info=True;User ID=soft;Password=techlink@!@#");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select STK from purtgs where TG002 = " +  ma + "", con);//TEST006 ko tồn tại
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        STK = reader[0].ToString();
                    }
                }
                con.Close();
                con.Dispose();
            }
            catch (SqlException ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error!");
                con.Close();
                return null;
            }

            return STK;
        }
    }
}
