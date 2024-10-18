namespace De02
{
    partial class frmSanpham
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
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btttim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.bttsua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttthem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.dtpngaynhap = new System.Windows.Forms.DateTimePicker();
            this.bttxoa = new System.Windows.Forms.Button();
            this.bttluu = new System.Windows.Forms.Button();
            this.bttkluu = new System.Windows.Forms.Button();
            this.bttthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(252, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // dgvsp
            // 
            this.dgvsp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.ngaynhap,
            this.loai});
            this.dgvsp.Location = new System.Drawing.Point(52, 133);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.RowHeadersWidth = 51;
            this.dgvsp.RowTemplate.Height = 24;
            this.dgvsp.Size = new System.Drawing.Size(557, 239);
            this.dgvsp.TabIndex = 1;
            this.dgvsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellClick);
            // 
            // ma
            // 
            this.ma.HeaderText = "Mã SP";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.Width = 125;
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên Sản Phẩm";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // ngaynhap
            // 
            this.ngaynhap.HeaderText = "Ngày Nhập";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Width = 125;
            // 
            // loai
            // 
            this.loai.HeaderText = "Loại";
            this.loai.MinimumWidth = 6;
            this.loai.Name = "loai";
            this.loai.Width = 125;
            // 
            // btttim
            // 
            this.btttim.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btttim.Location = new System.Drawing.Point(257, 72);
            this.btttim.Name = "btttim";
            this.btttim.Size = new System.Drawing.Size(96, 41);
            this.btttim.TabIndex = 2;
            this.btttim.Text = "Tìm";
            this.btttim.UseVisualStyleBackColor = false;
            this.btttim.Click += new System.EventHandler(this.btttim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(103, 81);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(136, 22);
            this.txttim.TabIndex = 3;
            // 
            // bttsua
            // 
            this.bttsua.Location = new System.Drawing.Point(143, 403);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(75, 23);
            this.bttsua.TabIndex = 2;
            this.bttsua.Text = "Sữa";
            this.bttsua.UseVisualStyleBackColor = true;
            this.bttsua.Click += new System.EventHandler(this.bttsua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã SP:";
            // 
            // bttthem
            // 
            this.bttthem.Location = new System.Drawing.Point(52, 403);
            this.bttthem.Name = "bttthem";
            this.bttthem.Size = new System.Drawing.Size(75, 23);
            this.bttthem.TabIndex = 2;
            this.bttthem.Text = "Thêm";
            this.bttthem.UseVisualStyleBackColor = true;
            this.bttthem.Click += new System.EventHandler(this.bttthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên SP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại SP:";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(714, 188);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(144, 22);
            this.txttensp.TabIndex = 5;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(714, 141);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(144, 22);
            this.txtmasp.TabIndex = 5;
            // 
            // cbbloai
            // 
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Items.AddRange(new object[] {
            "Bánh kẹo",
            "Giải khát"});
            this.cbbloai.Location = new System.Drawing.Point(714, 272);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(144, 24);
            this.cbbloai.TabIndex = 6;
            // 
            // dtpngaynhap
            // 
            this.dtpngaynhap.Location = new System.Drawing.Point(714, 232);
            this.dtpngaynhap.Name = "dtpngaynhap";
            this.dtpngaynhap.Size = new System.Drawing.Size(200, 22);
            this.dtpngaynhap.TabIndex = 7;
            // 
            // bttxoa
            // 
            this.bttxoa.Location = new System.Drawing.Point(238, 403);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(75, 23);
            this.bttxoa.TabIndex = 2;
            this.bttxoa.Text = "Xóa";
            this.bttxoa.UseVisualStyleBackColor = true;
            this.bttxoa.Click += new System.EventHandler(this.bttxoa_Click);
            // 
            // bttluu
            // 
            this.bttluu.Location = new System.Drawing.Point(332, 403);
            this.bttluu.Name = "bttluu";
            this.bttluu.Size = new System.Drawing.Size(75, 23);
            this.bttluu.TabIndex = 2;
            this.bttluu.Text = "Lưu";
            this.bttluu.UseVisualStyleBackColor = true;
            // 
            // bttkluu
            // 
            this.bttkluu.Location = new System.Drawing.Point(423, 403);
            this.bttkluu.Name = "bttkluu";
            this.bttkluu.Size = new System.Drawing.Size(75, 23);
            this.bttkluu.TabIndex = 2;
            this.bttkluu.Text = "K.luu";
            this.bttkluu.UseVisualStyleBackColor = true;
            // 
            // bttthoat
            // 
            this.bttthoat.Location = new System.Drawing.Point(515, 403);
            this.bttthoat.Name = "bttthoat";
            this.bttthoat.Size = new System.Drawing.Size(75, 23);
            this.bttthoat.TabIndex = 2;
            this.bttthoat.Text = "Thoát";
            this.bttthoat.UseVisualStyleBackColor = true;
            this.bttthoat.Click += new System.EventHandler(this.bttthoat_Click);
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.dtpngaynhap);
            this.Controls.Add(this.cbbloai);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.bttthem);
            this.Controls.Add(this.bttthoat);
            this.Controls.Add(this.bttkluu);
            this.Controls.Add(this.bttluu);
            this.Controls.Add(this.bttxoa);
            this.Controls.Add(this.bttsua);
            this.Controls.Add(this.btttim);
            this.Controls.Add(this.dgvsp);
            this.Controls.Add(this.label1);
            this.Name = "frmSanpham";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.Button btttim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.ComboBox cbbloai;
        private System.Windows.Forms.DateTimePicker dtpngaynhap;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.Button bttluu;
        private System.Windows.Forms.Button bttkluu;
        private System.Windows.Forms.Button bttthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
    }
}

