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
using Microsoft.Reporting.WinForms;
using HaiQuan.MVC;
using HaiQuan.UI;

namespace HaiQuan
{
    public partial class ChiTietPhieu : Form
    {
        Controller controller;

        public ChiTietPhieu()
        {
            controller = new Controller();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Return)
                if (txt_Ma.Text != "" && txt_Type.Text != "")
                    loadata();
                else
                    MessageBox.Show("Empty fields...", "Error!");            
        }
        private void txt_Type_TextChanged(object sender, EventArgs e)
        {
            txt_Ma.AutoCompleteCustomSource = controller.getPhieuCode(txt_Type.Text);
        }

        private void loadata()
        {
            #region Load data for the print layout
            DataTable dt = controller.getdataforreportView(txt_Ma.Text, txt_Type.Text);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Github\HaiQuan\HaiQuan\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            PrintHiredEmployeesMethod();
            #endregion
            //------------------------------------------------------
            #region Load data for the modify layout

            List<ThongTinPhieu> ttp = controller.GetThongtinphieuList(txt_Ma.Text, txt_Type.Text);
            var bindingList = new BindingList<ThongTinPhieu>(ttp);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            #endregion
            //-------------------------------------------------------
        }

        public void PrintHiredEmployeesMethod()
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("ParameterHeader", "lmao"));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Ma.Text != "" && txt_Type.Text != "")
                loadata();
            else
                MessageBox.Show("Empty fields...", "Error!");
        }       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                string ma = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                PickingSTK picker = new PickingSTK(ma);
                picker.ShowDialog();
                dataGridView1.Rows[e.RowIndex].Cells[10].Value = picker.Opgave;
            }
        }        
    }
}
