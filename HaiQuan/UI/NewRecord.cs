 using HaiQuan.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaiQuan.UI
{
    public partial class NewRecord : Form
    {
        Controller controller;
        public NewRecord()
        {            
            controller = new Controller();
            InitializeComponent();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                PhieuNghiemThu pnt = new PhieuNghiemThu();
                pnt.LoaiDon = dataGridView1[1, e.RowIndex].Value.ToString();
                pnt.MaDon = dataGridView1[2, e.RowIndex].Value.ToString();
                pnt.STT = dataGridView1[3, e.RowIndex].Value.ToString();
                pnt.MaSP = dataGridView1[4, e.RowIndex].Value.ToString();
                pnt.TenSP = dataGridView1[5, e.RowIndex].Value.ToString();
                pnt.SoLuong = float.Parse(dataGridView1[6, e.RowIndex].Value.ToString());
                pnt.Donvi = dataGridView1[7, e.RowIndex].Value.ToString();
                pnt.Kho = dataGridView1[8, e.RowIndex].Value.ToString();
                pnt.SoLot = dataGridView1[9, e.RowIndex].Value.ToString();

                ConFirming confirm = new ConFirming(pnt);
                confirm.ShowDialog();
            }
          
        }

        private void NewRecord_Load(object sender, EventArgs e)
        {
            List<PhieuNghiemThu>  pnt = controller.GetPhieuNTList("","");
            var bindingList = new BindingList<PhieuNghiemThu>(pnt);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
