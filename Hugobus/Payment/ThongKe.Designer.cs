namespace GUI.Payment
{
    partial class ThongKe
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
            panel1 = new Panel();
            labelTong = new Label();
            dateTimePickerNgayKetThuc = new DateTimePicker();
            dateTimePickerNgayBatDau = new DateTimePicker();
            buttonThongKe = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridViewThongKe = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongKe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(labelTong);
            panel1.Controls.Add(dateTimePickerNgayKetThuc);
            panel1.Controls.Add(dateTimePickerNgayBatDau);
            panel1.Controls.Add(buttonThongKe);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 164);
            panel1.TabIndex = 3;
            // 
            // labelTong
            // 
            labelTong.AutoSize = true;
            labelTong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTong.ForeColor = SystemColors.ControlLightLight;
            labelTong.Location = new Point(12, 131);
            labelTong.Name = "labelTong";
            labelTong.Size = new Size(56, 21);
            labelTong.TabIndex = 11;
            labelTong.Text = "Tổng: ";
            // 
            // dateTimePickerNgayKetThuc
            // 
            dateTimePickerNgayKetThuc.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayKetThuc.Location = new Point(942, 59);
            dateTimePickerNgayKetThuc.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            dateTimePickerNgayKetThuc.Size = new Size(219, 23);
            dateTimePickerNgayKetThuc.TabIndex = 10;
            // 
            // dateTimePickerNgayBatDau
            // 
            dateTimePickerNgayBatDau.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayBatDau.Location = new Point(604, 59);
            dateTimePickerNgayBatDau.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            dateTimePickerNgayBatDau.Size = new Size(219, 23);
            dateTimePickerNgayBatDau.TabIndex = 9;
            // 
            // buttonThongKe
            // 
            buttonThongKe.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonThongKe.Location = new Point(1049, 98);
            buttonThongKe.Margin = new Padding(3, 2, 3, 2);
            buttonThongKe.Name = "buttonThongKe";
            buttonThongKe.Size = new Size(109, 28);
            buttonThongKe.TabIndex = 6;
            buttonThongKe.Text = "Thống kê";
            buttonThongKe.UseVisualStyleBackColor = true;
            buttonThongKe.Click += buttonThongKe_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(857, 59);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(528, 59);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(852, 7);
            label1.Name = "label1";
            label1.Size = new Size(256, 30);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // dataGridViewThongKe
            // 
            dataGridViewThongKe.BackgroundColor = SystemColors.ControlLight;
            dataGridViewThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewThongKe.Dock = DockStyle.Fill;
            dataGridViewThongKe.Location = new Point(0, 0);
            dataGridViewThongKe.Margin = new Padding(3, 2, 3, 2);
            dataGridViewThongKe.Name = "dataGridViewThongKe";
            dataGridViewThongKe.RowHeadersWidth = 51;
            dataGridViewThongKe.RowTemplate.Height = 29;
            dataGridViewThongKe.Size = new Size(1224, 566);
            dataGridViewThongKe.TabIndex = 4;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 566);
            Controls.Add(panel1);
            Controls.Add(dataGridViewThongKe);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THỐNG KÊ DOANH THU";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePickerNgayKetThuc;
        private DateTimePicker dateTimePickerNgayBatDau;
        private Button buttonThongKe;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewThongKe;
        private Label labelTong;
    }
}