namespace GUI.Employee.TaiXe
{
    partial class ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD));
            buttonSave = new Button();
            button1 = new Button();
            labelHo = new Label();
            textBoxHo = new TextBox();
            label1 = new Label();
            textBoxTen = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBoxDiaChi = new TextBox();
            label4 = new Label();
            textBoxSDT = new TextBox();
            label5 = new Label();
            textBoxEmail = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            labelErrorHo = new Label();
            labelErrorTen = new Label();
            labelErroDiaChi = new Label();
            labelErrorSDT = new Label();
            labelErroEmail = new Label();
            label7 = new Label();
            textBoxDia = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBoxCCCD = new TextBox();
            label8 = new Label();
            labelErrorCCCD = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.Image = Properties.Resources.saveblack;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(333, 598);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 34);
            buttonSave.TabIndex = 0;
            buttonSave.Text = " Save ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(489, 598);
            button1.Name = "button1";
            button1.Size = new Size(164, 34);
            button1.TabIndex = 0;
            button1.Text = "Clear All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelHo
            // 
            labelHo.AutoSize = true;
            labelHo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHo.Location = new Point(17, 77);
            labelHo.Name = "labelHo";
            labelHo.Size = new Size(39, 28);
            labelHo.TabIndex = 1;
            labelHo.Text = "Họ";
            // 
            // textBoxHo
            // 
            textBoxHo.Location = new Point(112, 77);
            textBoxHo.Name = "textBoxHo";
            textBoxHo.Size = new Size(490, 31);
            textBoxHo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 147);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên";
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(112, 147);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(490, 31);
            textBoxTen.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 266);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(112, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(490, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 333);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ";
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(112, 333);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(843, 31);
            textBoxDiaChi.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 409);
            label4.Name = "label4";
            label4.Size = new Size(48, 28);
            label4.TabIndex = 1;
            label4.Text = "SĐT";
            // 
            // textBoxSDT
            // 
            textBoxSDT.Location = new Point(112, 409);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(843, 31);
            textBoxSDT.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 471);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(112, 471);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(843, 31);
            textBoxEmail.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(707, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 169);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 169);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(755, 222);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Thêm ảnh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelErrorHo
            // 
            labelErrorHo.AutoSize = true;
            labelErrorHo.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorHo.Location = new Point(115, 111);
            labelErrorHo.Name = "labelErrorHo";
            labelErrorHo.Size = new Size(0, 21);
            labelErrorHo.TabIndex = 6;
            // 
            // labelErrorTen
            // 
            labelErrorTen.AutoSize = true;
            labelErrorTen.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorTen.Location = new Point(115, 181);
            labelErrorTen.Name = "labelErrorTen";
            labelErrorTen.Size = new Size(0, 21);
            labelErrorTen.TabIndex = 6;
            // 
            // labelErroDiaChi
            // 
            labelErroDiaChi.AutoSize = true;
            labelErroDiaChi.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErroDiaChi.Location = new Point(115, 367);
            labelErroDiaChi.Name = "labelErroDiaChi";
            labelErroDiaChi.Size = new Size(0, 21);
            labelErroDiaChi.TabIndex = 6;
            // 
            // labelErrorSDT
            // 
            labelErrorSDT.AutoSize = true;
            labelErrorSDT.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorSDT.Location = new Point(115, 443);
            labelErrorSDT.Name = "labelErrorSDT";
            labelErrorSDT.Size = new Size(0, 21);
            labelErrorSDT.TabIndex = 6;
            // 
            // labelErroEmail
            // 
            labelErroEmail.AutoSize = true;
            labelErroEmail.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErroEmail.Location = new Point(112, 507);
            labelErroEmail.Name = "labelErroEmail";
            labelErroEmail.Size = new Size(0, 21);
            labelErroEmail.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 211);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 1;
            label7.Text = "Giới tính";
            // 
            // textBoxDia
            // 
            textBoxDia.Location = new Point(112, 330);
            textBoxDia.Name = "textBoxDia";
            textBoxDia.Size = new Size(843, 31);
            textBoxDia.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox1.Location = new Point(113, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(489, 33);
            comboBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 531);
            label6.Name = "label6";
            label6.Size = new Size(60, 28);
            label6.TabIndex = 1;
            label6.Text = "CCCD";
            // 
            // textBoxCCCD
            // 
            textBoxCCCD.Location = new Point(112, 531);
            textBoxCCCD.Name = "textBoxCCCD";
            textBoxCCCD.Size = new Size(843, 31);
            textBoxCCCD.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(115, 503);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 6;
            // 
            // labelErrorCCCD
            // 
            labelErrorCCCD.AutoSize = true;
            labelErrorCCCD.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorCCCD.Location = new Point(112, 567);
            labelErrorCCCD.Name = "labelErrorCCCD";
            labelErrorCCCD.Size = new Size(0, 21);
            labelErrorCCCD.TabIndex = 6;
            // 
            // ADD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 658);
            Controls.Add(comboBox1);
            Controls.Add(labelErrorCCCD);
            Controls.Add(labelErroEmail);
            Controls.Add(label8);
            Controls.Add(labelErrorSDT);
            Controls.Add(labelErroDiaChi);
            Controls.Add(labelErrorTen);
            Controls.Add(labelErrorHo);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBoxCCCD);
            Controls.Add(label6);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(textBoxSDT);
            Controls.Add(label4);
            Controls.Add(textBoxDia);
            Controls.Add(textBoxDiaChi);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(textBoxTen);
            Controls.Add(label1);
            Controls.Add(textBoxHo);
            Controls.Add(labelHo);
            Controls.Add(button1);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ADD";
            Text = "ADD";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button button1;
        private Label labelHo;
        private TextBox textBoxHo;
        private Label label1;
        private TextBox textBoxTen;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBoxDiaChi;
        private Label label4;
        private TextBox textBoxSDT;
        private Label label5;
        private TextBox textBoxEmail;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label labelErrorHo;
        private Label labelErrorTen;
        private Label labelErroDiaChi;
        private Label labelErrorSDT;
        private Label labelErroEmail;
        private Label label7;
        private TextBox textBoxDia;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBoxCCCD;
        private Label label8;
        private Label labelErrorCCCD;
    }
}