namespace DVDL_app
{
    partial class frmManageLocalDrivingLicenseApplications
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblRecords = new Label();
            label1 = new Label();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sechudleToolStripMenuItem = new ToolStripMenuItem();
            visionTestToolStripMenuItem = new ToolStripMenuItem();
            writtenTestToolStripMenuItem = new ToolStripMenuItem();
            practiceTestToolStripMenuItem = new ToolStripMenuItem();
            issueLicenseFirstNameToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pbAddNewUser = new PictureBox();
            label2 = new Label();
            tbxFilter = new TextBox();
            cbFilters = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNewUser).BeginInit();
            SuspendLayout();
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(143, 717);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(59, 29);
            lblRecords.TabIndex = 7;
            lblRecords.Text = "[???]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 717);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 6;
            label1.Text = "# Records : ";
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToAddRows = false;
            poisonDataGridView1.AllowUserToDeleteRows = false;
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            poisonDataGridView1.ColumnHeadersHeight = 29;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            poisonDataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(12, 291);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            poisonDataGridView1.RowHeadersVisible = false;
            poisonDataGridView1.RowHeadersWidth = 51;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            poisonDataGridView1.RowTemplate.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
            poisonDataGridView1.RowTemplate.Height = 50;
            poisonDataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.ShowRowErrors = false;
            poisonDataGridView1.Size = new Size(1499, 423);
            poisonDataGridView1.TabIndex = 5;
            poisonDataGridView1.CellMouseDown += poisonDataGridView1_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { sechudleToolStripMenuItem, issueLicenseFirstNameToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(342, 108);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // sechudleToolStripMenuItem
            // 
            sechudleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visionTestToolStripMenuItem, writtenTestToolStripMenuItem, practiceTestToolStripMenuItem });
            sechudleToolStripMenuItem.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sechudleToolStripMenuItem.Image = Properties.Resources.SechudleTests;
            sechudleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sechudleToolStripMenuItem.Name = "sechudleToolStripMenuItem";
            sechudleToolStripMenuItem.Size = new Size(341, 38);
            sechudleToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // visionTestToolStripMenuItem
            // 
            visionTestToolStripMenuItem.Image = Properties.Resources.vision_18224853;
            visionTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            visionTestToolStripMenuItem.Size = new Size(308, 38);
            visionTestToolStripMenuItem.Text = "Sechdule Vision Test";
            visionTestToolStripMenuItem.Click += visionTestToolStripMenuItem_Click;
            // 
            // writtenTestToolStripMenuItem
            // 
            writtenTestToolStripMenuItem.Image = Properties.Resources.Writtenpng;
            writtenTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            writtenTestToolStripMenuItem.Size = new Size(308, 38);
            writtenTestToolStripMenuItem.Text = "Sechdule Written Test";
            writtenTestToolStripMenuItem.Click += writtenTestToolStripMenuItem_Click;
            // 
            // practiceTestToolStripMenuItem
            // 
            practiceTestToolStripMenuItem.Image = Properties.Resources.street;
            practiceTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            practiceTestToolStripMenuItem.Name = "practiceTestToolStripMenuItem";
            practiceTestToolStripMenuItem.Size = new Size(308, 38);
            practiceTestToolStripMenuItem.Text = "Sechdule Street Test";
            practiceTestToolStripMenuItem.Click += practiceTestToolStripMenuItem_Click;
            // 
            // issueLicenseFirstNameToolStripMenuItem
            // 
            issueLicenseFirstNameToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            issueLicenseFirstNameToolStripMenuItem.Image = Properties.Resources.IssueDrivingLicense1;
            issueLicenseFirstNameToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueLicenseFirstNameToolStripMenuItem.Name = "issueLicenseFirstNameToolStripMenuItem";
            issueLicenseFirstNameToolStripMenuItem.Size = new Size(341, 38);
            issueLicenseFirstNameToolStripMenuItem.Text = "Issue License (First Name)";
            issueLicenseFirstNameToolStripMenuItem.Click += issueLicenseFirstNameToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.device_7492113;
            pictureBox1.Location = new Point(733, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            bigLabel1.Location = new Point(522, 166);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(575, 50);
            bigLabel1.TabIndex = 8;
            bigLabel1.Text = "Local Driving License Applications";
            // 
            // pbAddNewUser
            // 
            pbAddNewUser.BackColor = Color.Transparent;
            pbAddNewUser.BackgroundImageLayout = ImageLayout.None;
            pbAddNewUser.BorderStyle = BorderStyle.FixedSingle;
            pbAddNewUser.Cursor = Cursors.Hand;
            pbAddNewUser.Image = Properties.Resources.add_user_9506027;
            pbAddNewUser.Location = new Point(1425, 221);
            pbAddNewUser.Name = "pbAddNewUser";
            pbAddNewUser.Size = new Size(56, 53);
            pbAddNewUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNewUser.TabIndex = 13;
            pbAddNewUser.TabStop = false;
            pbAddNewUser.Click += pbAddNewUser_Click;
            pbAddNewUser.MouseDown += pbAddNewUser_MouseDown;
            pbAddNewUser.MouseUp += pbAddNewUser_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 241);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 12;
            label2.Text = "Filter By : ";
            // 
            // tbxFilter
            // 
            tbxFilter.Location = new Point(421, 241);
            tbxFilter.Name = "tbxFilter";
            tbxFilter.Size = new Size(228, 31);
            tbxFilter.TabIndex = 11;
            tbxFilter.TextChanged += tbxFilter_TextChanged;
            // 
            // cbFilters
            // 
            cbFilters.FormattingEnabled = true;
            cbFilters.Items.AddRange(new object[] { "None", "L.D.L AppID", "Full Name", "Status" });
            cbFilters.Location = new Point(173, 241);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(226, 33);
            cbFilters.TabIndex = 10;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1553, 775);
            Controls.Add(pbAddNewUser);
            Controls.Add(label2);
            Controls.Add(tbxFilter);
            Controls.Add(cbFilters);
            Controls.Add(bigLabel1);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(poisonDataGridView1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmManageLocalDrivingLicenseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmManageLocalDrivingLicenseApplications";
            Load += frmManageLocalDrivingLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecords;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pbAddNewUser;
        private Label label2;
        private TextBox tbxFilter;
        private ComboBox cbFilters;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sechudleToolStripMenuItem;
        private ToolStripMenuItem visionTestToolStripMenuItem;
        private ToolStripMenuItem writtenTestToolStripMenuItem;
        private ToolStripMenuItem practiceTestToolStripMenuItem;
        private ToolStripMenuItem issueLicenseFirstNameToolStripMenuItem;
    }
}