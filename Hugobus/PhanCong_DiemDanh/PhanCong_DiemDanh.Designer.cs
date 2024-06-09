namespace GUI.PhanCong_DiemDanh
{
    partial class PhanCong_DiemDanh
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
            panelInformation = new Panel();
            textBoxIDChuyen = new TextBox();
            buttonLocChuyen = new Button();
            label2 = new Label();
            buttonXoa = new Button();
            buttonThem = new Button();
            labelInformation = new Label();
            buttonReset = new Button();
            phancongTable = new Zuby.ADGV.AdvancedDataGridView();
            panel1 = new Panel();
            dataGridViewDiemDanh = new DataGridView();
            buttonXoaDD = new Button();
            comboBoxDiemDanh = new ComboBox();
            dateTimePickerNgayDiemDanh = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            buttonDiemDanh = new Button();
            label9 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            chuaphancongTable = new Zuby.ADGV.AdvancedDataGridView();
            panelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phancongTable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiemDanh).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chuaphancongTable).BeginInit();
            SuspendLayout();
            // 
            // panelInformation
            // 
            panelInformation.BorderStyle = BorderStyle.Fixed3D;
            panelInformation.Controls.Add(textBoxIDChuyen);
            panelInformation.Controls.Add(buttonLocChuyen);
            panelInformation.Controls.Add(label2);
            panelInformation.Controls.Add(buttonXoa);
            panelInformation.Controls.Add(buttonThem);
            panelInformation.Controls.Add(labelInformation);
            panelInformation.Location = new Point(43, 323);
            panelInformation.Name = "panelInformation";
            panelInformation.Size = new Size(550, 151);
            panelInformation.TabIndex = 30;
            // 
            // textBoxIDChuyen
            // 
            textBoxIDChuyen.Location = new Point(197, 34);
            textBoxIDChuyen.Name = "textBoxIDChuyen";
            textBoxIDChuyen.ReadOnly = true;
            textBoxIDChuyen.Size = new Size(100, 23);
            textBoxIDChuyen.TabIndex = 30;
            // 
            // buttonLocChuyen
            // 
            buttonLocChuyen.Location = new Point(303, 33);
            buttonLocChuyen.Name = "buttonLocChuyen";
            buttonLocChuyen.Size = new Size(98, 23);
            buttonLocChuyen.TabIndex = 29;
            buttonLocChuyen.Text = "Tìm chuyến";
            buttonLocChuyen.UseVisualStyleBackColor = true;
            buttonLocChuyen.Click += buttonLocChuyen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 39);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 27;
            label2.Text = "ID chuyến:";
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(384, 89);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 23);
            buttonXoa.TabIndex = 26;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(78, 89);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(80, 23);
            buttonThem.TabIndex = 1;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // labelInformation
            // 
            labelInformation.AutoSize = true;
            labelInformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInformation.Location = new Point(8, 7);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(91, 21);
            labelInformation.TabIndex = 0;
            labelInformation.Text = "Phân công";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(8, 292);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // phancongTable
            // 
            phancongTable.AllowUserToAddRows = false;
            phancongTable.AllowUserToDeleteRows = false;
            phancongTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            phancongTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            phancongTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            phancongTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phancongTable.FilterAndSortEnabled = true;
            phancongTable.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            phancongTable.Location = new Point(20, 34);
            phancongTable.MaxFilterButtonImageHeight = 23;
            phancongTable.Name = "phancongTable";
            phancongTable.RightToLeft = RightToLeft.No;
            phancongTable.RowHeadersWidth = 51;
            phancongTable.Size = new Size(709, 243);
            phancongTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            phancongTable.TabIndex = 29;
            phancongTable.CellMouseClick += phancongTable_CellMouseClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dataGridViewDiemDanh);
            panel1.Controls.Add(buttonXoaDD);
            panel1.Controls.Add(comboBoxDiemDanh);
            panel1.Controls.Add(dateTimePickerNgayDiemDanh);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buttonDiemDanh);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(20, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 189);
            panel1.TabIndex = 31;
            // 
            // dataGridViewDiemDanh
            // 
            dataGridViewDiemDanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDiemDanh.Location = new Point(23, 31);
            dataGridViewDiemDanh.Name = "dataGridViewDiemDanh";
            dataGridViewDiemDanh.Size = new Size(625, 87);
            dataGridViewDiemDanh.TabIndex = 27;
            dataGridViewDiemDanh.CellMouseClick += dataGridViewDiemDanh_CellMouseClick;
            // 
            // buttonXoaDD
            // 
            buttonXoaDD.Location = new Point(167, 159);
            buttonXoaDD.Name = "buttonXoaDD";
            buttonXoaDD.Size = new Size(75, 23);
            buttonXoaDD.TabIndex = 26;
            buttonXoaDD.Text = "Xóa";
            buttonXoaDD.UseVisualStyleBackColor = true;
            buttonXoaDD.Click += buttonXoaDD_Click;
            // 
            // comboBoxDiemDanh
            // 
            comboBoxDiemDanh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiemDanh.FormattingEnabled = true;
            comboBoxDiemDanh.Items.AddRange(new object[] { "Đã đón", "Đã trả", "Vắng" });
            comboBoxDiemDanh.Location = new Point(144, 124);
            comboBoxDiemDanh.Name = "comboBoxDiemDanh";
            comboBoxDiemDanh.Size = new Size(174, 23);
            comboBoxDiemDanh.TabIndex = 20;
            comboBoxDiemDanh.SelectedIndexChanged += comboBoxDiemDanh_SelectedIndexChanged;
            // 
            // dateTimePickerNgayDiemDanh
            // 
            dateTimePickerNgayDiemDanh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayDiemDanh.Location = new Point(444, 124);
            dateTimePickerNgayDiemDanh.Name = "dateTimePickerNgayDiemDanh";
            dateTimePickerNgayDiemDanh.Size = new Size(204, 23);
            dateTimePickerNgayDiemDanh.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 128);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 6;
            label7.Text = "Ngày đưa đón:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 128);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 3;
            label8.Text = "Tình trạng điểm danh:";
            // 
            // buttonDiemDanh
            // 
            buttonDiemDanh.Location = new Point(23, 159);
            buttonDiemDanh.Name = "buttonDiemDanh";
            buttonDiemDanh.Size = new Size(80, 23);
            buttonDiemDanh.TabIndex = 1;
            buttonDiemDanh.Text = "Điểm danh";
            buttonDiemDanh.UseVisualStyleBackColor = true;
            buttonDiemDanh.Click += buttonDiemDanh_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 7);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 0;
            label9.Text = "Điểm danh";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(phancongTable);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 490);
            panel2.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 6);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 34;
            label3.Text = "ĐÃ PHÂN CÔNG";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(chuaphancongTable);
            panel3.Controls.Add(buttonReset);
            panel3.Controls.Add(panelInformation);
            panel3.Location = new Point(744, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 490);
            panel3.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 6);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 33;
            label1.Text = "CHƯA PHÂN CÔNG";
            // 
            // chuaphancongTable
            // 
            chuaphancongTable.AllowUserToAddRows = false;
            chuaphancongTable.AllowUserToDeleteRows = false;
            chuaphancongTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            chuaphancongTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            chuaphancongTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            chuaphancongTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chuaphancongTable.FilterAndSortEnabled = true;
            chuaphancongTable.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            chuaphancongTable.Location = new Point(8, 34);
            chuaphancongTable.MaxFilterButtonImageHeight = 23;
            chuaphancongTable.Name = "chuaphancongTable";
            chuaphancongTable.RightToLeft = RightToLeft.No;
            chuaphancongTable.RowHeadersWidth = 51;
            chuaphancongTable.Size = new Size(611, 243);
            chuaphancongTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            chuaphancongTable.TabIndex = 32;
            chuaphancongTable.CellMouseClick += chuaphancongTable_CellMouseClick;
            // 
            // PhanCong_DiemDanh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 504);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhanCong_DiemDanh";
            Text = "PhanCong_DiemDanh";
            panelInformation.ResumeLayout(false);
            panelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phancongTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiemDanh).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chuaphancongTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInformation;
        private Button buttonXoa;
        private Button buttonReset;
        private Button buttonThem;
        private Label labelInformation;
        private Zuby.ADGV.AdvancedDataGridView phancongTable;
        private Label label2;
        private Panel panel1;
        private Button buttonXoaDD;
        private ComboBox comboBoxDiemDanh;
        private DateTimePicker dateTimePickerNgayDiemDanh;
        private Label label7;
        private Label label8;
        private Button buttonDiemDanh;
        private Label label9;
        private DataGridView dataGridViewDiemDanh;
        private Panel panel2;
        private Panel panel3;
        private Zuby.ADGV.AdvancedDataGridView chuaphancongTable;
        private Button buttonLocChuyen;
        private TextBox textBoxIDChuyen;
        private Label label3;
        private Label label1;
    }
}