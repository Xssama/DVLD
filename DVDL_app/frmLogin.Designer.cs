namespace DVDL_app
{
    partial class frmLogin
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
            components = new System.ComponentModel.Container();
            BodyPanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            htRememberMe = new ReaLTaiizor.Controls.HopeToggle();
            labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            pictureBox3 = new PictureBox();
            btnLogin = new ReaLTaiizor.Controls.Button();
            labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            panel2 = new Panel();
            tbxPassword = new TextBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            tbxUserName = new TextBox();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            errorProvider = new ErrorProvider(components);
            BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // BodyPanel
            // 
            BodyPanel.BackgroundImageLayout = ImageLayout.None;
            BodyPanel.BottomLeft = Color.Black;
            BodyPanel.BottomRight = Color.Fuchsia;
            BodyPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            BodyPanel.Controls.Add(htRememberMe);
            BodyPanel.Controls.Add(labelEdit3);
            BodyPanel.Controls.Add(pictureBox3);
            BodyPanel.Controls.Add(btnLogin);
            BodyPanel.Controls.Add(labelEdit2);
            BodyPanel.Controls.Add(labelEdit1);
            BodyPanel.Controls.Add(panel2);
            BodyPanel.Controls.Add(panel1);
            BodyPanel.Controls.Add(btnClose);
            BodyPanel.Dock = DockStyle.Fill;
            BodyPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            BodyPanel.Location = new Point(0, 0);
            BodyPanel.Name = "BodyPanel";
            BodyPanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            BodyPanel.PrimerColor = Color.White;
            BodyPanel.Size = new Size(531, 845);
            BodyPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            BodyPanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            BodyPanel.TabIndex = 0;
            BodyPanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BodyPanel.TopLeft = Color.DeepSkyBlue;
            BodyPanel.TopRight = Color.Fuchsia;
            // 
            // htRememberMe
            // 
            htRememberMe.AutoSize = true;
            htRememberMe.BaseColor = Color.FromArgb(44, 55, 66);
            htRememberMe.BaseColorA = Color.FromArgb(220, 223, 230);
            htRememberMe.BaseColorB = Color.FromArgb(100, 64, 158, 255);
            htRememberMe.HeadColorA = Color.FromArgb(220, 223, 230);
            htRememberMe.HeadColorB = Color.White;
            htRememberMe.HeadColorC = Color.FromArgb(64, 158, 255);
            htRememberMe.HeadColorD = Color.FromArgb(64, 158, 255);
            htRememberMe.Location = new Point(149, 597);
            htRememberMe.Name = "htRememberMe";
            htRememberMe.Size = new Size(48, 20);
            htRememberMe.TabIndex = 2;
            htRememberMe.Text = "hopeToggle1";
            htRememberMe.UseVisualStyleBackColor = true;
            // 
            // labelEdit3
            // 
            labelEdit3.AutoSize = true;
            labelEdit3.BackColor = Color.Transparent;
            labelEdit3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit3.ForeColor = Color.DarkBlue;
            labelEdit3.Location = new Point(228, 597);
            labelEdit3.Name = "labelEdit3";
            labelEdit3.Size = new Size(140, 25);
            labelEdit3.TabIndex = 11;
            labelEdit3.Text = "Remember Me";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.loginscreenicon;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(197, 144);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(171, 138);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderColor = Color.FromArgb(32, 34, 37);
            btnLogin.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnLogin.EnteredColor = Color.FromArgb(165, 37, 37);
            btnLogin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Image = Properties.Resources.loginbuttonicon32px;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.InactiveColor = Color.FromArgb(28, 58, 90);
            btnLogin.Location = new Point(197, 715);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnLogin.PressedColor = Color.FromArgb(165, 37, 37);
            btnLogin.Size = new Size(153, 54);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelEdit2
            // 
            labelEdit2.AutoSize = true;
            labelEdit2.BackColor = Color.Transparent;
            labelEdit2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit2.ForeColor = Color.DarkBlue;
            labelEdit2.Location = new Point(40, 507);
            labelEdit2.Name = "labelEdit2";
            labelEdit2.Size = new Size(144, 29);
            labelEdit2.TabIndex = 5;
            labelEdit2.Text = "Password   :";
            // 
            // labelEdit1
            // 
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit1.ForeColor = Color.DarkBlue;
            labelEdit1.Location = new Point(37, 411);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(147, 29);
            labelEdit1.TabIndex = 4;
            labelEdit1.Text = "User Name :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tbxPassword);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(199, 498);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 47);
            panel2.TabIndex = 3;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.White;
            tbxPassword.BorderStyle = BorderStyle.None;
            tbxPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(3, 6);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(220, 31);
            tbxPassword.TabIndex = 1;
            tbxPassword.Tag = "Password";
            tbxPassword.TextChanged += ValiditingTextBoxInput;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = Properties.Resources.passwordicon;
            pictureBox2.Location = new Point(225, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tbxUserName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(197, 402);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 47);
            panel1.TabIndex = 2;
            // 
            // tbxUserName
            // 
            tbxUserName.BackColor = Color.White;
            tbxUserName.BorderStyle = BorderStyle.None;
            tbxUserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUserName.Location = new Point(3, 6);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(220, 31);
            tbxUserName.TabIndex = 0;
            tbxUserName.Tag = "User Name";
            tbxUserName.TextChanged += ValiditingTextBoxInput;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.office_man_15735374__1_;
            pictureBox1.Location = new Point(225, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.cross;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(467, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(64, 51);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(531, 845);
            Controls.Add(BodyPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            BodyPanel.ResumeLayout(false);
            BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private ReaLTaiizor.Controls.ParrotGradientPanel BodyPanel;
        private Button btnClose;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox tbxUserName;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private Panel panel2;
        private TextBox tbxPassword;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.Button btnLogin;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.HopeToggle htRememberMe;
        private ErrorProvider errorProvider;
    }
}