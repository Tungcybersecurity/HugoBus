namespace GUI.Student
{
    partial class StudentMain
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewHocSinh = new DataGridView();
            pictureBox1 = new PictureBox();
            textBoxTimKiem = new TextBox();
            comboBoxTimKiem = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonupdate = new Button();
            buttonTimkiem = new Button();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnHo = new DataGridViewTextBoxColumn();
            ColumnTen = new DataGridViewTextBoxColumn();
            ColumnGioiTinh = new DataGridViewTextBoxColumn();
            ColumnNgaySinh = new DataGridViewTextBoxColumn();
            ColumnTruong = new DataGridViewTextBoxColumn();
            ColumnLop = new DataGridViewTextBoxColumn();
            ColumnTenDangNhap = new DataGridViewTextBoxColumn();
            Columnfilepath = new DataGridViewTextBoxColumn();
            ColumnDelete = new DataGridViewImageColumn();
            ColumnChiTiet = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocSinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHocSinh
            // 
            dataGridViewHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHocSinh.BackgroundColor = Color.White;
            dataGridViewHocSinh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHocSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHocSinh.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnHo, ColumnTen, ColumnGioiTinh, ColumnNgaySinh, ColumnTruong, ColumnLop, ColumnTenDangNhap, Columnfilepath, ColumnDelete, ColumnChiTiet });
            dataGridViewHocSinh.Dock = DockStyle.Top;
            dataGridViewHocSinh.Location = new Point(0, 0);
            dataGridViewHocSinh.Name = "dataGridViewHocSinh";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewHocSinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHocSinh.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewHocSinh.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHocSinh.Size = new Size(1330, 555);
            dataGridViewHocSinh.TabIndex = 0;
            dataGridViewHocSinh.CellClick += Event_CellClík;
            dataGridViewHocSinh.CellContentClick += content;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(15, 608);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTimKiem.Location = new Point(390, 633);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.Size = new Size(333, 50);
            textBoxTimKiem.TabIndex = 2;
            // 
            // comboBoxTimKiem
            // 
            comboBoxTimKiem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTimKiem.FormattingEnabled = true;
            comboBoxTimKiem.Items.AddRange(new object[] { "Trường", "Tên", "ID", "Tên đăng nhập" });
            comboBoxTimKiem.Location = new Point(171, 645);
            comboBoxTimKiem.Name = "comboBoxTimKiem";
            comboBoxTimKiem.Size = new Size(173, 38);
            comboBoxTimKiem.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 30000;
            timer1.Tick += timer1_Tick;
            // 
            // buttonupdate
            // 
            buttonupdate.BackColor = Color.MediumSeaGreen;
            buttonupdate.FlatAppearance.BorderColor = Color.DarkGreen;
            buttonupdate.FlatStyle = FlatStyle.Popup;
            buttonupdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonupdate.ForeColor = Color.White;
            buttonupdate.Location = new Point(975, 623);
            buttonupdate.Name = "buttonupdate";
            buttonupdate.Size = new Size(150, 60);
            buttonupdate.TabIndex = 4;
            buttonupdate.Text = "UPDATE";
            buttonupdate.UseVisualStyleBackColor = false;
            // 
            // buttonTimkiem
            // 
            buttonTimkiem.BackColor = Color.MediumSeaGreen;
            buttonTimkiem.FlatAppearance.BorderColor = Color.DarkGreen;
            buttonTimkiem.FlatStyle = FlatStyle.Popup;
            buttonTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTimkiem.ForeColor = Color.White;
            buttonTimkiem.Location = new Point(747, 633);
            buttonTimkiem.Name = "buttonTimkiem";
            buttonTimkiem.Size = new Size(150, 50);
            buttonTimkiem.TabIndex = 4;
            buttonTimkiem.Text = "SEARCH";
            buttonTimkiem.UseVisualStyleBackColor = false;
            buttonTimkiem.Click += buttonTimkiem_Click;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "IdHocSinh";
            ColumnId.HeaderText = "Id";
            ColumnId.MinimumWidth = 8;
            ColumnId.Name = "ColumnId";
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
            // ColumnTruong
            // 
            ColumnTruong.DataPropertyName = "Truong";
            ColumnTruong.HeaderText = "Trường";
            ColumnTruong.MinimumWidth = 8;
            ColumnTruong.Name = "ColumnTruong";
            // 
            // ColumnLop
            // 
            ColumnLop.DataPropertyName = "Lop";
            ColumnLop.HeaderText = "Lớp";
            ColumnLop.MinimumWidth = 8;
            ColumnLop.Name = "ColumnLop";
            // 
            // ColumnTenDangNhap
            // 
            ColumnTenDangNhap.DataPropertyName = "TenDangNhap";
            ColumnTenDangNhap.HeaderText = "Tên đăng nhập";
            ColumnTenDangNhap.MinimumWidth = 8;
            ColumnTenDangNhap.Name = "ColumnTenDangNhap";
            // 
            // Columnfilepath
            // 
            Columnfilepath.DataPropertyName = "filepathimage";
            Columnfilepath.HeaderText = "Columnfile";
            Columnfilepath.MinimumWidth = 8;
            Columnfilepath.Name = "Columnfilepath";
            Columnfilepath.Visible = false;
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
            // StudentMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1330, 870);
            Controls.Add(buttonTimkiem);
            Controls.Add(buttonupdate);
            Controls.Add(comboBoxTimKiem);
            Controls.Add(textBoxTimKiem);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewHocSinh);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1159, 618);
            Name = "StudentMain";
            Text = "StudentMain";
            Load += load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHocSinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHocSinh;
        private PictureBox pictureBox1;
        private TextBox textBoxTimKiem;
        private ComboBox comboBoxTimKiem;
        private System.Windows.Forms.Timer timer1;
        private Button buttonupdate;
        private Button buttonTimkiem;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnHo;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnGioiTinh;
        private DataGridViewTextBoxColumn ColumnNgaySinh;
        private DataGridViewTextBoxColumn ColumnTruong;
        private DataGridViewTextBoxColumn ColumnLop;
        private DataGridViewTextBoxColumn ColumnTenDangNhap;
        private DataGridViewTextBoxColumn Columnfilepath;
        private DataGridViewImageColumn ColumnDelete;
        private DataGridViewImageColumn ColumnChiTiet;
    }
}