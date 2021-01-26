using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaiQuan
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();          
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            loadata();
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                Getinfo();
            }
        }

        private void loadata()
        {
            #region Load data for the print layout
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFBBSK;Initial Catalog=testdb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TestHQ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Github\HaiQuan\HaiQuan\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            #endregion
            //------------------------------------------------------
            #region Load data for the modify layout
            //load data vao data gridview
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Getinfo();
        }

        private void Getinfo()
        {
            MessageBox.Show("Reached!");
        }
    }
}
