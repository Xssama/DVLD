namespace DVDL_app
{
    partial class frmEditTestType
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
            pictureBox1 = new PictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            label1 = new Label();
            tbxID = new ReaLTaiizor.Controls.AloneTextBox();
            tbxTitle = new ReaLTaiizor.Controls.AloneTextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            tbxFees = new ReaLTaiizor.Controls.AloneTextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            pictureBox4 = new PictureBox();
            tbxDescription = new ReaLTaiizor.Controls.AloneTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.editapptype128;
            pictureBox1.Location = new Point(391, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(363, 184);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(308, 50);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Update Test Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 287);
            label1.Name = "label1";
            label1.Size = new Size(56, 31);
            label1.TabIndex = 2;
            label1.Text = "ID : ";
            // 
            // tbxID
            // 
            tbxID.BackColor = Color.Transparent;
            tbxID.EnabledCalc = true;
            tbxID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxID.ForeColor = Color.FromArgb(64, 64, 64);
            tbxID.Location = new Point(313, 273);
            tbxID.MaxLength = 32767;
            tbxID.MultiLine = false;
            tbxID.Name = "tbxID";
            tbxID.ReadOnly = true;
            tbxID.Size = new Size(576, 54);
            tbxID.TabIndex = 3;
            tbxID.TextAlign = HorizontalAlignment.Left;
            tbxID.UseSystemPasswordChar = false;
            // 
            // tbxTitle
            // 
            tbxTitle.BackColor = Color.Transparent;
            tbxTitle.EnabledCalc = true;
            tbxTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxTitle.ForeColor = Color.FromArgb(64, 64, 64);
            tbxTitle.Location = new Point(313, 496);
            tbxTitle.MaxLength = 32767;
            tbxTitle.MultiLine = false;
            tbxTitle.Name = "tbxTitle";
            tbxTitle.ReadOnly = false;
            tbxTitle.Size = new Size(576, 54);
            tbxTitle.TabIndex = 5;
            tbxTitle.TextAlign = HorizontalAlignment.Left;
            tbxTitle.UseSystemPasswordChar = false;
            tbxTitle.Validating += tbxTitle_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 510);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 4;
            label2.Text = "Title : ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.title;
            pictureBox2.Location = new Point(230, 510);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.fees1;
            pictureBox3.Location = new Point(230, 582);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // tbxFees
            // 
            tbxFees.BackColor = Color.Transparent;
            tbxFees.EnabledCalc = true;
            tbxFees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxFees.ForeColor = Color.FromArgb(64, 64, 64);
            tbxFees.Location = new Point(313, 568);
            tbxFees.MaxLength = 32767;
            tbxFees.MultiLine = false;
            tbxFees.Name = "tbxFees";
            tbxFees.ReadOnly = false;
            tbxFees.Size = new Size(576, 54);
            tbxFees.TabIndex = 8;
            tbxFees.TextAlign = HorizontalAlignment.Left;
            tbxFees.UseSystemPasswordChar = false;
            tbxFees.Validating += tbxFees_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 582);
            label3.Name = "label3";
            label3.Size = new Size(78, 31);
            label3.TabIndex = 7;
            label3.Text = "Fees : ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.BorderColor = Color.FromArgb(220, 223, 230);
            btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(483, 672);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSave.Size = new Size(150, 50);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.description;
            pictureBox4.Location = new Point(230, 362);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // tbxDescription
            // 
            tbxDescription.BackColor = Color.Transparent;
            tbxDescription.EnabledCalc = true;
            tbxDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxDescription.ForeColor = Color.FromArgb(64, 64, 64);
            tbxDescription.Location = new Point(313, 348);
            tbxDescription.MaxLength = 32767;
            tbxDescription.MultiLine = false;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.ReadOnly = false;
            tbxDescription.Size = new Size(576, 128);
            tbxDescription.TabIndex = 12;
            tbxDescription.TextAlign = HorizontalAlignment.Left;
            tbxDescription.UseSystemPasswordChar = false;
            tbxDescription.Validating += aloneTextBox1_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 362);
            label4.Name = "label4";
            label4.Size = new Size(152, 31);
            label4.TabIndex = 11;
            label4.Text = "Description : ";
            // 
            // frmEditTestType
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 753);
            Controls.Add(pictureBox4);
            Controls.Add(tbxDescription);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(pictureBox3);
            Controls.Add(tbxFees);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(tbxTitle);
            Controls.Add(label2);
            Controls.Add(tbxID);
            Controls.Add(label1);
            Controls.Add(bigLabel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmEditTestType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditAppType";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label label1;
        private ReaLTaiizor.Controls.AloneTextBox tbxID;
        private ReaLTaiizor.Controls.AloneTextBox tbxTitle;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.AloneTextBox tbxFees;
        private Label label3;
        private ErrorProvider errorProvider1;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.AloneTextBox tbxDescription;
        private Label label4;
    }

}