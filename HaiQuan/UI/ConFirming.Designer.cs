
namespace HaiQuan.UI
{
    partial class ConFirming
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaDon = new System.Windows.Forms.TextBox();
            this.txt_STK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "TG";
            // 
            // txt_MaDon
            // 
            this.txt_MaDon.Location = new System.Drawing.Point(106, 301);
            this.txt_MaDon.Name = "txt_MaDon";
            this.txt_MaDon.Size = new System.Drawing.Size(100, 22);
            this.txt_MaDon.TabIndex = 4;
            // 
            // txt_STK
            // 
            this.txt_STK.Location = new System.Drawing.Point(449, 301);
            this.txt_STK.Name = "txt_STK";
            this.txt_STK.Size = new System.Drawing.Size(100, 22);
            this.txt_STK.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số tờ khai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã đơn";
            // 
            // ConFirming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_STK);
            this.Controls.Add(this.txt_MaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConFirming";
            this.Text = "ConFirming";
            this.Load += new System.EventHandler(this.ConFirming_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaDon;
        private System.Windows.Forms.TextBox txt_STK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}