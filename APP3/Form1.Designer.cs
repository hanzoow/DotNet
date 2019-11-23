namespace APP3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongSoMuc = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvQuaTrinhHocTap = new System.Windows.Forms.DataGridView();
            this.txtFromYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtToYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLearnAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ptcb1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lnk = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.bdsQuaTrinhHocTap = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuaTrinhHocTap)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuaTrinhHocTap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(128, 131);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(113, 20);
            this.dtpNgaySinh.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.dtgvQuaTrinhHocTap);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(-5, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 285);
            this.panel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTongSoMuc});
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "Tổng số mục";
            // 
            // lblTongSoMuc
            // 
            this.lblTongSoMuc.Name = "lblTongSoMuc";
            this.lblTongSoMuc.Size = new System.Drawing.Size(13, 17);
            this.lblTongSoMuc.Text = "0";
            // 
            // dtgvQuaTrinhHocTap
            // 
            this.dtgvQuaTrinhHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuaTrinhHocTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtFromYear,
            this.txtToYear,
            this.txtLearnAt});
            this.dtgvQuaTrinhHocTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvQuaTrinhHocTap.Location = new System.Drawing.Point(0, 25);
            this.dtgvQuaTrinhHocTap.Name = "dtgvQuaTrinhHocTap";
            this.dtgvQuaTrinhHocTap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvQuaTrinhHocTap.Size = new System.Drawing.Size(899, 260);
            this.dtgvQuaTrinhHocTap.TabIndex = 0;
            this.dtgvQuaTrinhHocTap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtFromYear
            // 
            this.txtFromYear.DataPropertyName = "FromYear";
            this.txtFromYear.HeaderText = "Từ năm";
            this.txtFromYear.Name = "txtFromYear";
            // 
            // txtToYear
            // 
            this.txtToYear.DataPropertyName = "ToYear";
            this.txtToYear.HeaderText = "Đến năm";
            this.txtToYear.Name = "txtToYear";
            // 
            // txtLearnAt
            // 
            this.txtLearnAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtLearnAt.DataPropertyName = "Address";
            this.txtLearnAt.HeaderText = "Học tại trường";
            this.txtLearnAt.Name = "txtLearnAt";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoa,
            this.btnEdit,
            this.btnAdd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(899, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Quá trình học tập";
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(46, 22);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 22);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(128, 36);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(360, 20);
            this.txtMaSinhVien.TabIndex = 3;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(128, 82);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(261, 20);
            this.txtHo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ và tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(397, 83);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(91, 20);
            this.txtTen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.AllowDrop = true;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nữ",
            "Nam",
            "Khác"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(128, 175);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cmbGioiTinh.TabIndex = 9;
            this.cmbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cmbGioiTinh_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nơi sinh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptcb1
            // 
            this.ptcb1.Image = ((System.Drawing.Image)(resources.GetObject("ptcb1.Image")));
            this.ptcb1.Location = new System.Drawing.Point(568, 39);
            this.ptcb1.Name = "ptcb1";
            this.ptcb1.Size = new System.Drawing.Size(199, 211);
            this.ptcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcb1.TabIndex = 12;
            this.ptcb1.TabStop = false;
            this.ptcb1.Click += new System.EventHandler(this.ptcb1_Click);
            this.ptcb1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ptcb1_DragDrop);
            this.ptcb1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ptcb1_DragEnter);
            this.ptcb1.DoubleClick += new System.EventHandler(this.ptcb1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(677, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cập nhật";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(800, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Bỏ qua";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lnk
            // 
            this.lnk.AutoSize = true;
            this.lnk.Location = new System.Drawing.Point(624, 265);
            this.lnk.Name = "lnk";
            this.lnk.Size = new System.Drawing.Size(94, 13);
            this.lnk.TabIndex = 15;
            this.lnk.TabStop = true;
            this.lnk.Text = "Chọn ảnh đại diện";
            this.lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(128, 216);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(100, 20);
            this.txtNoiSinh.TabIndex = 17;
            // 
            // bdsQuaTrinhHocTap
            // 
            this.bdsQuaTrinhHocTap.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 647);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.lnk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptcb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuaTrinhHocTap)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuaTrinhHocTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvQuaTrinhHocTap;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSoMuc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptcb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel lnk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFromYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtToYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLearnAt;
        private System.Windows.Forms.BindingSource bdsQuaTrinhHocTap;
    }
}

