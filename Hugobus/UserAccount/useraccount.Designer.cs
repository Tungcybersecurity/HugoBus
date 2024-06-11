namespace GUI.UserAccount
{
    partial class useraccount
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewUser = new DataGridView();
            Columnaccount = new DataGridViewTextBoxColumn();
            ColumnHo = new DataGridViewTextBoxColumn();
            ColumnTen = new DataGridViewTextBoxColumn();
            ColumnGioiTinh = new DataGridViewTextBoxColumn();
            ColumnNgaySinh = new DataGridViewTextBoxColumn();
            Columnemail = new DataGridViewTextBoxColumn();
            Columnsdt = new DataGridViewTextBoxColumn();
            Columndiachi = new DataGridViewTextBoxColumn();
            ColumnDelete = new DataGridViewImageColumn();
            ColumnChiTiet = new DataGridViewImageColumn();
            buttonTimkiem = new Button();
            buttonupdate = new Button();
            comboBoxTimKiem = new ComboBox();
            textBoxTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.BackgroundColor = Color.White;
            dataGridViewUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { Columnaccount, ColumnHo, ColumnTen, ColumnGioiTinh, ColumnNgaySinh, Columnemail, Columnsdt, Columndiachi, ColumnDelete, ColumnChiTiet });
            dataGridViewUser.Dock = DockStyle.Top;
            dataGridViewUser.Location = new Point(0, 0);
            dataGridViewUser.Margin = new Padding(2, 3, 2, 3);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewUser.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewUser.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewUser.Size = new Size(914, 444);
            dataGridViewUser.TabIndex = 2;
            dataGridViewUser.CellContentClick += contenClick;
            // 
            // Columnaccount
            // 
            Columnaccount.DataPropertyName = "tendangnhap";
            Columnaccount.HeaderText = "Tên đăng nhập";
            Columnaccount.MinimumWidth = 8;
            Columnaccount.Name = "Columnaccount";
            // 
            // ColumnHo
            // 
            ColumnHo.DataPropertyName = "Ho";
            ColumnHo.HeaderText = "Họ";
            ColumnHo.MinimumWidth = 8;
            ColumnHo.Name = "ColumnHo";
            // 
            // ColumnTen
            // 
            ColumnTen.DataPropertyName = "Ten";
            ColumnTen.HeaderText = "Tên";
            ColumnTen.MinimumWidth = 8;
            ColumnTen.Name = "ColumnTen";
            // 
            // ColumnGioiTinh
            // 
            ColumnGioiTinh.DataPropertyName = "GioiTinh";
            ColumnGioiTinh.HeaderText = "Giới tính";
            ColumnGioiTinh.MinimumWidth = 8;
            ColumnGioiTinh.Name = "ColumnGioiTinh";
            // 
            // ColumnNgaySinh
            // 
            ColumnNgaySinh.DataPropertyName = "NgaySinh";
            ColumnNgaySinh.HeaderText = "Ngày sinh";
            ColumnNgaySinh.MinimumWidth = 8;
            ColumnNgaySinh.Name = "ColumnNgaySinh";
            // 
            // Columnemail
            // 
            Columnemail.DataPropertyName = "email";
            Columnemail.HeaderText = "Email";
            Columnemail.MinimumWidth = 8;
            Columnemail.Name = "Columnemail";
            // 
            // Columnsdt
            // 
            Columnsdt.DataPropertyName = "sdt";
            Columnsdt.HeaderText = "SĐT";
            Columnsdt.MinimumWidth = 8;
            Columnsdt.Name = "Columnsdt";
            // 
            // Columndiachi
            // 
            Columndiachi.DataPropertyName = "diachi";
            Columndiachi.HeaderText = "Địa chỉ";
            Columndiachi.MinimumWidth = 8;
            Columndiachi.Name = "Columndiachi";
            // 
            // ColumnDelete
            // 
            ColumnDelete.HeaderText = "";
            ColumnDelete.Image = Properties.Resources.trash;
            ColumnDelete.MinimumWidth = 8;
            ColumnDelete.Name = "ColumnDelete";
            ColumnDelete.Resizable = DataGridViewTriState.True;
            // 
            // ColumnChiTiet
            // 
            ColumnChiTiet.HeaderText = "";
            ColumnChiTiet.Image = Properties.Resources.moredetail;
            ColumnChiTiet.MinimumWidth = 8;
            ColumnChiTiet.Name = "ColumnChiTiet";
            ColumnChiTiet.Resizable = DataGridViewTriState.True;
            // 
            // buttonTimkiem
            // 
            buttonTimkiem.BackColor = Color.MediumSeaGreen;
            buttonTimkiem.FlatAppearance.BorderColor = Color.DarkGreen;
            buttonTimkiem.FlatStyle = FlatStyle.Popup;
            buttonTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTimkiem.ForeColor = Color.White;
            buttonTimkiem.Location = new Point(599, 516);
            buttonTimkiem.Margin = new Padding(2, 3, 2, 3);
            buttonTimkiem.Name = "buttonTimkiem";
            buttonTimkiem.Size = new Size(120, 40);
            buttonTimkiem.TabIndex = 13;
            buttonTimkiem.Text = "SEARCH";
            buttonTimkiem.UseVisualStyleBackColor = false;
            buttonTimkiem.Click += buttonTimkiem_Click;
            // 
            // buttonupdate
            // 
            buttonupdate.BackColor = Color.MediumSeaGreen;
            buttonupdate.FlatAppearance.BorderColor = Color.DarkGreen;
            buttonupdate.FlatStyle = FlatStyle.Popup;
            buttonupdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonupdate.ForeColor = Color.White;
            buttonupdate.Location = new Point(782, 508);
            buttonupdate.Margin = new Padding(2, 3, 2, 3);
            buttonupdate.Name = "buttonupdate";
            buttonupdate.Size = new Size(120, 48);
            buttonupdate.TabIndex = 14;
            buttonupdate.Text = "UPDATE";
            buttonupdate.UseVisualStyleBackColor = false;
            buttonupdate.Click += buttonupdate_Click;
            // 
            // comboBoxTimKiem
            // 
            comboBoxTimKiem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTimKiem.FormattingEnabled = true;
            comboBoxTimKiem.Items.AddRange(new object[] { "Tên", "Tên đăng nhập", "Địa chỉ", "Email", "Số điện thoại" });
            comboBoxTimKiem.Location = new Point(138, 527);
            comboBoxTimKiem.Margin = new Padding(2, 3, 2, 3);
            comboBoxTimKiem.Name = "comboBoxTimKiem";
            comboBoxTimKiem.Size = new Size(139, 33);
            comboBoxTimKiem.TabIndex = 12;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTimKiem.Location = new Point(313, 516);
            textBoxTimKiem.Margin = new Padding(2, 3, 2, 3);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.Size = new Size(267, 43);
            textBoxTimKiem.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(14, 496);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // useraccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonTimkiem);
            Controls.Add(buttonupdate);
            Controls.Add(comboBoxTimKiem);
            Controls.Add(textBoxTimKiem);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "useraccount";
            Text = "useraccount";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUser;
        private DataGridViewTextBoxColumn Columnaccount;
        private DataGridViewTextBoxColumn ColumnHo;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnGioiTinh;
        private DataGridViewTextBoxColumn ColumnNgaySinh;
        private DataGridViewTextBoxColumn Columnemail;
        private DataGridViewTextBoxColumn Columnsdt;
        private DataGridViewTextBoxColumn Columndiachi;
        private DataGridViewImageColumn ColumnDelete;
        private DataGridViewImageColumn ColumnChiTiet;
        private Button buttonTimkiem;
        private Button buttonupdate;
        private ComboBox comboBoxTimKiem;
        private TextBox textBoxTimKiem;
        private PictureBox pictureBox1;
    }
}