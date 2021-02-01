
namespace HaiQuan.UI
{
    partial class NewRecord
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pick = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LoaiDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pick,
            this.LoaiDon,
            this.MaDon,
            this.STT,
            this.MaSP,
            this.TenSP,
            this.SLNhap,
            this.Donvi,
            this.Kho,
            this.SoLo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 545);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Pick
            // 
            this.Pick.HeaderText = "Pick";
            this.Pick.MinimumWidth = 6;
            this.Pick.Name = "Pick";
            this.Pick.ReadOnly = true;
            this.Pick.Width = 40;
            // 
            // LoaiDon
            // 
            this.LoaiDon.DataPropertyName = "LoaiDon";
            this.LoaiDon.HeaderText = "Loại đơn";
            this.LoaiDon.MinimumWidth = 6;
            this.LoaiDon.Name = "LoaiDon";
            this.LoaiDon.ReadOnly = true;
            this.LoaiDon.Width = 92;
            // 
            // MaDon
            // 
            this.MaDon.DataPropertyName = "MaDon";
            this.MaDon.HeaderText = "Mã đơn";
            this.MaDon.MinimumWidth = 6;
            this.MaDon.Name = "MaDon";
            this.MaDon.ReadOnly = true;
            this.MaDon.Width = 84;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 64;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 78;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 84;
            // 
            // SLNhap
            // 
            this.SLNhap.DataPropertyName = "SoLuong";
            this.SLNhap.HeaderText = "SL Nhập hàng";
            this.SLNhap.MinimumWidth = 6;
            this.SLNhap.Name = "SLNhap";
            this.SLNhap.ReadOnly = true;
            this.SLNhap.Width = 128;
            // 
            // Donvi
            // 
            this.Donvi.DataPropertyName = "Donvi";
            this.Donvi.HeaderText = "Đơn vị";
            this.Donvi.MinimumWidth = 6;
            this.Donvi.Name = "Donvi";
            this.Donvi.ReadOnly = true;
            this.Donvi.Width = 77;
            // 
            // Kho
            // 
            this.Kho.DataPropertyName = "Kho";
            this.Kho.HeaderText = "Kho";
            this.Kho.MinimumWidth = 6;
            this.Kho.Name = "Kho";
            this.Kho.ReadOnly = true;
            this.Kho.Width = 62;
            // 
            // SoLo
            // 
            this.SoLo.DataPropertyName = "SoLot";
            this.SoLo.HeaderText = "Số lô";
            this.SoLo.MinimumWidth = 6;
            this.SoLo.Name = "SoLo";
            this.SoLo.ReadOnly = true;
            this.SoLo.Width = 69;
            // 
            // NewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 654);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewRecord";
            this.Text = "NewRecord";
            this.Load += new System.EventHandler(this.NewRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Pick;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLo;
    }
}