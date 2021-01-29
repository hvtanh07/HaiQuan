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
    public partial class PickingSTK : Form
    {
        public PickingSTK()
        {
            InitializeComponent();
        }
        public PickingSTK(string maSP)
        {           
            InitializeComponent();
            txt_MaSP.Text = maSP;
        }

        private void PickingSTK_Load(object sender, EventArgs e)
        {

        }

        public string Opgave { get { return cBox_Picker.Text; } }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            this.Close(); 
        }
    }
}
