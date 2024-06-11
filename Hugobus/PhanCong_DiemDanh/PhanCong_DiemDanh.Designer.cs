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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanCong_DiemDanh));
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
            panelInformation = new Panel();
            labelInformation = new Label();
            buttonThem = new Button();
            buttonXoa = new Button();
            label2 = new Label();
            buttonLocChuyen = new Button();
            textBoxIDChuyen = new TextBox();
            buttonReset = new Button();
            label1 = new Label();
            chuaphancongTable = new Zuby.ADGV.AdvancedDataGridView();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)phancongTable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiemDanh).BeginInit();
            panel2.SuspendLayout();
            panelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chuaphancongTable).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // phancongTable
            // 
            phancongTable.AllowUserToAddRows = false;
            phancongTable.AllowUserToDeleteRows = false;
            phancongTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            phancongTable.BackgroundColor = Color.White;
            phancongTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            phancongTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            phancongTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phancongTable.FilterAndSortEnabled = true;
            phancongTable.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            phancongTable.GridColor = Color.Gray;
            resources.ApplyResources(phancongTable, "phancongTable");
            phancongTable.MaxFilterButtonImageHeight = 23;
            phancongTable.Name = "phancongTable";
            phancongTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
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
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // dataGridViewDiemDanh
            // 
            dataGridViewDiemDanh.BackgroundColor = Color.White;
            dataGridViewDiemDanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridViewDiemDanh, "dataGridViewDiemDanh");
            dataGridViewDiemDanh.Name = "dataGridViewDiemDanh";
            dataGridViewDiemDanh.CellMouseClick += dataGridViewDiemDanh_CellMouseClick;
            // 
            // buttonXoaDD
            // 
            buttonXoaDD.BackColor = Color.MediumSeaGreen;
            resources.ApplyResources(buttonXoaDD, "buttonXoaDD");
            buttonXoaDD.ForeColor = Color.White;
            buttonXoaDD.Name = "buttonXoaDD";
            buttonXoaDD.UseVisualStyleBackColor = false;
            buttonXoaDD.Click += buttonXoaDD_Click;
            // 
            // comboBoxDiemDanh
            // 
            comboBoxDiemDanh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiemDanh.FormattingEnabled = true;
            comboBoxDiemDanh.Items.AddRange(new object[] { resources.GetString("comboBoxDiemDanh.Items"), resources.GetString("comboBoxDiemDanh.Items1"), resources.GetString("comboBoxDiemDanh.Items2") });
            resources.ApplyResources(comboBoxDiemDanh, "comboBoxDiemDanh");
            comboBoxDiemDanh.Name = "comboBoxDiemDanh";
            comboBoxDiemDanh.SelectedIndexChanged += comboBoxDiemDanh_SelectedIndexChanged;
            // 
            // dateTimePickerNgayDiemDanh
            // 
            dateTimePickerNgayDiemDanh.Format = DateTimePickerFormat.Custom;
            resources.ApplyResources(dateTimePickerNgayDiemDanh, "dateTimePickerNgayDiemDanh");
            dateTimePickerNgayDiemDanh.Name = "dateTimePickerNgayDiemDanh";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // buttonDiemDanh
            // 
            buttonDiemDanh.BackColor = Color.MediumSeaGreen;
            resources.ApplyResources(buttonDiemDanh, "buttonDiemDanh");
            buttonDiemDanh.ForeColor = Color.White;
            buttonDiemDanh.Name = "buttonDiemDanh";
            buttonDiemDanh.UseVisualStyleBackColor = false;
            buttonDiemDanh.Click += buttonDiemDanh_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(phancongTable);
            panel2.Controls.Add(panel1);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
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
            resources.ApplyResources(panelInformation, "panelInformation");
            panelInformation.Name = "panelInformation";
            // 
            // labelInformation
            // 
            resources.ApplyResources(labelInformation, "labelInformation");
            labelInformation.Name = "labelInformation";
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.MediumSeaGreen;
            resources.ApplyResources(buttonThem, "buttonThem");
            buttonThem.ForeColor = Color.White;
            buttonThem.Name = "buttonThem";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.MediumSeaGreen;
            resources.ApplyResources(buttonXoa, "buttonXoa");
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Name = "buttonXoa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // buttonLocChuyen
            // 
            resources.ApplyResources(buttonLocChuyen, "buttonLocChuyen");
            buttonLocChuyen.Name = "buttonLocChuyen";
            buttonLocChuyen.UseVisualStyleBackColor = true;
            buttonLocChuyen.Click += buttonLocChuyen_Click;
            // 
            // textBoxIDChuyen
            // 
            resources.ApplyResources(textBoxIDChuyen, "textBoxIDChuyen");
            textBoxIDChuyen.Name = "textBoxIDChuyen";
            textBoxIDChuyen.ReadOnly = true;
            // 
            // buttonReset
            // 
            resources.ApplyResources(buttonReset, "buttonReset");
            buttonReset.Name = "buttonReset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // chuaphancongTable
            // 
            chuaphancongTable.AllowUserToAddRows = false;
            chuaphancongTable.AllowUserToDeleteRows = false;
            chuaphancongTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            chuaphancongTable.BackgroundColor = Color.White;
            chuaphancongTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            chuaphancongTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            chuaphancongTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chuaphancongTable.FilterAndSortEnabled = true;
            chuaphancongTable.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            resources.ApplyResources(chuaphancongTable, "chuaphancongTable");
            chuaphancongTable.MaxFilterButtonImageHeight = 23;
            chuaphancongTable.Name = "chuaphancongTable";
            chuaphancongTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            chuaphancongTable.CellMouseClick += chuaphancongTable_CellMouseClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(chuaphancongTable);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(buttonReset);
            panel3.Controls.Add(panelInformation);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // PhanCong_DiemDanh
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhanCong_DiemDanh";
            Load += PhanCong_DiemDanh_Load;
            ((System.ComponentModel.ISupportInitialize)phancongTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiemDanh).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelInformation.ResumeLayout(false);
            panelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chuaphancongTable).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView phancongTable;
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
        private Label label3;
        private Panel panelInformation;
        private TextBox textBoxIDChuyen;
        private Button buttonLocChuyen;
        private Label label2;
        private Button buttonXoa;
        private Button buttonThem;
        private Label labelInformation;
        private Button buttonReset;
        private Label label1;
        private Zuby.ADGV.AdvancedDataGridView chuaphancongTable;
        private Panel panel3;
    }
}