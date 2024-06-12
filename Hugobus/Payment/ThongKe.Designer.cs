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
            panel3 = new Panel();
            label2 = new Label();
            buttonLoadTong = new Button();
            panelTong = new Panel();
            radioButtonTongNam = new RadioButton();
            radioButtonTongThang = new RadioButton();
            radioButtonTongQuy = new RadioButton();
            dataGridViewTong = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            buttonLoadTT = new Button();
            panelTT = new Panel();
            radioButtonTTNam = new RadioButton();
            radioButtonTTThang = new RadioButton();
            radioButtonTTQuy = new RadioButton();
            dataGridViewTT = new DataGridView();
            panel3.SuspendLayout();
            panelTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTong).BeginInit();
            panel1.SuspendLayout();
            panelTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTT).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(buttonLoadTong);
            panel3.Controls.Add(panelTong);
            panel3.Controls.Add(dataGridViewTong);
            panel3.Location = new Point(157, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(535, 541);
            panel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 12);
            label2.Name = "label2";
            label2.Size = new Size(246, 29);
            label2.TabIndex = 7;
            label2.Text = "TỔNG DOANH THU";
            // 
            // buttonLoadTong
            // 
            buttonLoadTong.Location = new Point(415, 476);
            buttonLoadTong.Name = "buttonLoadTong";
            buttonLoadTong.Size = new Size(101, 45);
            buttonLoadTong.TabIndex = 6;
            buttonLoadTong.Text = "Load";
            buttonLoadTong.UseVisualStyleBackColor = true;
            buttonLoadTong.Click += buttonLoadTong_Click;
            // 
            // panelTong
            // 
            panelTong.Controls.Add(radioButtonTongNam);
            panelTong.Controls.Add(radioButtonTongThang);
            panelTong.Controls.Add(radioButtonTongQuy);
            panelTong.Location = new Point(21, 427);
            panelTong.Name = "panelTong";
            panelTong.Size = new Size(495, 43);
            panelTong.TabIndex = 5;
            // 
            // radioButtonTongNam
            // 
            radioButtonTongNam.AutoSize = true;
            radioButtonTongNam.Location = new Point(355, 6);
            radioButtonTongNam.Name = "radioButtonTongNam";
            radioButtonTongNam.Size = new Size(62, 24);
            radioButtonTongNam.TabIndex = 4;
            radioButtonTongNam.TabStop = true;
            radioButtonTongNam.Text = "Năm";
            radioButtonTongNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonTongThang
            // 
            radioButtonTongThang.AutoSize = true;
            radioButtonTongThang.Location = new Point(16, 5);
            radioButtonTongThang.Name = "radioButtonTongThang";
            radioButtonTongThang.Size = new Size(71, 24);
            radioButtonTongThang.TabIndex = 2;
            radioButtonTongThang.TabStop = true;
            radioButtonTongThang.Text = "Tháng";
            radioButtonTongThang.UseVisualStyleBackColor = true;
            // 
            // radioButtonTongQuy
            // 
            radioButtonTongQuy.AutoSize = true;
            radioButtonTongQuy.Location = new Point(187, 6);
            radioButtonTongQuy.Name = "radioButtonTongQuy";
            radioButtonTongQuy.Size = new Size(56, 24);
            radioButtonTongQuy.TabIndex = 3;
            radioButtonTongQuy.TabStop = true;
            radioButtonTongQuy.Text = "Quý";
            radioButtonTongQuy.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTong
            // 
            dataGridViewTong.AllowUserToAddRows = false;
            dataGridViewTong.AllowUserToDeleteRows = false;
            dataGridViewTong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTong.Location = new Point(21, 75);
            dataGridViewTong.Name = "dataGridViewTong";
            dataGridViewTong.RowHeadersWidth = 51;
            dataGridViewTong.RowTemplate.Height = 24;
            dataGridViewTong.Size = new Size(495, 322);
            dataGridViewTong.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonLoadTT);
            panel1.Controls.Add(panelTT);
            panel1.Controls.Add(dataGridViewTT);
            panel1.Location = new Point(715, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 541);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 14);
            label1.Name = "label1";
            label1.Size = new Size(360, 29);
            label1.TabIndex = 7;
            label1.Text = "TĂNG TRƯỞNG DOANH THU";
            // 
            // buttonLoadTT
            // 
            buttonLoadTT.Location = new Point(413, 476);
            buttonLoadTT.Name = "buttonLoadTT";
            buttonLoadTT.Size = new Size(92, 45);
            buttonLoadTT.TabIndex = 6;
            buttonLoadTT.Text = "Load";
            buttonLoadTT.UseVisualStyleBackColor = true;
            buttonLoadTT.Click += buttonLoadTT_Click;
            // 
            // panelTT
            // 
            panelTT.Controls.Add(radioButtonTTNam);
            panelTT.Controls.Add(radioButtonTTThang);
            panelTT.Controls.Add(radioButtonTTQuy);
            panelTT.Location = new Point(21, 427);
            panelTT.Name = "panelTT";
            panelTT.Size = new Size(484, 43);
            panelTT.TabIndex = 5;
            // 
            // radioButtonTTNam
            // 
            radioButtonTTNam.AutoSize = true;
            radioButtonTTNam.Location = new Point(320, 8);
            radioButtonTTNam.Name = "radioButtonTTNam";
            radioButtonTTNam.Size = new Size(62, 24);
            radioButtonTTNam.TabIndex = 4;
            radioButtonTTNam.TabStop = true;
            radioButtonTTNam.Text = "Năm";
            radioButtonTTNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonTTThang
            // 
            radioButtonTTThang.AutoSize = true;
            radioButtonTTThang.Location = new Point(16, 6);
            radioButtonTTThang.Name = "radioButtonTTThang";
            radioButtonTTThang.Size = new Size(71, 24);
            radioButtonTTThang.TabIndex = 2;
            radioButtonTTThang.TabStop = true;
            radioButtonTTThang.Text = "Tháng";
            radioButtonTTThang.UseVisualStyleBackColor = true;
            // 
            // radioButtonTTQuy
            // 
            radioButtonTTQuy.AutoSize = true;
            radioButtonTTQuy.Location = new Point(167, 8);
            radioButtonTTQuy.Name = "radioButtonTTQuy";
            radioButtonTTQuy.Size = new Size(56, 24);
            radioButtonTTQuy.TabIndex = 3;
            radioButtonTTQuy.TabStop = true;
            radioButtonTTQuy.Text = "Quý";
            radioButtonTTQuy.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTT
            // 
            dataGridViewTT.AllowUserToAddRows = false;
            dataGridViewTT.AllowUserToDeleteRows = false;
            dataGridViewTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTT.Location = new Point(21, 75);
            dataGridViewTT.Name = "dataGridViewTT";
            dataGridViewTT.RowHeadersWidth = 51;
            dataGridViewTT.RowTemplate.Height = 24;
            dataGridViewTT.Size = new Size(484, 322);
            dataGridViewTT.TabIndex = 1;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 561);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THỐNG KÊ DOANH THU";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelTong.ResumeLayout(false);
            panelTong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTong).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTT.ResumeLayout(false);
            panelTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Button buttonLoadTong;
        private Panel panelTong;
        private RadioButton radioButtonTongNam;
        private RadioButton radioButtonTongThang;
        private RadioButton radioButtonTongQuy;
        private DataGridView dataGridViewTong;
        private Panel panel1;
        private Label label1;
        private Button buttonLoadTT;
        private Panel panelTT;
        private RadioButton radioButtonTTNam;
        private RadioButton radioButtonTTThang;
        private RadioButton radioButtonTTQuy;
        private DataGridView dataGridViewTT;
    }
}