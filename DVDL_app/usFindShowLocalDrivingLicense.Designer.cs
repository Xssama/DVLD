namespace DVDL_app
{
    partial class usFindShowLocalDrivingLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gpLicenseInfos = new GroupBox();
            gpFilter = new GroupBox();
            btnSearch = new Button();
            tbxLicenseID = new ReaLTaiizor.Controls.AloneTextBox();
            pictureBox9 = new PictureBox();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gpLicenseInfos
            // 
            gpLicenseInfos.Font = new Font("Sitka Banner", 13.7999992F);
            gpLicenseInfos.Location = new Point(3, 99);
            gpLicenseInfos.Name = "gpLicenseInfos";
            gpLicenseInfos.Size = new Size(1087, 434);
            gpLicenseInfos.TabIndex = 0;
            gpLicenseInfos.TabStop = false;
            gpLicenseInfos.Text = "License Infos";
            // 
            // gpFilter
            // 
            gpFilter.Controls.Add(btnSearch);
            gpFilter.Controls.Add(tbxLicenseID);
            gpFilter.Controls.Add(pictureBox9);
            gpFilter.Controls.Add(label4);
            gpFilter.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpFilter.Location = new Point(10, 3);
            gpFilter.Name = "gpFilter";
            gpFilter.Size = new Size(656, 90);
            gpFilter.TabIndex = 1;
            gpFilter.TabStop = false;
            gpFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 0);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.SearchID32;
            btnSearch.Location = new Point(545, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(46, 39);
            btnSearch.TabIndex = 1;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxLicenseID
            // 
            tbxLicenseID.BackColor = Color.Transparent;
            tbxLicenseID.EnabledCalc = true;
            tbxLicenseID.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxLicenseID.ForeColor = Color.FromArgb(64, 0, 0);
            tbxLicenseID.Location = new Point(233, 29);
            tbxLicenseID.MaxLength = 32767;
            tbxLicenseID.MultiLine = false;
            tbxLicenseID.Name = "tbxLicenseID";
            tbxLicenseID.ReadOnly = false;
            tbxLicenseID.Size = new Size(277, 45);
            tbxLicenseID.TabIndex = 0;
            tbxLicenseID.TextAlign = HorizontalAlignment.Left;
            tbxLicenseID.UseSystemPasswordChar = false;
            tbxLicenseID.Validating += tbxLicenseID_Validating;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.drivingID;
            pictureBox9.Location = new Point(175, 39);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(40, 28);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 61;
            pictureBox9.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 38);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 60;
            label4.Text = "License ID   :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // usFindShowLocalDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(gpFilter);
            Controls.Add(gpLicenseInfos);
            Name = "usFindShowLocalDrivingLicense";
            Size = new Size(1103, 557);
            Load += usFindShowLocalDrivingLicense_Load;
            gpFilter.ResumeLayout(false);
            gpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpLicenseInfos;
        private GroupBox gpFilter;
        private PictureBox pictureBox9;
        private Label label4;
        private ErrorProvider errorProvider1;
        private ReaLTaiizor.Controls.AloneTextBox tbxLicenseID;
        private Button btnSearch;
    }
}
