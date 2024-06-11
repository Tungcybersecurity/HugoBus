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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            textBoxTaiXe = new TextBox();
            textBoxBaoMau = new TextBox();
            textBoxXe = new TextBox();
            textBoxThu = new TextBox();
            textBoxPhuong = new TextBox();
            textBoxBuoi = new TextBox();
            textBoxTruong = new TextBox();
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
            tripTable.MaxFilterButtonImageHeight = 23;
            tripTable.Name = "tripTable";
            tripTable.RightToLeft = RightToLeft.No;
            tripTable.RowHeadersWidth = 51;
            tripTable.Size = new Size(1146, 286);
            tripTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            tripTable.TabIndex = 28;
            tripTable.CellMouseClick += tripTable_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài xế:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(3, 68);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Bảo mẫu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(319, 25);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 2;
            label3.Text = "Xe:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(530, 25);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "Phường đón:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(840, 25);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Trường đến:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(319, 68);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 10;
            label6.Text = "Thứ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(534, 68);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 12;
            label7.Text = "Buổi:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBoxTruong);
            panel1.Controls.Add(textBoxBuoi);
            panel1.Controls.Add(textBoxPhuong);
            panel1.Controls.Add(textBoxThu);
            panel1.Controls.Add(textBoxXe);
            panel1.Controls.Add(textBoxBaoMau);
            panel1.Controls.Add(textBoxTaiXe);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 307);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 225);
            panel1.TabIndex = 29;
            // 
            // textBoxTaiXe
            // 
            textBoxTaiXe.Enabled = false;
            textBoxTaiXe.Location = new Point(82, 25);
            textBoxTaiXe.Name = "textBoxTaiXe";
            textBoxTaiXe.ReadOnly = true;
            textBoxTaiXe.Size = new Size(187, 23);
            textBoxTaiXe.TabIndex = 13;
            // 
            // textBoxBaoMau
            // 
            textBoxBaoMau.Enabled = false;
            textBoxBaoMau.Location = new Point(82, 68);
            textBoxBaoMau.Name = "textBoxBaoMau";
            textBoxBaoMau.ReadOnly = true;
            textBoxBaoMau.Size = new Size(187, 23);
            textBoxBaoMau.TabIndex = 14;
            // 
            // textBoxXe
            // 
            textBoxXe.Enabled = false;
            textBoxXe.Location = new Point(354, 25);
            textBoxXe.Name = "textBoxXe";
            textBoxXe.ReadOnly = true;
            textBoxXe.Size = new Size(120, 23);
            textBoxXe.TabIndex = 15;
            // 
            // textBoxThu
            // 
            textBoxThu.Enabled = false;
            textBoxThu.Location = new Point(362, 68);
            textBoxThu.Name = "textBoxThu";
            textBoxThu.ReadOnly = true;
            textBoxThu.Size = new Size(112, 23);
            textBoxThu.TabIndex = 16;
            // 
            // textBoxPhuong
            // 
            textBoxPhuong.Enabled = false;
            textBoxPhuong.Location = new Point(629, 25);
            textBoxPhuong.Name = "textBoxPhuong";
            textBoxPhuong.ReadOnly = true;
            textBoxPhuong.Size = new Size(172, 23);
            textBoxPhuong.TabIndex = 17;
            // 
            // textBoxBuoi
            // 
            textBoxBuoi.Enabled = false;
            textBoxBuoi.Location = new Point(582, 68);
            textBoxBuoi.Name = "textBoxBuoi";
            textBoxBuoi.ReadOnly = true;
            textBoxBuoi.Size = new Size(153, 23);
            textBoxBuoi.TabIndex = 18;
            // 
            // textBoxTruong
            // 
            textBoxTruong.Enabled = false;
            textBoxTruong.Location = new Point(934, 25);
            textBoxTruong.Name = "textBoxTruong";
            textBoxTruong.ReadOnly = true;
            textBoxTruong.Size = new Size(209, 23);
            textBoxTruong.TabIndex = 19;
            // 
            // Chuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private TextBox textBoxTruong;
        private TextBox textBoxBuoi;
        private TextBox textBoxPhuong;
        private TextBox textBoxThu;
        private TextBox textBoxXe;
        private TextBox textBoxBaoMau;
        private TextBox textBoxTaiXe;
    }
}