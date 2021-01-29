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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if ((txt_UserName.Text.ToUpper() == "TECHLINK" && txt_Password.Text == "123456") ||
                (txt_UserName.Text.ToUpper() == "TUANANH" && txt_Password.Text == "123456") ||
                (txt_UserName.Text.ToUpper() == "HOANGTRIEU" && txt_Password.Text == "123456"))
            {
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
            else
                MessageBox.Show("Wrong Password or User name");
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txt_UserName.Text = "TechLink";
            txt_Password.Text = "123456";
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)                      
                if ((txt_UserName.Text.ToUpper() == "TECHLINK" && txt_Password.Text == "123456") ||
                (txt_UserName.Text.ToUpper() == "TUANANH" && txt_Password.Text == "123456") ||
                (txt_UserName.Text.ToUpper() == "HOANGTRIEU" && txt_Password.Text == "123456"))
                {
                    MainMenu menu = new MainMenu();
                    menu.Show();
                }
                else
                    MessageBox.Show("Wrong Password or User name");
        }
    }
}
