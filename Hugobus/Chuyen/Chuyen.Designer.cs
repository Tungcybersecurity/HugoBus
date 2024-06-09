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
            tripTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tripTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            tripTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tripTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tripTable.Dock = DockStyle.Top;
            tripTable.FilterAndSortEnabled = true;
            tripTable.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            tripTable.Location = new Point(0, 0);
            tripTable.MaxFilterButtonImageHeight = 23;
            tripTable.Name = "tripTable";
            tripTable.RightToLeft = RightToLeft.No;
            tripTable.RowHeadersWidth = 51;
            tripTable.Size = new Size(1146, 267);
            tripTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            tripTable.TabIndex = 28;
            // 
            // panel1
            // 
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
            panel1.Location = new Point(0, 286);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 131);
            panel1.TabIndex = 29;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(12, 7);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // comboBoxBuoi
            // 
            comboBoxBuoi.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBuoi.Enabled = false;
            comboBoxBuoi.FormattingEnabled = true;
            comboBoxBuoi.Items.AddRange(new object[] { "Sáng", "Chiều" });
            comboBoxBuoi.Location = new Point(583, 82);
            comboBoxBuoi.Name = "comboBoxBuoi";
            comboBoxBuoi.Size = new Size(110, 23);
            comboBoxBuoi.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(543, 85);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 12;
            label7.Text = "Buổi:";
            // 
            // comboBoxThu
            // 
            comboBoxThu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxThu.Enabled = false;
            comboBoxThu.FormattingEnabled = true;
            comboBoxThu.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7" });
            comboBoxThu.Location = new Point(365, 82);
            comboBoxThu.Name = "comboBoxThu";
            comboBoxThu.Size = new Size(110, 23);
            comboBoxThu.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 85);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 10;
            label6.Text = "Thứ:";
            // 
            // comboBoxTruong
            // 
            comboBoxTruong.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTruong.Enabled = false;
            comboBoxTruong.FormattingEnabled = true;
            comboBoxTruong.Location = new Point(938, 39);
            comboBoxTruong.Name = "comboBoxTruong";
            comboBoxTruong.Size = new Size(200, 23);
            comboBoxTruong.TabIndex = 9;
            // 
            // comboBoxPhuong
            // 
            comboBoxPhuong.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPhuong.Enabled = false;
            comboBoxPhuong.FormattingEnabled = true;
            comboBoxPhuong.Location = new Point(622, 39);
            comboBoxPhuong.Name = "comboBoxPhuong";
            comboBoxPhuong.Size = new Size(174, 23);
            comboBoxPhuong.TabIndex = 8;
            // 
            // comboBoxXe
            // 
            comboBoxXe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxXe.Enabled = false;
            comboBoxXe.FormattingEnabled = true;
            comboBoxXe.Location = new Point(365, 39);
            comboBoxXe.Name = "comboBoxXe";
            comboBoxXe.Size = new Size(110, 23);
            comboBoxXe.TabIndex = 7;
            // 
            // comboBoxBaoMau
            // 
            comboBoxBaoMau.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBaoMau.Enabled = false;
            comboBoxBaoMau.FormattingEnabled = true;
            comboBoxBaoMau.Location = new Point(75, 82);
            comboBoxBaoMau.Name = "comboBoxBaoMau";
            comboBoxBaoMau.Size = new Size(200, 23);
            comboBoxBaoMau.TabIndex = 6;
            // 
            // comboBoxTaiXe
            // 
            comboBoxTaiXe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaiXe.Enabled = false;
            comboBoxTaiXe.FormattingEnabled = true;
            comboBoxTaiXe.Location = new Point(75, 39);
            comboBoxTaiXe.Name = "comboBoxTaiXe";
            comboBoxTaiXe.Size = new Size(200, 23);
            comboBoxTaiXe.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(862, 42);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Trường đến:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(540, 42);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Phường đón:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 42);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 2;
            label3.Text = "Xe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Bảo mẫu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Tài xế:";
            // 
            // Chuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 429);
            Controls.Add(panel1);
            Controls.Add(tripTable);
            FormBorderStyle = FormBorderStyle.None;
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