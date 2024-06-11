namespace GUI.Payment
{
    partial class PaymentMain
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
            textBoxIDHopDong = new TextBox();
            buttonThongKe = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            comboBoxPhuongThuc = new ComboBox();
            label3 = new Label();
            textBoxSoTien = new TextBox();
            label2 = new Label();
            dateTimePickerNgayThanhToan = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            buttonReset = new Button();
            buttonThem = new Button();
            labelInformation = new Label();
            paymentTable = new Zuby.ADGV.AdvancedDataGridView();
            panelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paymentTable).BeginInit();
            SuspendLayout();
            // 
            // panelInformation
            // 
            panelInformation.Controls.Add(textBoxIDHopDong);
            panelInformation.Controls.Add(buttonThongKe);
            panelInformation.Controls.Add(buttonXoa);
            panelInformation.Controls.Add(buttonSua);
            panelInformation.Controls.Add(comboBoxPhuongThuc);
            panelInformation.Controls.Add(label3);
            panelInformation.Controls.Add(textBoxSoTien);
            panelInformation.Controls.Add(label2);
            panelInformation.Controls.Add(dateTimePickerNgayThanhToan);
            panelInformation.Controls.Add(label4);
            panelInformation.Controls.Add(label1);
            panelInformation.Controls.Add(buttonReset);
            panelInformation.Controls.Add(buttonThem);
            panelInformation.Controls.Add(labelInformation);
            panelInformation.Location = new Point(-5, 291);
            panelInformation.Name = "panelInformation";
            panelInformation.Size = new Size(1002, 124);
            panelInformation.TabIndex = 28;
            // 
            // textBoxIDHopDong
            // 
            textBoxIDHopDong.Location = new Point(93, 40);
            textBoxIDHopDong.Name = "textBoxIDHopDong";
            textBoxIDHopDong.ReadOnly = true;
            textBoxIDHopDong.Size = new Size(100, 23);
            textBoxIDHopDong.TabIndex = 28;
            // 
            // buttonThongKe
            // 
            buttonThongKe.Location = new Point(804, 83);
            buttonThongKe.Name = "buttonThongKe";
            buttonThongKe.Size = new Size(75, 23);
            buttonThongKe.TabIndex = 27;
            buttonThongKe.Text = "Thống kê";
            buttonThongKe.UseVisualStyleBackColor = true;
            buttonThongKe.Click += buttonThongKe_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(609, 83);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 23);
            buttonXoa.TabIndex = 26;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(430, 83);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(76, 23);
            buttonSua.TabIndex = 25;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // comboBoxPhuongThuc
            // 
            comboBoxPhuongThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPhuongThuc.FormattingEnabled = true;
            comboBoxPhuongThuc.Items.AddRange(new object[] { "Ngân hàng", "Ví điện tử" });
            comboBoxPhuongThuc.Location = new Point(869, 40);
            comboBoxPhuongThuc.Name = "comboBoxPhuongThuc";
            comboBoxPhuongThuc.Size = new Size(121, 23);
            comboBoxPhuongThuc.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(723, 43);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 23;
            label3.Text = "Phương thức thanh toán:";
            // 
            // textBoxSoTien
            // 
            textBoxSoTien.Location = new Point(542, 40);
            textBoxSoTien.Name = "textBoxSoTien";
            textBoxSoTien.Size = new Size(122, 23);
            textBoxSoTien.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(490, 43);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 21;
            label2.Text = "Số tiền:";
            // 
            // dateTimePickerNgayThanhToan
            // 
            dateTimePickerNgayThanhToan.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayThanhToan.Location = new Point(331, 40);
            dateTimePickerNgayThanhToan.Name = "dateTimePickerNgayThanhToan";
            dateTimePickerNgayThanhToan.Size = new Size(101, 23);
            dateTimePickerNgayThanhToan.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 43);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "Ngày thanh toán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 43);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "ID hợp đồng:";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(71, 83);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(250, 83);
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
            labelInformation.Size = new Size(172, 21);
            labelInformation.TabIndex = 0;
            labelInformation.Text = "Thông tin thanh toán";
            // 
            // paymentTable
            // 
            paymentTable.AllowUserToAddRows = false;
            paymentTable.AllowUserToDeleteRows = false;
            paymentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            paymentTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            paymentTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            paymentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentTable.Dock = DockStyle.Top;
            paymentTable.FilterAndSortEnabled = true;
            paymentTable.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            paymentTable.Location = new Point(0, 0);
            paymentTable.MaxFilterButtonImageHeight = 23;
            paymentTable.Name = "paymentTable";
            paymentTable.RightToLeft = RightToLeft.No;
            paymentTable.RowHeadersWidth = 51;
            paymentTable.Size = new Size(997, 267);
            paymentTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            paymentTable.TabIndex = 27;
            paymentTable.CellMouseClick += paymentTable_CellMouseClick;
            // 
            // PaymentMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 425);
            Controls.Add(panelInformation);
            Controls.Add(paymentTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentMain";
            Text = "PaymentMain";
            panelInformation.ResumeLayout(false);
            panelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paymentTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInformation;
        private Label label4;
        private Label label1;
        private Button buttonReset;
        private Button buttonThem;
        private Label labelInformation;
        private Zuby.ADGV.AdvancedDataGridView paymentTable;
        private TextBox textBoxSoTien;
        private Label label2;
        private DateTimePicker dateTimePickerNgayThanhToan;
        private ComboBox comboBoxPhuongThuc;
        private Label label3;
        private Button buttonThongKe;
        private Button buttonXoa;
        private Button buttonSua;
        private TextBox textBoxIDHopDong;
    }
}