namespace GUI.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            buttonlogin = new Button();
            label2 = new Label();
            textusername = new TextBox();
            textPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bus;
            pictureBox1.Location = new Point(156, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(156, 209);
            label1.Name = "label1";
            label1.Size = new Size(195, 71);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.person;
            pictureBox2.Location = new Point(50, 325);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Location = new Point(50, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 1);
            panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(50, 445);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LimeGreen;
            panel2.Location = new Point(50, 501);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 1);
            panel2.TabIndex = 3;
            // 
            // buttonlogin
            // 
            buttonlogin.BackColor = Color.ForestGreen;
            buttonlogin.FlatAppearance.BorderSize = 0;
            buttonlogin.Font = new Font("UTM Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonlogin.ForeColor = Color.White;
            buttonlogin.Location = new Point(50, 574);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(390, 55);
            buttonlogin.TabIndex = 4;
            buttonlogin.Text = "LOGIN";
            buttonlogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UTM Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(210, 667);
            label2.Name = "label2";
            label2.Size = new Size(77, 41);
            label2.TabIndex = 5;
            label2.Text = "Exit";
            // 
            // textusername
            // 
            textusername.BorderStyle = BorderStyle.None;
            textusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textusername.Location = new Point(106, 329);
            textusername.Multiline = true;
            textusername.Name = "textusername";
            textusername.Size = new Size(334, 46);
            textusername.TabIndex = 6;
            // 
            // textPassword
            // 
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(106, 449);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(334, 46);
            textPassword.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(471, 717);
            Controls.Add(textPassword);
            Controls.Add(textusername);
            Controls.Add(label2);
            Controls.Add(buttonlogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button buttonlogin;
        private Label label2;
        private TextBox textusername;
        private TextBox textPassword;
    }
}