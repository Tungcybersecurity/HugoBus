namespace GUI.Contract
{
    partial class ContractDetails
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
            label1 = new Label();
            panel1 = new Panel();
            cbxTrangThai = new ComboBox();
            tbxTruongDen = new TextBox();
            tbxTramDon = new TextBox();
            tbxNgayKetThuc = new TextBox();
            tbxNgayBatDau = new TextBox();
            tbxNgayTao = new TextBox();
            tbxIDHocSinh = new TextBox();
            tbxIDHopDong = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            checkboxSang2 = new CheckBox();
            checkboxChieu2 = new CheckBox();
            checkboxSang3 = new CheckBox();
            checkboxChieu3 = new CheckBox();
            checkboxSang4 = new CheckBox();
            checkboxChieu4 = new CheckBox();
            checkboxSang5 = new CheckBox();
            checkboxChieu5 = new CheckBox();
            checkboxSang6 = new CheckBox();
            checkboxChieu6 = new CheckBox();
            checkboxSang7 = new CheckBox();
            checkboxChieu7 = new CheckBox();
            panel3 = new Panel();
            buttonThoat = new Button();
            buttonCapNhatTrangThai = new Button();
            buttonLuu = new Button();
            tbxNgayCapNhat = new TextBox();
            label18 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 12);
            label1.Name = "label1";
            label1.Size = new Size(271, 37);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT HỢP ĐỒNG";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxTrangThai);
            panel1.Controls.Add(tbxTruongDen);
            panel1.Controls.Add(tbxTramDon);
            panel1.Controls.Add(tbxNgayKetThuc);
            panel1.Controls.Add(tbxNgayBatDau);
            panel1.Controls.Add(tbxNgayTao);
            panel1.Controls.Add(tbxIDHocSinh);
            panel1.Controls.Add(tbxIDHopDong);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(14, 68);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 152);
            panel1.TabIndex = 1;
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTrangThai.Enabled = false;
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Items.AddRange(new object[] { "Chờ xác nhận", "Chờ thanh toán", "Đang hiệu lực", "Hết hiệu lực", "Hủy", "Không đủ điều kiện", "Đã thanh toán, chờ hiệu lực" });
            cbxTrangThai.Location = new Point(410, 113);
            cbxTrangThai.Margin = new Padding(3, 4, 3, 4);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(173, 28);
            cbxTrangThai.TabIndex = 37;
            // 
            // tbxTruongDen
            // 
            tbxTruongDen.Location = new Point(693, 65);
            tbxTruongDen.Margin = new Padding(3, 4, 3, 4);
            tbxTruongDen.Name = "tbxTruongDen";
            tbxTruongDen.ReadOnly = true;
            tbxTruongDen.Size = new Size(182, 27);
            tbxTruongDen.TabIndex = 36;
            // 
            // tbxTramDon
            // 
            tbxTramDon.Location = new Point(693, 17);
            tbxTramDon.Margin = new Padding(3, 4, 3, 4);
            tbxTramDon.Name = "tbxTramDon";
            tbxTramDon.ReadOnly = true;
            tbxTramDon.Size = new Size(182, 27);
            tbxTramDon.TabIndex = 35;
            // 
            // tbxNgayKetThuc
            // 
            tbxNgayKetThuc.Location = new Point(410, 67);
            tbxNgayKetThuc.Margin = new Padding(3, 4, 3, 4);
            tbxNgayKetThuc.Name = "tbxNgayKetThuc";
            tbxNgayKetThuc.ReadOnly = true;
            tbxNgayKetThuc.Size = new Size(173, 27);
            tbxNgayKetThuc.TabIndex = 33;
            // 
            // tbxNgayBatDau
            // 
            tbxNgayBatDau.Location = new Point(410, 19);
            tbxNgayBatDau.Margin = new Padding(3, 4, 3, 4);
            tbxNgayBatDau.Name = "tbxNgayBatDau";
            tbxNgayBatDau.ReadOnly = true;
            tbxNgayBatDau.Size = new Size(173, 27);
            tbxNgayBatDau.TabIndex = 32;
            // 
            // tbxNgayTao
            // 
            tbxNgayTao.Location = new Point(109, 113);
            tbxNgayTao.Margin = new Padding(3, 4, 3, 4);
            tbxNgayTao.Name = "tbxNgayTao";
            tbxNgayTao.ReadOnly = true;
            tbxNgayTao.Size = new Size(167, 27);
            tbxNgayTao.TabIndex = 31;
            // 
            // tbxIDHocSinh
            // 
            tbxIDHocSinh.Location = new Point(109, 67);
            tbxIDHocSinh.Margin = new Padding(3, 4, 3, 4);
            tbxIDHocSinh.Name = "tbxIDHocSinh";
            tbxIDHocSinh.ReadOnly = true;
            tbxIDHocSinh.Size = new Size(114, 27);
            tbxIDHocSinh.TabIndex = 30;
            // 
            // tbxIDHopDong
            // 
            tbxIDHopDong.Location = new Point(109, 19);
            tbxIDHopDong.Margin = new Padding(3, 4, 3, 4);
            tbxIDHopDong.Name = "tbxIDHopDong";
            tbxIDHopDong.ReadOnly = true;
            tbxIDHopDong.Size = new Size(114, 27);
            tbxIDHopDong.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(602, 69);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 28;
            label8.Text = "Trường đến:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(602, 21);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 27;
            label7.Text = "Trạm đón:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(311, 117);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 26;
            label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 71);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 25;
            label5.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 23);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 24;
            label4.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 117);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 23;
            label3.Text = "Ngày tạo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 71);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 22;
            label2.Text = "ID học sinh:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 23);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 21;
            label9.Text = "ID hợp đồng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(3, 228);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 215);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(label10, 1, 0);
            tableLayoutPanel1.Controls.Add(label11, 2, 0);
            tableLayoutPanel1.Controls.Add(label12, 3, 0);
            tableLayoutPanel1.Controls.Add(label13, 4, 0);
            tableLayoutPanel1.Controls.Add(label14, 5, 0);
            tableLayoutPanel1.Controls.Add(label15, 6, 0);
            tableLayoutPanel1.Controls.Add(label16, 0, 1);
            tableLayoutPanel1.Controls.Add(label17, 0, 2);
            tableLayoutPanel1.Controls.Add(checkboxSang2, 1, 1);
            tableLayoutPanel1.Controls.Add(checkboxChieu2, 1, 2);
            tableLayoutPanel1.Controls.Add(checkboxSang3, 2, 1);
            tableLayoutPanel1.Controls.Add(checkboxChieu3, 2, 2);
            tableLayoutPanel1.Controls.Add(checkboxSang4, 3, 1);
            tableLayoutPanel1.Controls.Add(checkboxChieu4, 3, 2);
            tableLayoutPanel1.Controls.Add(checkboxSang5, 4, 1);
            tableLayoutPanel1.Controls.Add(checkboxChieu5, 4, 2);
            tableLayoutPanel1.Controls.Add(checkboxSang6, 5, 1);
            tableLayoutPanel1.Controls.Add(checkboxChieu6, 5, 2);
            tableLayoutPanel1.Controls.Add(checkboxSang7, 6, 1);
            tableLayoutPanel1.Controls.Add(checkboxChieu7, 6, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(909, 211);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(132, 0);
            label10.Name = "label10";
            label10.Size = new Size(123, 70);
            label10.TabIndex = 0;
            label10.Text = "Thứ 2";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(261, 0);
            label11.Name = "label11";
            label11.Size = new Size(123, 70);
            label11.TabIndex = 1;
            label11.Text = "Thứ 3";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(390, 0);
            label12.Name = "label12";
            label12.Size = new Size(123, 70);
            label12.TabIndex = 2;
            label12.Text = "Thứ 4";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(519, 0);
            label13.Name = "label13";
            label13.Size = new Size(123, 70);
            label13.TabIndex = 3;
            label13.Text = "Thứ 5";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(648, 0);
            label14.Name = "label14";
            label14.Size = new Size(123, 70);
            label14.TabIndex = 4;
            label14.Text = "Thứ 6";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(777, 0);
            label15.Name = "label15";
            label15.Size = new Size(129, 70);
            label15.TabIndex = 5;
            label15.Text = "Thứ 7";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(3, 70);
            label16.Name = "label16";
            label16.Size = new Size(123, 70);
            label16.TabIndex = 6;
            label16.Text = "Sáng";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(3, 140);
            label17.Name = "label17";
            label17.Size = new Size(123, 71);
            label17.TabIndex = 7;
            label17.Text = "Chiều";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkboxSang2
            // 
            checkboxSang2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxSang2.AutoCheck = false;
            checkboxSang2.AutoSize = true;
            checkboxSang2.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxSang2.Location = new Point(132, 74);
            checkboxSang2.Margin = new Padding(3, 4, 3, 4);
            checkboxSang2.Name = "checkboxSang2";
            checkboxSang2.Size = new Size(123, 62);
            checkboxSang2.TabIndex = 8;
            checkboxSang2.TextAlign = ContentAlignment.MiddleCenter;
            checkboxSang2.UseVisualStyleBackColor = true;
            // 
            // checkboxChieu2
            // 
            checkboxChieu2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxChieu2.AutoCheck = false;
            checkboxChieu2.AutoSize = true;
            checkboxChieu2.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxChieu2.Location = new Point(132, 144);
            checkboxChieu2.Margin = new Padding(3, 4, 3, 4);
            checkboxChieu2.Name = "checkboxChieu2";
            checkboxChieu2.Size = new Size(123, 63);
            checkboxChieu2.TabIndex = 9;
            checkboxChieu2.TextAlign = ContentAlignment.MiddleCenter;
            checkboxChieu2.UseVisualStyleBackColor = true;
            // 
            // checkboxSang3
            // 
            checkboxSang3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxSang3.AutoCheck = false;
            checkboxSang3.AutoSize = true;
            checkboxSang3.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxSang3.Location = new Point(261, 74);
            checkboxSang3.Margin = new Padding(3, 4, 3, 4);
            checkboxSang3.Name = "checkboxSang3";
            checkboxSang3.Size = new Size(123, 62);
            checkboxSang3.TabIndex = 10;
            checkboxSang3.TextAlign = ContentAlignment.MiddleCenter;
            checkboxSang3.UseVisualStyleBackColor = true;
            // 
            // checkboxChieu3
            // 
            checkboxChieu3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxChieu3.AutoCheck = false;
            checkboxChieu3.AutoSize = true;
            checkboxChieu3.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxChieu3.Location = new Point(261, 144);
            checkboxChieu3.Margin = new Padding(3, 4, 3, 4);
            checkboxChieu3.Name = "checkboxChieu3";
            checkboxChieu3.Size = new Size(123, 63);
            checkboxChieu3.TabIndex = 11;
            checkboxChieu3.TextAlign = ContentAlignment.MiddleCenter;
            checkboxChieu3.UseVisualStyleBackColor = true;
            // 
            // checkboxSang4
            // 
            checkboxSang4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxSang4.AutoCheck = false;
            checkboxSang4.AutoSize = true;
            checkboxSang4.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxSang4.Location = new Point(390, 74);
            checkboxSang4.Margin = new Padding(3, 4, 3, 4);
            checkboxSang4.Name = "checkboxSang4";
            checkboxSang4.Size = new Size(123, 62);
            checkboxSang4.TabIndex = 12;
            checkboxSang4.TextAlign = ContentAlignment.MiddleCenter;
            checkboxSang4.UseVisualStyleBackColor = true;
            // 
            // checkboxChieu4
            // 
            checkboxChieu4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxChieu4.AutoCheck = false;
            checkboxChieu4.AutoSize = true;
            checkboxChieu4.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxChieu4.Location = new Point(390, 144);
            checkboxChieu4.Margin = new Padding(3, 4, 3, 4);
            checkboxChieu4.Name = "checkboxChieu4";
            checkboxChieu4.Size = new Size(123, 63);
            checkboxChieu4.TabIndex = 13;
            checkboxChieu4.TextAlign = ContentAlignment.MiddleCenter;
            checkboxChieu4.UseVisualStyleBackColor = true;
            // 
            // checkboxSang5
            // 
            checkboxSang5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxSang5.AutoCheck = false;
            checkboxSang5.AutoSize = true;
            checkboxSang5.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxSang5.Location = new Point(519, 74);
            checkboxSang5.Margin = new Padding(3, 4, 3, 4);
            checkboxSang5.Name = "checkboxSang5";
            checkboxSang5.Size = new Size(123, 62);
            checkboxSang5.TabIndex = 14;
            checkboxSang5.TextAlign = ContentAlignment.MiddleCenter;
            checkboxSang5.UseVisualStyleBackColor = true;
            // 
            // checkboxChieu5
            // 
            checkboxChieu5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxChieu5.AutoCheck = false;
            checkboxChieu5.AutoSize = true;
            checkboxChieu5.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxChieu5.Location = new Point(519, 144);
            checkboxChieu5.Margin = new Padding(3, 4, 3, 4);
            checkboxChieu5.Name = "checkboxChieu5";
            checkboxChieu5.Size = new Size(123, 63);
            checkboxChieu5.TabIndex = 15;
            checkboxChieu5.TextAlign = ContentAlignment.MiddleCenter;
            checkboxChieu5.UseVisualStyleBackColor = true;
            // 
            // checkboxSang6
            // 
            checkboxSang6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxSang6.AutoCheck = false;
            checkboxSang6.AutoSize = true;
            checkboxSang6.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxSang6.Location = new Point(648, 74);
            checkboxSang6.Margin = new Padding(3, 4, 3, 4);
            checkboxSang6.Name = "checkboxSang6";
            checkboxSang6.Size = new Size(123, 62);
            checkboxSang6.TabIndex = 16;
            checkboxSang6.TextAlign = ContentAlignment.MiddleCenter;
            checkboxSang6.UseVisualStyleBackColor = true;
            // 
            // checkboxChieu6
            // 
            checkboxChieu6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxChieu6.AutoCheck = false;
            checkboxChieu6.AutoSize = true;
            checkboxChieu6.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxChieu6.Location = new Point(648, 144);
            checkboxChieu6.Margin = new Padding(3, 4, 3, 4);
            checkboxChieu6.Name = "checkboxChieu6";
            checkboxChieu6.Size = new Size(123, 63);
            checkboxChieu6.TabIndex = 17;
            checkboxChieu6.TextAlign = ContentAlignment.MiddleCenter;
            checkboxChieu6.UseVisualStyleBackColor = true;
            // 
            // checkboxSang7
            // 
            checkboxSang7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxSang7.AutoCheck = false;
            checkboxSang7.AutoSize = true;
            checkboxSang7.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxSang7.Location = new Point(777, 74);
            checkboxSang7.Margin = new Padding(3, 4, 3, 4);
            checkboxSang7.Name = "checkboxSang7";
            checkboxSang7.Size = new Size(129, 62);
            checkboxSang7.TabIndex = 18;
            checkboxSang7.TextAlign = ContentAlignment.MiddleCenter;
            checkboxSang7.UseVisualStyleBackColor = true;
            // 
            // checkboxChieu7
            // 
            checkboxChieu7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxChieu7.AutoCheck = false;
            checkboxChieu7.AutoSize = true;
            checkboxChieu7.CheckAlign = ContentAlignment.MiddleCenter;
            checkboxChieu7.Location = new Point(777, 144);
            checkboxChieu7.Margin = new Padding(3, 4, 3, 4);
            checkboxChieu7.Name = "checkboxChieu7";
            checkboxChieu7.Size = new Size(129, 63);
            checkboxChieu7.TabIndex = 19;
            checkboxChieu7.TextAlign = ContentAlignment.MiddleCenter;
            checkboxChieu7.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonThoat);
            panel3.Controls.Add(buttonCapNhatTrangThai);
            panel3.Controls.Add(buttonLuu);
            panel3.Location = new Point(14, 447);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(887, 84);
            panel3.TabIndex = 3;
            // 
            // buttonThoat
            // 
            buttonThoat.Font = new Font("Segoe UI", 12F);
            buttonThoat.Location = new Point(767, 15);
            buttonThoat.Margin = new Padding(3, 4, 3, 4);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(109, 53);
            buttonThoat.TabIndex = 2;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonCapNhatTrangThai
            // 
            buttonCapNhatTrangThai.Font = new Font("Segoe UI", 12F);
            buttonCapNhatTrangThai.Location = new Point(345, 15);
            buttonCapNhatTrangThai.Margin = new Padding(3, 4, 3, 4);
            buttonCapNhatTrangThai.Name = "buttonCapNhatTrangThai";
            buttonCapNhatTrangThai.Size = new Size(221, 53);
            buttonCapNhatTrangThai.TabIndex = 1;
            buttonCapNhatTrangThai.Text = "Cập nhật trạng thái";
            buttonCapNhatTrangThai.UseVisualStyleBackColor = true;
            buttonCapNhatTrangThai.Click += buttonCapNhatTrangThai_Click;
            // 
            // buttonLuu
            // 
            buttonLuu.Enabled = false;
            buttonLuu.Font = new Font("Segoe UI", 12F);
            buttonLuu.Location = new Point(16, 15);
            buttonLuu.Margin = new Padding(3, 4, 3, 4);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(99, 53);
            buttonLuu.TabIndex = 0;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = true;
            buttonLuu.Click += buttonLuu_Click;
            // 
            // tbxNgayCapNhat
            // 
            tbxNgayCapNhat.Location = new Point(182, 8);
            tbxNgayCapNhat.Margin = new Padding(3, 4, 3, 4);
            tbxNgayCapNhat.Name = "tbxNgayCapNhat";
            tbxNgayCapNhat.ReadOnly = true;
            tbxNgayCapNhat.Size = new Size(215, 27);
            tbxNgayCapNhat.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 12);
            label18.Name = "label18";
            label18.Size = new Size(176, 20);
            label18.TabIndex = 39;
            label18.Text = "Ngày cập nhật trạng thái:";
            // 
            // ContractDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(914, 535);
            Controls.Add(tbxNgayCapNhat);
            Controls.Add(label18);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ContractDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHI TIẾT HỢP ĐỒNG";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox tbxTruongDen;
        private TextBox tbxTramDon;
        private TextBox tbxNgayKetThuc;
        private TextBox tbxNgayBatDau;
        private TextBox tbxNgayTao;
        private TextBox tbxIDHocSinh;
        private TextBox tbxIDHopDong;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private CheckBox checkboxSang2;
        private CheckBox checkboxChieu2;
        private CheckBox checkboxSang3;
        private CheckBox checkboxChieu3;
        private CheckBox checkboxSang4;
        private CheckBox checkboxChieu4;
        private CheckBox checkboxSang5;
        private CheckBox checkboxChieu5;
        private CheckBox checkboxSang6;
        private CheckBox checkboxChieu6;
        private CheckBox checkboxSang7;
        private CheckBox checkboxChieu7;
        private Panel panel3;
        private Button buttonThoat;
        private Button buttonCapNhatTrangThai;
        private Button buttonLuu;
        private TextBox tbxNgayCapNhat;
        private Label label18;
        private ComboBox cbxTrangThai;
    }
}