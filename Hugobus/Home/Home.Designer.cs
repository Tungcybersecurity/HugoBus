namespace GUI.Home
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panelMenu = new Panel();
            buttonQLNhanVien = new Button();
            buttonQLDoanhThu = new Button();
            buttonQLPhanCong = new Button();
            buttonQLChuyen = new Button();
            buttonQLHợpĐồng = new Button();
            buttonQlTaiKhoan = new Button();
            buttonStudent = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panelHome = new Panel();
            labelHome = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelHome.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.MediumSeaGreen;
            panelMenu.Controls.Add(buttonQLNhanVien);
            panelMenu.Controls.Add(buttonQLDoanhThu);
            panelMenu.Controls.Add(buttonQLPhanCong);
            panelMenu.Controls.Add(buttonQLChuyen);
            panelMenu.Controls.Add(buttonQLHợpĐồng);
            panelMenu.Controls.Add(buttonQlTaiKhoan);
            panelMenu.Controls.Add(buttonStudent);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 944);
            panelMenu.TabIndex = 0;
            // 
            // buttonQLNhanVien
            // 
            buttonQLNhanVien.Dock = DockStyle.Top;
            buttonQLNhanVien.FlatAppearance.BorderSize = 0;
            buttonQLNhanVien.FlatStyle = FlatStyle.Flat;
            buttonQLNhanVien.ForeColor = Color.White;
            buttonQLNhanVien.Image = (Image)resources.GetObject("buttonQLNhanVien.Image");
            buttonQLNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQLNhanVien.Location = new Point(0, 700);
            buttonQLNhanVien.Name = "buttonQLNhanVien";
            buttonQLNhanVien.Padding = new Padding(25, 0, 0, 0);
            buttonQLNhanVien.Size = new Size(300, 100);
            buttonQLNhanVien.TabIndex = 7;
            buttonQLNhanVien.Text = "   Nhân viên";
            buttonQLNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            buttonQLNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonQLNhanVien.UseVisualStyleBackColor = true;
            buttonQLNhanVien.Click += buttonQLNhanVien_Click;
            // 
            // buttonQLDoanhThu
            // 
            buttonQLDoanhThu.Dock = DockStyle.Top;
            buttonQLDoanhThu.FlatAppearance.BorderSize = 0;
            buttonQLDoanhThu.FlatStyle = FlatStyle.Flat;
            buttonQLDoanhThu.ForeColor = Color.White;
            buttonQLDoanhThu.Image = (Image)resources.GetObject("buttonQLDoanhThu.Image");
            buttonQLDoanhThu.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQLDoanhThu.Location = new Point(0, 600);
            buttonQLDoanhThu.Name = "buttonQLDoanhThu";
            buttonQLDoanhThu.Padding = new Padding(25, 0, 0, 0);
            buttonQLDoanhThu.Size = new Size(300, 100);
            buttonQLDoanhThu.TabIndex = 6;
            buttonQLDoanhThu.Text = "   Doanh thu";
            buttonQLDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            buttonQLDoanhThu.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonQLDoanhThu.UseVisualStyleBackColor = true;
            buttonQLDoanhThu.Click += buttonQLDoanhThu_Click;
            // 
            // buttonQLPhanCong
            // 
            buttonQLPhanCong.Dock = DockStyle.Top;
            buttonQLPhanCong.FlatAppearance.BorderSize = 0;
            buttonQLPhanCong.FlatStyle = FlatStyle.Flat;
            buttonQLPhanCong.ForeColor = Color.White;
            buttonQLPhanCong.Image = (Image)resources.GetObject("buttonQLPhanCong.Image");
            buttonQLPhanCong.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQLPhanCong.Location = new Point(0, 500);
            buttonQLPhanCong.Name = "buttonQLPhanCong";
            buttonQLPhanCong.Padding = new Padding(25, 0, 0, 0);
            buttonQLPhanCong.Size = new Size(300, 100);
            buttonQLPhanCong.TabIndex = 5;
            buttonQLPhanCong.Text = "   Phân công";
            buttonQLPhanCong.TextAlign = ContentAlignment.MiddleLeft;
            buttonQLPhanCong.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonQLPhanCong.UseVisualStyleBackColor = true;
            buttonQLPhanCong.Click += buttonQLPhanCong_Click;
            // 
            // buttonQLChuyen
            // 
            buttonQLChuyen.Dock = DockStyle.Top;
            buttonQLChuyen.FlatAppearance.BorderSize = 0;
            buttonQLChuyen.FlatStyle = FlatStyle.Flat;
            buttonQLChuyen.ForeColor = Color.White;
            buttonQLChuyen.Image = (Image)resources.GetObject("buttonQLChuyen.Image");
            buttonQLChuyen.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQLChuyen.Location = new Point(0, 400);
            buttonQLChuyen.Name = "buttonQLChuyen";
            buttonQLChuyen.Padding = new Padding(25, 0, 0, 0);
            buttonQLChuyen.Size = new Size(300, 100);
            buttonQLChuyen.TabIndex = 4;
            buttonQLChuyen.Text = "   Chuyến";
            buttonQLChuyen.TextAlign = ContentAlignment.MiddleLeft;
            buttonQLChuyen.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonQLChuyen.UseVisualStyleBackColor = true;
            buttonQLChuyen.Click += buttonQLChuyen_Click;
            // 
            // buttonQLHợpĐồng
            // 
            buttonQLHợpĐồng.Dock = DockStyle.Top;
            buttonQLHợpĐồng.FlatAppearance.BorderSize = 0;
            buttonQLHợpĐồng.FlatStyle = FlatStyle.Flat;
            buttonQLHợpĐồng.ForeColor = Color.White;
            buttonQLHợpĐồng.Image = (Image)resources.GetObject("buttonQLHợpĐồng.Image");
            buttonQLHợpĐồng.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQLHợpĐồng.Location = new Point(0, 300);
            buttonQLHợpĐồng.Name = "buttonQLHợpĐồng";
            buttonQLHợpĐồng.Padding = new Padding(25, 0, 0, 0);
            buttonQLHợpĐồng.Size = new Size(300, 100);
            buttonQLHợpĐồng.TabIndex = 3;
            buttonQLHợpĐồng.Text = "   Hợp đồng";
            buttonQLHợpĐồng.TextAlign = ContentAlignment.MiddleLeft;
            buttonQLHợpĐồng.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonQLHợpĐồng.UseVisualStyleBackColor = true;
            buttonQLHợpĐồng.Click += buttonQLHợpĐồng_Click;
            // 
            // buttonQlTaiKhoan
            // 
            buttonQlTaiKhoan.Dock = DockStyle.Top;
            buttonQlTaiKhoan.FlatAppearance.BorderSize = 0;
            buttonQlTaiKhoan.FlatStyle = FlatStyle.Flat;
            buttonQlTaiKhoan.ForeColor = Color.White;
            buttonQlTaiKhoan.Image = (Image)resources.GetObject("buttonQlTaiKhoan.Image");
            buttonQlTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQlTaiKhoan.Location = new Point(0, 200);
            buttonQlTaiKhoan.Name = "buttonQlTaiKhoan";
            buttonQlTaiKhoan.Padding = new Padding(25, 0, 0, 0);
            buttonQlTaiKhoan.Size = new Size(300, 100);
            buttonQlTaiKhoan.TabIndex = 2;
            buttonQlTaiKhoan.Text = "   Tài khoản";
            buttonQlTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            buttonQlTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonQlTaiKhoan.UseVisualStyleBackColor = true;
            buttonQlTaiKhoan.Click += buttonQlTaiKhoan_Click;
            // 
            // buttonStudent
            // 
            buttonStudent.Dock = DockStyle.Top;
            buttonStudent.FlatAppearance.BorderSize = 0;
            buttonStudent.FlatStyle = FlatStyle.Flat;
            buttonStudent.ForeColor = Color.White;
            buttonStudent.Image = Properties.Resources.student1;
            buttonStudent.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStudent.Location = new Point(0, 100);
            buttonStudent.Name = "buttonStudent";
            buttonStudent.Padding = new Padding(11, 0, 0, 0);
            buttonStudent.Size = new Size(300, 100);
            buttonStudent.TabIndex = 1;
            buttonStudent.Text = "Học sinh";
            buttonStudent.TextAlign = ContentAlignment.MiddleLeft;
            buttonStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonStudent.UseVisualStyleBackColor = true;
            buttonStudent.Click += buttonStudent_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(240, 60);
            label1.TabIndex = 1;
            label1.Text = "HUGOBUS";
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.SeaGreen;
            panelHome.Controls.Add(labelHome);
            panelHome.Dock = DockStyle.Top;
            panelHome.Location = new Point(300, 0);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1058, 100);
            panelHome.TabIndex = 1;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.ForeColor = Color.White;
            labelHome.Location = new Point(457, 19);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(157, 60);
            labelHome.TabIndex = 0;
            labelHome.Text = "HOME";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 944);
            Controls.Add(panelHome);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1380, 1000);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Minimized;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button buttonStudent;
        private Panel panel1;
        private Button buttonQLDoanhThu;
        private Button buttonQLPhanCong;
        private Button buttonQLChuyen;
        private Button buttonQLHợpĐồng;
        private Button buttonQlTaiKhoan;
        private Button buttonQLNhanVien;
        private Panel panelHome;
        private Label labelHome;
        private Label label1;
    }
}