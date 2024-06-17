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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            panelInformation.Location = new Point(0, 408);
            panelInformation.Margin = new Padding(3, 4, 3, 4);
            panelInformation.Name = "panelInformation";
            panelInformation.Size = new Size(1145, 230);
            panelInformation.TabIndex = 28;
            // 
            // textBoxIDHopDong
            // 
            textBoxIDHopDong.Location = new Point(106, 53);
            textBoxIDHopDong.Margin = new Padding(3, 4, 3, 4);
            textBoxIDHopDong.Name = "textBoxIDHopDong";
            textBoxIDHopDong.ReadOnly = true;
            textBoxIDHopDong.Size = new Size(114, 27);
            textBoxIDHopDong.TabIndex = 28;
            // 
            // buttonThongKe
            // 
            buttonThongKe.BackColor = Color.MediumSeaGreen;
            buttonThongKe.FlatStyle = FlatStyle.Flat;
            buttonThongKe.ForeColor = Color.White;
            buttonThongKe.Location = new Point(919, 103);
            buttonThongKe.Margin = new Padding(3, 4, 3, 4);
            buttonThongKe.Name = "buttonThongKe";
            buttonThongKe.Size = new Size(133, 58);
            buttonThongKe.TabIndex = 27;
            buttonThongKe.Text = "Thống kê";
            buttonThongKe.UseVisualStyleBackColor = false;
            buttonThongKe.Click += buttonThongKe_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.MediumSeaGreen;
            buttonXoa.FlatStyle = FlatStyle.Flat;
            buttonXoa.ForeColor = Color.White;
            buttonXoa.Location = new Point(696, 103);
            buttonXoa.Margin = new Padding(3, 4, 3, 4);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(133, 58);
            buttonXoa.TabIndex = 26;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Visible = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = Color.MediumSeaGreen;
            buttonSua.FlatStyle = FlatStyle.Flat;
            buttonSua.ForeColor = Color.White;
            buttonSua.Location = new Point(491, 103);
            buttonSua.Margin = new Padding(3, 4, 3, 4);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(134, 58);
            buttonSua.TabIndex = 25;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // comboBoxPhuongThuc
            // 
            comboBoxPhuongThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPhuongThuc.FormattingEnabled = true;
            comboBoxPhuongThuc.Items.AddRange(new object[] { "Ngân hàng", "Ví điện tử" });
            comboBoxPhuongThuc.Location = new Point(993, 53);
            comboBoxPhuongThuc.Margin = new Padding(3, 4, 3, 4);
            comboBoxPhuongThuc.Name = "comboBoxPhuongThuc";
            comboBoxPhuongThuc.Size = new Size(138, 28);
            comboBoxPhuongThuc.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(826, 57);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 23;
            label3.Text = "Phương thức thanh toán:";
            // 
            // textBoxSoTien
            // 
            textBoxSoTien.Location = new Point(619, 53);
            textBoxSoTien.Margin = new Padding(3, 4, 3, 4);
            textBoxSoTien.Name = "textBoxSoTien";
            textBoxSoTien.Size = new Size(139, 27);
            textBoxSoTien.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(560, 57);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 21;
            label2.Text = "Số tiền:";
            // 
            // dateTimePickerNgayThanhToan
            // 
            dateTimePickerNgayThanhToan.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayThanhToan.Location = new Point(378, 53);
            dateTimePickerNgayThanhToan.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerNgayThanhToan.Name = "dateTimePickerNgayThanhToan";
            dateTimePickerNgayThanhToan.Size = new Size(115, 27);
            dateTimePickerNgayThanhToan.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 57);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 6;
            label4.Text = "Ngày thanh toán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 57);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 3;
            label1.Text = "ID hợp đồng:";
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.MediumSeaGreen;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(81, 103);
            buttonReset.Margin = new Padding(3, 4, 3, 4);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(133, 58);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.MediumSeaGreen;
            buttonThem.FlatStyle = FlatStyle.Flat;
            buttonThem.ForeColor = Color.White;
            buttonThem.Location = new Point(286, 103);
            buttonThem.Margin = new Padding(3, 4, 3, 4);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(138, 58);
            buttonThem.TabIndex = 1;
            buttonThem.Text = "Xác nhận";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // labelInformation
            // 
            labelInformation.AutoSize = true;
            labelInformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInformation.Location = new Point(9, 9);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(214, 28);
            labelInformation.TabIndex = 0;
            labelInformation.Text = "Thông tin thanh toán";
            // 
            // paymentTable
            // 
            paymentTable.AllowUserToAddRows = false;
            paymentTable.AllowUserToDeleteRows = false;
            paymentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paymentTable.BackgroundColor = Color.White;
            paymentTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            paymentTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            paymentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            paymentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentTable.Dock = DockStyle.Top;
            paymentTable.FilterAndSortEnabled = true;
            paymentTable.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            paymentTable.Location = new Point(0, 0);
            paymentTable.Margin = new Padding(3, 4, 3, 4);
            paymentTable.MaxFilterButtonImageHeight = 23;
            paymentTable.Name = "paymentTable";
            paymentTable.RightToLeft = RightToLeft.No;
            paymentTable.RowHeadersWidth = 51;
            paymentTable.Size = new Size(1139, 356);
            paymentTable.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            paymentTable.TabIndex = 27;
            paymentTable.CellMouseClick += paymentTable_CellMouseClick;
            // 
            // PaymentMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 700);
            Controls.Add(panelInformation);
            Controls.Add(paymentTable);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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