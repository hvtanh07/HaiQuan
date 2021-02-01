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
    public partial class ConFirming : Form
    {
        PhieuNghiemThu pnt;
        Controller controller;
        public ConFirming(PhieuNghiemThu pnt)
        {
            controller = new Controller();
            if(pnt == null)
            {
                MessageBox.Show("Data is null", "Error!");
            }else
            {
                this.pnt = pnt;
            }                
            InitializeComponent();
            
        }
        private void loadData()
        {
            
        }

        private void ConFirming_Load(object sender, EventArgs e)
        {
            txt_MaDon.Text = pnt.MaDon;
            txt_STK.Text = controller.GetSTK(pnt.MaDon);
        }
    }
}
