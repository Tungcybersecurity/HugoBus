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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tripTable = new Zuby.ADGV.AdvancedDataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            textBoxTruong = new TextBox();
            textBoxBuoi = new TextBox();
            textBoxPhuong = new TextBox();
            textBoxThu = new TextBox();
            textBoxXe = new TextBox();
            textBoxBaoMau = new TextBox();
            textBoxTaiXe = new TextBox();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tripTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            tripTable.Size = new Size(1310, 381);
            tripTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            tripTable.TabIndex = 28;
            tripTable.CellMouseClick += tripTable_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài xế:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(3, 91);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Bảo mẫu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(365, 33);
            label3.Name = "label3";
            label3.Size = new Size(36, 25);
            label3.TabIndex = 2;
            label3.Text = "Xe:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(606, 33);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 3;
            label4.Text = "Phường đón:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(960, 33);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 4;
            label5.Text = "Trường đến:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(365, 91);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 10;
            label6.Text = "Thứ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(610, 91);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
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
            panel1.Location = new Point(0, 409);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1310, 300);
            panel1.TabIndex = 29;
            // 
            // textBoxTruong
            // 
            textBoxTruong.Enabled = false;
            textBoxTruong.Location = new Point(1067, 33);
            textBoxTruong.Margin = new Padding(3, 4, 3, 4);
            textBoxTruong.Name = "textBoxTruong";
            textBoxTruong.ReadOnly = true;
            textBoxTruong.Size = new Size(238, 27);
            textBoxTruong.TabIndex = 19;
            // 
            // textBoxBuoi
            // 
            textBoxBuoi.Enabled = false;
            textBoxBuoi.Location = new Point(665, 91);
            textBoxBuoi.Margin = new Padding(3, 4, 3, 4);
            textBoxBuoi.Name = "textBoxBuoi";
            textBoxBuoi.ReadOnly = true;
            textBoxBuoi.Size = new Size(174, 27);
            textBoxBuoi.TabIndex = 18;
            // 
            // textBoxPhuong
            // 
            textBoxPhuong.Enabled = false;
            textBoxPhuong.Location = new Point(719, 33);
            textBoxPhuong.Margin = new Padding(3, 4, 3, 4);
            textBoxPhuong.Name = "textBoxPhuong";
            textBoxPhuong.ReadOnly = true;
            textBoxPhuong.Size = new Size(196, 27);
            textBoxPhuong.TabIndex = 17;
            // 
            // textBoxThu
            // 
            textBoxThu.Enabled = false;
            textBoxThu.Location = new Point(414, 91);
            textBoxThu.Margin = new Padding(3, 4, 3, 4);
            textBoxThu.Name = "textBoxThu";
            textBoxThu.ReadOnly = true;
            textBoxThu.Size = new Size(127, 27);
            textBoxThu.TabIndex = 16;
            // 
            // textBoxXe
            // 
            textBoxXe.Enabled = false;
            textBoxXe.Location = new Point(405, 33);
            textBoxXe.Margin = new Padding(3, 4, 3, 4);
            textBoxXe.Name = "textBoxXe";
            textBoxXe.ReadOnly = true;
            textBoxXe.Size = new Size(137, 27);
            textBoxXe.TabIndex = 15;
            // 
            // textBoxBaoMau
            // 
            textBoxBaoMau.Enabled = false;
            textBoxBaoMau.Location = new Point(94, 91);
            textBoxBaoMau.Margin = new Padding(3, 4, 3, 4);
            textBoxBaoMau.Name = "textBoxBaoMau";
            textBoxBaoMau.ReadOnly = true;
            textBoxBaoMau.Size = new Size(213, 27);
            textBoxBaoMau.TabIndex = 14;
            // 
            // textBoxTaiXe
            // 
            textBoxTaiXe.Enabled = false;
            textBoxTaiXe.Location = new Point(94, 33);
            textBoxTaiXe.Margin = new Padding(3, 4, 3, 4);
            textBoxTaiXe.Name = "textBoxTaiXe";
            textBoxTaiXe.ReadOnly = true;
            textBoxTaiXe.Size = new Size(213, 27);
            textBoxTaiXe.TabIndex = 13;
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