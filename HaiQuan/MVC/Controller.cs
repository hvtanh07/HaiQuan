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
    }
}
