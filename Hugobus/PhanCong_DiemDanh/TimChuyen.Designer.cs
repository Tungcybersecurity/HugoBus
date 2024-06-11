namespace GUI.PhanCong_DiemDanh
{
    partial class TimChuyen
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
            textBoxThu = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxBuoi = new TextBox();
            label3 = new Label();
            textBoxPhuongDon = new TextBox();
            label4 = new Label();
            textBoxTruongDen = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxIDChuyen = new ComboBox();
            label7 = new Label();
            textBoxGheTrong = new TextBox();
            buttonChonChuyen = new Button();
            buttonThoat = new Button();
            SuspendLayout();
            // 
            // textBoxThu
            // 
            textBoxThu.Location = new Point(98, 68);
            textBoxThu.Name = "textBoxThu";
            textBoxThu.ReadOnly = true;
            textBoxThu.Size = new Size(100, 23);
            textBoxThu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 71);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Thứ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 71);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Buổi:";
            // 
            // textBoxBuoi
            // 
            textBoxBuoi.Location = new Point(351, 68);
            textBoxBuoi.Name = "textBoxBuoi";
            textBoxBuoi.ReadOnly = true;
            textBoxBuoi.Size = new Size(100, 23);
            textBoxBuoi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 119);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 5;
            label3.Text = "Phường đón:";
            // 
            // textBoxPhuongDon
            // 
            textBoxPhuongDon.Location = new Point(98, 116);
            textBoxPhuongDon.Name = "textBoxPhuongDon";
            textBoxPhuongDon.ReadOnly = true;
            textBoxPhuongDon.Size = new Size(141, 23);
            textBoxPhuongDon.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 119);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Trường đến:";
            // 
            // textBoxTruongDen
            // 
            textBoxTruongDen.Location = new Point(351, 117);
            textBoxTruongDen.Name = "textBoxTruongDen";
            textBoxTruongDen.ReadOnly = true;
            textBoxTruongDen.Size = new Size(180, 23);
            textBoxTruongDen.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(215, 9);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 8;
            label5.Text = "TÌM CHUYẾN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 166);
            label6.Name = "label6";
            label6.Size = new Size(179, 15);
            label6.TabIndex = 9;
            label6.Text = "Các chuyến phù hợp: ID chuyến:";
            // 
            // comboBoxIDChuyen
            // 
            comboBoxIDChuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIDChuyen.FormattingEnabled = true;
            comboBoxIDChuyen.Location = new Point(201, 163);
            comboBoxIDChuyen.Name = "comboBoxIDChuyen";
            comboBoxIDChuyen.Size = new Size(73, 23);
            comboBoxIDChuyen.TabIndex = 10;
            comboBoxIDChuyen.SelectedIndexChanged += comboBoxIDChuyen_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(314, 166);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 11;
            label7.Text = "Số ghế còn trống:";
            // 
            // textBoxGheTrong
            // 
            textBoxGheTrong.Location = new Point(421, 163);
            textBoxGheTrong.Name = "textBoxGheTrong";
            textBoxGheTrong.ReadOnly = true;
            textBoxGheTrong.Size = new Size(100, 23);
            textBoxGheTrong.TabIndex = 12;
            // 
            // buttonChonChuyen
            // 
            buttonChonChuyen.Location = new Point(351, 201);
            buttonChonChuyen.Name = "buttonChonChuyen";
            buttonChonChuyen.Size = new Size(111, 33);
            buttonChonChuyen.TabIndex = 13;
            buttonChonChuyen.Text = "Chọn chuyến";
            buttonChonChuyen.UseVisualStyleBackColor = true;
            buttonChonChuyen.Click += buttonChonChuyen_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(64, 201);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(93, 33);
            buttonThoat.TabIndex = 14;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // TimChuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 246);
            Controls.Add(buttonThoat);
            Controls.Add(buttonChonChuyen);
            Controls.Add(textBoxGheTrong);
            Controls.Add(label7);
            Controls.Add(comboBoxIDChuyen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxTruongDen);
            Controls.Add(label3);
            Controls.Add(textBoxPhuongDon);
            Controls.Add(label2);
            Controls.Add(textBoxBuoi);
            Controls.Add(label1);
            Controls.Add(textBoxThu);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TimChuyen";
            Text = "TÌM CHUYẾN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxThu;
        private Label label1;
        private Label label2;
        private TextBox textBoxBuoi;
        private Label label3;
        private TextBox textBoxPhuongDon;
        private Label label4;
        private TextBox textBoxTruongDen;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxIDChuyen;
        private Label label7;
        private TextBox textBoxGheTrong;
        private Button buttonChonChuyen;
        private Button buttonThoat;
    }
}