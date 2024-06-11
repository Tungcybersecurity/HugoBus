namespace GUI.Chuyen
{
    partial class Chuyen
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
            tripTable = new Zuby.ADGV.AdvancedDataGridView();
            panel1 = new Panel();
            buttonReset = new Button();
            comboBoxBuoi = new ComboBox();
            label7 = new Label();
            comboBoxThu = new ComboBox();
            label6 = new Label();
            comboBoxTruong = new ComboBox();
            comboBoxPhuong = new ComboBox();
            comboBoxXe = new ComboBox();
            comboBoxBaoMau = new ComboBox();
            comboBoxTaiXe = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tripTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tripTable
            // 
            tripTable.AllowUserToAddRows = false;
            tripTable.AllowUserToDeleteRows = false;
            tripTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tripTable.BackgroundColor = Color.White;
            tripTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            tripTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tripTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tripTable.Dock = DockStyle.Top;
            tripTable.FilterAndSortEnabled = true;
            tripTable.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            tripTable.Location = new Point(0, 0);
            tripTable.Margin = new Padding(3, 4, 3, 4);
            tripTable.MaxFilterButtonImageHeight = 23;
            tripTable.Name = "tripTable";
            tripTable.RightToLeft = RightToLeft.No;
            tripTable.RowHeadersWidth = 51;
            tripTable.Size = new Size(1310, 382);
            tripTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            tripTable.TabIndex = 28;
            tripTable.CellMouseClick += tripTable_CellMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonReset);
            panel1.Controls.Add(comboBoxBuoi);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBoxThu);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBoxTruong);
            panel1.Controls.Add(comboBoxPhuong);
            panel1.Controls.Add(comboBoxXe);
            panel1.Controls.Add(comboBoxBaoMau);
            panel1.Controls.Add(comboBoxTaiXe);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 409);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1310, 300);
            panel1.TabIndex = 29;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.MediumSeaGreen;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(14, 9);
            buttonReset.Margin = new Padding(3, 4, 3, 4);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(125, 45);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            // 
            // comboBoxBuoi
            // 
            comboBoxBuoi.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBuoi.Enabled = false;
            comboBoxBuoi.Font = new Font("Segoe UI", 10.8F);
            comboBoxBuoi.FormattingEnabled = true;
            comboBoxBuoi.Items.AddRange(new object[] { "Sáng", "Chiều" });
            comboBoxBuoi.Location = new Point(659, 136);
            comboBoxBuoi.Margin = new Padding(3, 4, 3, 4);
            comboBoxBuoi.Name = "comboBoxBuoi";
            comboBoxBuoi.Size = new Size(164, 33);
            comboBoxBuoi.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(611, 140);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 12;
            label7.Text = "Buổi:";
            // 
            // comboBoxThu
            // 
            comboBoxThu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxThu.Enabled = false;
            comboBoxThu.Font = new Font("Segoe UI", 10.8F);
            comboBoxThu.FormattingEnabled = true;
            comboBoxThu.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7" });
            comboBoxThu.Location = new Point(407, 136);
            comboBoxThu.Margin = new Padding(3, 4, 3, 4);
            comboBoxThu.Name = "comboBoxThu";
            comboBoxThu.Size = new Size(164, 33);
            comboBoxThu.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(366, 140);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 10;
            label6.Text = "Thứ:";
            // 
            // comboBoxTruong
            // 
            comboBoxTruong.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTruong.Enabled = false;
            comboBoxTruong.Font = new Font("Segoe UI", 10.8F);
            comboBoxTruong.FormattingEnabled = true;
            comboBoxTruong.Location = new Point(1074, 79);
            comboBoxTruong.Margin = new Padding(3, 4, 3, 4);
            comboBoxTruong.Name = "comboBoxTruong";
            comboBoxTruong.Size = new Size(236, 33);
            comboBoxTruong.TabIndex = 9;
            // 
            // comboBoxPhuong
            // 
            comboBoxPhuong.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPhuong.Enabled = false;
            comboBoxPhuong.Font = new Font("Segoe UI", 10.8F);
            comboBoxPhuong.FormattingEnabled = true;
            comboBoxPhuong.Location = new Point(718, 79);
            comboBoxPhuong.Margin = new Padding(3, 4, 3, 4);
            comboBoxPhuong.Name = "comboBoxPhuong";
            comboBoxPhuong.Size = new Size(237, 33);
            comboBoxPhuong.TabIndex = 8;
            // 
            // comboBoxXe
            // 
            comboBoxXe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxXe.Enabled = false;
            comboBoxXe.Font = new Font("Segoe UI", 10.8F);
            comboBoxXe.FormattingEnabled = true;
            comboBoxXe.Location = new Point(407, 79);
            comboBoxXe.Margin = new Padding(3, 4, 3, 4);
            comboBoxXe.Name = "comboBoxXe";
            comboBoxXe.Size = new Size(164, 33);
            comboBoxXe.TabIndex = 7;
            // 
            // comboBoxBaoMau
            // 
            comboBoxBaoMau.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBaoMau.Enabled = false;
            comboBoxBaoMau.Font = new Font("Segoe UI", 10.8F);
            comboBoxBaoMau.FormattingEnabled = true;
            comboBoxBaoMau.Location = new Point(76, 136);
            comboBoxBaoMau.Margin = new Padding(3, 4, 3, 4);
            comboBoxBaoMau.Name = "comboBoxBaoMau";
            comboBoxBaoMau.Size = new Size(267, 33);
            comboBoxBaoMau.TabIndex = 6;
            // 
            // comboBoxTaiXe
            // 
            comboBoxTaiXe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaiXe.Enabled = false;
            comboBoxTaiXe.Font = new Font("Segoe UI", 10.8F);
            comboBoxTaiXe.FormattingEnabled = true;
            comboBoxTaiXe.Location = new Point(76, 79);
            comboBoxTaiXe.Margin = new Padding(3, 4, 3, 4);
            comboBoxTaiXe.Name = "comboBoxTaiXe";
            comboBoxTaiXe.Size = new Size(267, 33);
            comboBoxTaiXe.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(961, 83);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 4;
            label5.Text = "Trường đến:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(607, 83);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 3;
            label4.Text = "Phường đón:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(366, 83);
            label3.Name = "label3";
            label3.Size = new Size(36, 25);
            label3.TabIndex = 2;
            label3.Text = "Xe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(4, 140);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Bảo mẫu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(4, 83);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài xế:";
            // 
            // Chuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1310, 572);
            Controls.Add(panel1);
            Controls.Add(tripTable);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Chuyen";
            Text = "Chuyen";
            ((System.ComponentModel.ISupportInitialize)tripTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView tripTable;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox comboBoxTruong;
        private ComboBox comboBoxPhuong;
        private ComboBox comboBoxXe;
        private ComboBox comboBoxBaoMau;
        private ComboBox comboBoxTaiXe;
        private Label label5;
        private Button buttonReset;
        private ComboBox comboBoxBuoi;
        private Label label7;
        private ComboBox comboBoxThu;
        private Label label6;
    }
}