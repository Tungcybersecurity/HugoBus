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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoadTong = new System.Windows.Forms.Button();
            this.panelTong = new System.Windows.Forms.Panel();
            this.radioButtonTongNam = new System.Windows.Forms.RadioButton();
            this.radioButtonTongThang = new System.Windows.Forms.RadioButton();
            this.radioButtonTongQuy = new System.Windows.Forms.RadioButton();
            this.dataGridViewTong = new System.Windows.Forms.DataGridView();
            this.chartTong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadTT = new System.Windows.Forms.Button();
            this.panelTT = new System.Windows.Forms.Panel();
            this.radioButtonTTNam = new System.Windows.Forms.RadioButton();
            this.radioButtonTTThang = new System.Windows.Forms.RadioButton();
            this.radioButtonTTQuy = new System.Windows.Forms.RadioButton();
            this.dataGridViewTT = new System.Windows.Forms.DataGridView();
            this.chartTT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3.SuspendLayout();
            this.panelTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonLoadTong);
            this.panel3.Controls.Add(this.panelTong);
            this.panel3.Controls.Add(this.dataGridViewTong);
            this.panel3.Controls.Add(this.chartTong);
            this.panel3.Location = new System.Drawing.Point(118, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 478);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "TỔNG DOANH THU";
            // 
            // buttonLoadTong
            // 
            this.buttonLoadTong.Location = new System.Drawing.Point(311, 208);
            this.buttonLoadTong.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadTong.Name = "buttonLoadTong";
            this.buttonLoadTong.Size = new System.Drawing.Size(76, 29);
            this.buttonLoadTong.TabIndex = 6;
            this.buttonLoadTong.Text = "Load";
            this.buttonLoadTong.UseVisualStyleBackColor = true;
            this.buttonLoadTong.Click += new System.EventHandler(this.buttonLoadTong_Click);
            // 
            // panelTong
            // 
            this.panelTong.Controls.Add(this.radioButtonTongNam);
            this.panelTong.Controls.Add(this.radioButtonTongThang);
            this.panelTong.Controls.Add(this.radioButtonTongQuy);
            this.panelTong.Location = new System.Drawing.Point(16, 176);
            this.panelTong.Margin = new System.Windows.Forms.Padding(2);
            this.panelTong.Name = "panelTong";
            this.panelTong.Size = new System.Drawing.Size(371, 28);
            this.panelTong.TabIndex = 5;
            // 
            // radioButtonTongNam
            // 
            this.radioButtonTongNam.AutoSize = true;
            this.radioButtonTongNam.Location = new System.Drawing.Point(266, 4);
            this.radioButtonTongNam.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTongNam.Name = "radioButtonTongNam";
            this.radioButtonTongNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonTongNam.TabIndex = 4;
            this.radioButtonTongNam.TabStop = true;
            this.radioButtonTongNam.Text = "Năm";
            this.radioButtonTongNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonTongThang
            // 
            this.radioButtonTongThang.AutoSize = true;
            this.radioButtonTongThang.Location = new System.Drawing.Point(12, 3);
            this.radioButtonTongThang.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTongThang.Name = "radioButtonTongThang";
            this.radioButtonTongThang.Size = new System.Drawing.Size(56, 17);
            this.radioButtonTongThang.TabIndex = 2;
            this.radioButtonTongThang.TabStop = true;
            this.radioButtonTongThang.Text = "Tháng";
            this.radioButtonTongThang.UseVisualStyleBackColor = true;
            // 
            // radioButtonTongQuy
            // 
            this.radioButtonTongQuy.AutoSize = true;
            this.radioButtonTongQuy.Location = new System.Drawing.Point(140, 4);
            this.radioButtonTongQuy.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTongQuy.Name = "radioButtonTongQuy";
            this.radioButtonTongQuy.Size = new System.Drawing.Size(44, 17);
            this.radioButtonTongQuy.TabIndex = 3;
            this.radioButtonTongQuy.TabStop = true;
            this.radioButtonTongQuy.Text = "Quý";
            this.radioButtonTongQuy.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTong
            // 
            this.dataGridViewTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTong.Location = new System.Drawing.Point(16, 49);
            this.dataGridViewTong.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTong.Name = "dataGridViewTong";
            this.dataGridViewTong.RowHeadersWidth = 51;
            this.dataGridViewTong.RowTemplate.Height = 24;
            this.dataGridViewTong.Size = new System.Drawing.Size(371, 122);
            this.dataGridViewTong.TabIndex = 1;
            // 
            // chartTong
            // 
            chartArea5.Name = "ChartArea1";
            this.chartTong.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartTong.Legends.Add(legend5);
            this.chartTong.Location = new System.Drawing.Point(40, 241);
            this.chartTong.Name = "chartTong";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "VND";
            this.chartTong.Series.Add(series5);
            this.chartTong.Size = new System.Drawing.Size(328, 222);
            this.chartTong.TabIndex = 0;
            this.chartTong.Text = "chart";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonLoadTT);
            this.panel1.Controls.Add(this.panelTT);
            this.panel1.Controls.Add(this.dataGridViewTT);
            this.panel1.Controls.Add(this.chartTT);
            this.panel1.Location = new System.Drawing.Point(536, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 478);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "TĂNG TRƯỞNG DOANH THU";
            // 
            // buttonLoadTT
            // 
            this.buttonLoadTT.Location = new System.Drawing.Point(310, 208);
            this.buttonLoadTT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadTT.Name = "buttonLoadTT";
            this.buttonLoadTT.Size = new System.Drawing.Size(69, 29);
            this.buttonLoadTT.TabIndex = 6;
            this.buttonLoadTT.Text = "Load";
            this.buttonLoadTT.UseVisualStyleBackColor = true;
            this.buttonLoadTT.Click += new System.EventHandler(this.buttonLoadTT_Click);
            // 
            // panelTT
            // 
            this.panelTT.Controls.Add(this.radioButtonTTNam);
            this.panelTT.Controls.Add(this.radioButtonTTThang);
            this.panelTT.Controls.Add(this.radioButtonTTQuy);
            this.panelTT.Location = new System.Drawing.Point(16, 176);
            this.panelTT.Margin = new System.Windows.Forms.Padding(2);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(363, 28);
            this.panelTT.TabIndex = 5;
            // 
            // radioButtonTTNam
            // 
            this.radioButtonTTNam.AutoSize = true;
            this.radioButtonTTNam.Location = new System.Drawing.Point(240, 5);
            this.radioButtonTTNam.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTTNam.Name = "radioButtonTTNam";
            this.radioButtonTTNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonTTNam.TabIndex = 4;
            this.radioButtonTTNam.TabStop = true;
            this.radioButtonTTNam.Text = "Năm";
            this.radioButtonTTNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonTTThang
            // 
            this.radioButtonTTThang.AutoSize = true;
            this.radioButtonTTThang.Location = new System.Drawing.Point(12, 4);
            this.radioButtonTTThang.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTTThang.Name = "radioButtonTTThang";
            this.radioButtonTTThang.Size = new System.Drawing.Size(56, 17);
            this.radioButtonTTThang.TabIndex = 2;
            this.radioButtonTTThang.TabStop = true;
            this.radioButtonTTThang.Text = "Tháng";
            this.radioButtonTTThang.UseVisualStyleBackColor = true;
            // 
            // radioButtonTTQuy
            // 
            this.radioButtonTTQuy.AutoSize = true;
            this.radioButtonTTQuy.Location = new System.Drawing.Point(125, 5);
            this.radioButtonTTQuy.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTTQuy.Name = "radioButtonTTQuy";
            this.radioButtonTTQuy.Size = new System.Drawing.Size(44, 17);
            this.radioButtonTTQuy.TabIndex = 3;
            this.radioButtonTTQuy.TabStop = true;
            this.radioButtonTTQuy.Text = "Quý";
            this.radioButtonTTQuy.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTT
            // 
            this.dataGridViewTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTT.Location = new System.Drawing.Point(16, 49);
            this.dataGridViewTT.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTT.Name = "dataGridViewTT";
            this.dataGridViewTT.RowHeadersWidth = 51;
            this.dataGridViewTT.RowTemplate.Height = 24;
            this.dataGridViewTT.Size = new System.Drawing.Size(363, 122);
            this.dataGridViewTT.TabIndex = 1;
            // 
            // chartTT
            // 
            chartArea6.Name = "ChartArea1";
            this.chartTT.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartTT.Legends.Add(legend6);
            this.chartTT.Location = new System.Drawing.Point(28, 242);
            this.chartTT.Name = "chartTT";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "%";
            this.chartTT.Series.Add(series6);
            this.chartTT.Size = new System.Drawing.Size(328, 222);
            this.chartTT.TabIndex = 0;
            this.chartTT.Text = "chart1";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 491);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ DOANH THU";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTong.ResumeLayout(false);
            this.panelTong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTT.ResumeLayout(false);
            this.panelTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTT)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTong;
        private Panel panel1;
        private Label label1;
        private Button buttonLoadTT;
        private Panel panelTT;
        private RadioButton radioButtonTTNam;
        private RadioButton radioButtonTTThang;
        private RadioButton radioButtonTTQuy;
        private DataGridView dataGridViewTT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTT;
    }
}