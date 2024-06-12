namespace GUI.Employee
{
    partial class Employee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControlEmployee = new TabControl();
            tabPageTaiXe = new TabPage();
            button1 = new Button();
            buttonAdd = new Button();
            buttonTimkiem = new Button();
            comboBoxTimKiem = new ComboBox();
            textBoxTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridViewTaiXe = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnHo = new DataGridViewTextBoxColumn();
            ColumnTen = new DataGridViewTextBoxColumn();
            ColumnGioiTinh = new DataGridViewTextBoxColumn();
            ColumnNgaySinh = new DataGridViewTextBoxColumn();
            ColumnCCCD = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnSDT = new DataGridViewTextBoxColumn();
            Columndiachi = new DataGridViewTextBoxColumn();
            ColumnDelete = new DataGridViewImageColumn();
            ColumnChiTiet = new DataGridViewImageColumn();
            ColumnIn = new DataGridViewImageColumn();
            tabPageBaoMau = new TabPage();
            button3 = new Button();
            button4 = new Button();
            buttonTimKiemBM = new Button();
            comboBoxTimKiemBaoMau = new ComboBox();
            textBoxTimKiemBM = new TextBox();
            pictureBox2 = new PictureBox();
            dataGridViewBaoMau = new DataGridView();
            cotid = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            cotxoa = new DataGridViewImageColumn();
            cotsua = new DataGridViewImageColumn();
            tabControlEmployee.SuspendLayout();
            tabPageTaiXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaiXe).BeginInit();
            tabPageBaoMau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaoMau).BeginInit();
            SuspendLayout();
            // 
            // tabControlEmployee
            // 
            tabControlEmployee.Controls.Add(tabPageTaiXe);
            tabControlEmployee.Controls.Add(tabPageBaoMau);
            tabControlEmployee.Dock = DockStyle.Fill;
            tabControlEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlEmployee.Location = new Point(0, 0);
            tabControlEmployee.Margin = new Padding(2, 3, 2, 3);
            tabControlEmployee.Name = "tabControlEmployee";
            tabControlEmployee.Padding = new Point(0, 0);
            tabControlEmployee.RightToLeft = RightToLeft.Yes;
            tabControlEmployee.SelectedIndex = 0;
            tabControlEmployee.Size = new Size(1200, 700);
            tabControlEmployee.TabIndex = 1;
            // 
            // tabPageTaiXe
            // 
            tabPageTaiXe.BackColor = Color.White;
            tabPageTaiXe.Controls.Add(button1);
            tabPageTaiXe.Controls.Add(buttonAdd);
            tabPageTaiXe.Controls.Add(buttonTimkiem);
            tabPageTaiXe.Controls.Add(comboBoxTimKiem);
            tabPageTaiXe.Controls.Add(textBoxTimKiem);
            tabPageTaiXe.Controls.Add(pictureBox1);
            tabPageTaiXe.Controls.Add(dataGridViewTaiXe);
            tabPageTaiXe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageTaiXe.ForeColor = Color.Black;
            tabPageTaiXe.Location = new Point(4, 37);
            tabPageTaiXe.Margin = new Padding(2, 3, 2, 3);
            tabPageTaiXe.Name = "tabPageTaiXe";
            tabPageTaiXe.Padding = new Padding(2, 3, 2, 3);
            tabPageTaiXe.Size = new Size(1192, 659);
            tabPageTaiXe.TabIndex = 0;
            tabPageTaiXe.Text = "Tài xế";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatAppearance.BorderColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(877, 464);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(120, 48);
            button1.TabIndex = 9;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MediumSeaGreen;
            buttonAdd.FlatAppearance.BorderColor = Color.DarkGreen;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(741, 464);
            buttonAdd.Margin = new Padding(2, 3, 2, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 48);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonTimkiem
            // 
            buttonTimkiem.BackColor = Color.MediumSeaGreen;
            buttonTimkiem.FlatAppearance.BorderColor = Color.DarkGreen;
            buttonTimkiem.FlatStyle = FlatStyle.Popup;
            buttonTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTimkiem.ForeColor = Color.White;
            buttonTimkiem.Location = new Point(586, 468);
            buttonTimkiem.Margin = new Padding(2, 3, 2, 3);
            buttonTimkiem.Name = "buttonTimkiem";
            buttonTimkiem.Size = new Size(120, 40);
            buttonTimkiem.TabIndex = 8;
            buttonTimkiem.Text = "SEARCH";
            buttonTimkiem.UseVisualStyleBackColor = false;
            buttonTimkiem.Click += buttonTimkiem_Click;
            // 
            // comboBoxTimKiem
            // 
            comboBoxTimKiem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTimKiem.FormattingEnabled = true;
            comboBoxTimKiem.Items.AddRange(new object[] { "Tên", "Số điện thoại", "Email", "Địa chỉ" });
            comboBoxTimKiem.Location = new Point(126, 477);
            comboBoxTimKiem.Margin = new Padding(2, 3, 2, 3);
            comboBoxTimKiem.Name = "comboBoxTimKiem";
            comboBoxTimKiem.Size = new Size(139, 33);
            comboBoxTimKiem.TabIndex = 7;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTimKiem.Location = new Point(301, 468);
            textBoxTimKiem.Margin = new Padding(2, 3, 2, 3);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.RightToLeft = RightToLeft.No;
            textBoxTimKiem.Size = new Size(267, 43);
            textBoxTimKiem.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(1, 448);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewTaiXe
            // 
            dataGridViewTaiXe.BackgroundColor = Color.White;
            dataGridViewTaiXe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTaiXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTaiXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaiXe.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnHo, ColumnTen, ColumnGioiTinh, ColumnNgaySinh, ColumnCCCD, ColumnEmail, ColumnSDT, Columndiachi, ColumnDelete, ColumnChiTiet, ColumnIn });
            dataGridViewTaiXe.Dock = DockStyle.Top;
            dataGridViewTaiXe.Location = new Point(2, 3);
            dataGridViewTaiXe.Margin = new Padding(2, 3, 2, 3);
            dataGridViewTaiXe.Name = "dataGridViewTaiXe";
            dataGridViewTaiXe.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTaiXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTaiXe.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewTaiXe.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTaiXe.Size = new Size(1188, 408);
            dataGridViewTaiXe.TabIndex = 1;
            dataGridViewTaiXe.CellContentClick += content;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "IdTaiXe";
            ColumnId.HeaderText = "Id";
            ColumnId.MinimumWidth = 8;
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 150;
            // 
            // ColumnHo
            // 
            ColumnHo.DataPropertyName = "Ho";
            ColumnHo.HeaderText = "Họ";
            ColumnHo.MinimumWidth = 8;
            ColumnHo.Name = "ColumnHo";
            ColumnHo.Width = 150;
            // 
            // ColumnTen
            // 
            ColumnTen.DataPropertyName = "Ten";
            ColumnTen.HeaderText = "Tên";
            ColumnTen.MinimumWidth = 8;
            ColumnTen.Name = "ColumnTen";
            ColumnTen.Width = 150;
            // 
            // ColumnGioiTinh
            // 
            ColumnGioiTinh.DataPropertyName = "GioiTinh";
            ColumnGioiTinh.HeaderText = "Giới tính";
            ColumnGioiTinh.MinimumWidth = 8;
            ColumnGioiTinh.Name = "ColumnGioiTinh";
            ColumnGioiTinh.Width = 150;
            // 
            // ColumnNgaySinh
            // 
            ColumnNgaySinh.DataPropertyName = "NgaySinh";
            ColumnNgaySinh.HeaderText = "Ngày sinh";
            ColumnNgaySinh.MinimumWidth = 8;
            ColumnNgaySinh.Name = "ColumnNgaySinh";
            ColumnNgaySinh.Width = 150;
            // 
            // ColumnCCCD
            // 
            ColumnCCCD.DataPropertyName = "CCCD";
            ColumnCCCD.HeaderText = "CCCD";
            ColumnCCCD.MinimumWidth = 8;
            ColumnCCCD.Name = "ColumnCCCD";
            ColumnCCCD.Width = 150;
            // 
            // ColumnEmail
            // 
            ColumnEmail.DataPropertyName = "Email";
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.MinimumWidth = 8;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.Width = 150;
            // 
            // ColumnSDT
            // 
            ColumnSDT.DataPropertyName = "SDT";
            ColumnSDT.HeaderText = "SĐT";
            ColumnSDT.MinimumWidth = 8;
            ColumnSDT.Name = "ColumnSDT";
            ColumnSDT.Width = 150;
            // 
            // Columndiachi
            // 
            Columndiachi.DataPropertyName = "diachi";
            Columndiachi.HeaderText = "Địa chỉ";
            Columndiachi.MinimumWidth = 8;
            Columndiachi.Name = "Columndiachi";
            Columndiachi.Width = 150;
            // 
            // ColumnDelete
            // 
            ColumnDelete.HeaderText = "";
            ColumnDelete.Image = (Image)resources.GetObject("ColumnDelete.Image");
            ColumnDelete.MinimumWidth = 8;
            ColumnDelete.Name = "ColumnDelete";
            ColumnDelete.Resizable = DataGridViewTriState.True;
            ColumnDelete.Width = 150;
            // 
            // ColumnChiTiet
            // 
            ColumnChiTiet.HeaderText = "";
            ColumnChiTiet.Image = (Image)resources.GetObject("ColumnChiTiet.Image");
            ColumnChiTiet.MinimumWidth = 8;
            ColumnChiTiet.Name = "ColumnChiTiet";
            ColumnChiTiet.Resizable = DataGridViewTriState.True;
            ColumnChiTiet.Width = 150;
            // 
            // ColumnIn
            // 
            ColumnIn.HeaderText = "";
            ColumnIn.Image = (Image)resources.GetObject("ColumnIn.Image");
            ColumnIn.MinimumWidth = 8;
            ColumnIn.Name = "ColumnIn";
            ColumnIn.Resizable = DataGridViewTriState.True;
            ColumnIn.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnIn.Width = 150;
            // 
            // tabPageBaoMau
            // 
            tabPageBaoMau.BackColor = Color.White;
            tabPageBaoMau.Controls.Add(button3);
            tabPageBaoMau.Controls.Add(button4);
            tabPageBaoMau.Controls.Add(buttonTimKiemBM);
            tabPageBaoMau.Controls.Add(comboBoxTimKiemBaoMau);
            tabPageBaoMau.Controls.Add(textBoxTimKiemBM);
            tabPageBaoMau.Controls.Add(pictureBox2);
            tabPageBaoMau.Controls.Add(dataGridViewBaoMau);
            tabPageBaoMau.Location = new Point(4, 37);
            tabPageBaoMau.Margin = new Padding(2, 3, 2, 3);
            tabPageBaoMau.Name = "tabPageBaoMau";
            tabPageBaoMau.Padding = new Padding(2, 3, 2, 3);
            tabPageBaoMau.Size = new Size(1192, 659);
            tabPageBaoMau.TabIndex = 1;
            tabPageBaoMau.Text = "Bảo mẫu";
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.FlatAppearance.BorderColor = Color.DarkGreen;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(879, 485);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(120, 48);
            button3.TabIndex = 13;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSeaGreen;
            button4.FlatAppearance.BorderColor = Color.DarkGreen;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(743, 485);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(120, 48);
            button4.TabIndex = 14;
            button4.Text = "ADD";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonTimKiemBM
            // 
            buttonTimKiemBM.BackColor = Color.MediumSeaGreen;
            buttonTimKiemBM.FlatAppearance.BorderColor = Color.DarkGreen;
            buttonTimKiemBM.FlatStyle = FlatStyle.Popup;
            buttonTimKiemBM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTimKiemBM.ForeColor = Color.White;
            buttonTimKiemBM.Location = new Point(589, 489);
            buttonTimKiemBM.Margin = new Padding(2, 3, 2, 3);
            buttonTimKiemBM.Name = "buttonTimKiemBM";
            buttonTimKiemBM.Size = new Size(120, 40);
            buttonTimKiemBM.TabIndex = 12;
            buttonTimKiemBM.Text = "SEARCH";
            buttonTimKiemBM.UseVisualStyleBackColor = false;
            buttonTimKiemBM.Click += buttonTimKiemBM_Click;
            // 
            // comboBoxTimKiemBaoMau
            // 
            comboBoxTimKiemBaoMau.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTimKiemBaoMau.FormattingEnabled = true;
            comboBoxTimKiemBaoMau.Items.AddRange(new object[] { "Tên", "Số điện thoại", "Email", "Địa chỉ " });
            comboBoxTimKiemBaoMau.Location = new Point(128, 499);
            comboBoxTimKiemBaoMau.Margin = new Padding(2, 3, 2, 3);
            comboBoxTimKiemBaoMau.Name = "comboBoxTimKiemBaoMau";
            comboBoxTimKiemBaoMau.Size = new Size(139, 33);
            comboBoxTimKiemBaoMau.TabIndex = 11;
            // 
            // textBoxTimKiemBM
            // 
            textBoxTimKiemBM.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTimKiemBM.Location = new Point(303, 489);
            textBoxTimKiemBM.Margin = new Padding(2, 3, 2, 3);
            textBoxTimKiemBM.Name = "textBoxTimKiemBM";
            textBoxTimKiemBM.RightToLeft = RightToLeft.No;
            textBoxTimKiemBM.Size = new Size(267, 43);
            textBoxTimKiemBM.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(3, 469);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // dataGridViewBaoMau
            // 
            dataGridViewBaoMau.BackgroundColor = Color.White;
            dataGridViewBaoMau.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewBaoMau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewBaoMau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBaoMau.Columns.AddRange(new DataGridViewColumn[] { cotid, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, DiaChi, cotxoa, cotsua });
            dataGridViewBaoMau.Dock = DockStyle.Top;
            dataGridViewBaoMau.Location = new Point(2, 3);
            dataGridViewBaoMau.Margin = new Padding(2, 3, 2, 3);
            dataGridViewBaoMau.Name = "dataGridViewBaoMau";
            dataGridViewBaoMau.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewBaoMau.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewBaoMau.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewBaoMau.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBaoMau.Size = new Size(1188, 408);
            dataGridViewBaoMau.TabIndex = 2;
            dataGridViewBaoMau.CellContentClick += contentclick2;
            // 
            // cotid
            // 
            cotid.DataPropertyName = "IdBaoMau";
            cotid.HeaderText = "Id";
            cotid.MinimumWidth = 8;
            cotid.Name = "cotid";
            cotid.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Ho";
            dataGridViewTextBoxColumn2.HeaderText = "Họ";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Ten";
            dataGridViewTextBoxColumn3.HeaderText = "Tên";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "GioiTinh";
            dataGridViewTextBoxColumn4.HeaderText = "Giới tính";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "NgaySinh";
            dataGridViewTextBoxColumn5.HeaderText = "Ngày sinh";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "CCCD";
            dataGridViewTextBoxColumn6.HeaderText = "CCCD";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            dataGridViewTextBoxColumn7.HeaderText = "Email";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "SĐT";
            dataGridViewTextBoxColumn8.HeaderText = "SĐT";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "diachi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 150;
            // 
            // cotxoa
            // 
            cotxoa.HeaderText = "";
            cotxoa.Image = (Image)resources.GetObject("cotxoa.Image");
            cotxoa.MinimumWidth = 8;
            cotxoa.Name = "cotxoa";
            cotxoa.Resizable = DataGridViewTriState.True;
            cotxoa.Width = 150;
            // 
            // cotsua
            // 
            cotsua.HeaderText = "";
            cotsua.Image = Properties.Resources.moredetail;
            cotsua.MinimumWidth = 8;
            cotsua.Name = "cotsua";
            cotsua.Resizable = DataGridViewTriState.True;
            cotsua.Width = 150;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(tabControlEmployee);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Employee";
            Text = "Employee";
            tabControlEmployee.ResumeLayout(false);
            tabPageTaiXe.ResumeLayout(false);
            tabPageTaiXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaiXe).EndInit();
            tabPageBaoMau.ResumeLayout(false);
            tabPageBaoMau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaoMau).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlEmployee;
        private TabPage tabPageTaiXe;
        private Button button1;
        private Button buttonAdd;
        private Button buttonTimkiem;
        private ComboBox comboBoxTimKiem;
        private TextBox textBoxTimKiem;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewTaiXe;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnHo;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnGioiTinh;
        private DataGridViewTextBoxColumn ColumnNgaySinh;
        private DataGridViewTextBoxColumn ColumnCCCD;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnSDT;
        private DataGridViewTextBoxColumn Columndiachi;
        private DataGridViewImageColumn ColumnDelete;
        private DataGridViewImageColumn ColumnChiTiet;
        private DataGridViewImageColumn ColumnIn;
        private TabPage tabPageBaoMau;
        private Button button3;
        private Button button4;
        private Button buttonTimKiemBM;
        private ComboBox comboBoxTimKiemBaoMau;
        private TextBox textBoxTimKiemBM;
        private PictureBox pictureBox2;
        private DataGridView dataGridViewBaoMau;
        private DataGridViewTextBoxColumn cotid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewImageColumn cotxoa;
        private DataGridViewImageColumn cotsua;
    }
}