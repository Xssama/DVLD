namespace DVDL_app
{
    partial class frmManageDetainedLicenses
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
            btnReleaseLicense = new PictureBox();
            label2 = new Label();
            tbxFilter = new TextBox();
            cbFilters = new ComboBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            lblRecords = new Label();
            label1 = new Label();
            dgvDetainedLicenses = new ReaLTaiizor.Controls.PoisonDataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            releaseLicenseToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btnDetainLicense = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)btnReleaseLicense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDetainLicense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnReleaseLicense
            // 
            btnReleaseLicense.BackColor = Color.Transparent;
            btnReleaseLicense.BackgroundImageLayout = ImageLayout.None;
            btnReleaseLicense.BorderStyle = BorderStyle.FixedSingle;
            btnReleaseLicense.Cursor = Cursors.Hand;
            btnReleaseLicense.Image = Properties.Resources.ReleaseLicense1;
            btnReleaseLicense.Location = new Point(1373, 230);
            btnReleaseLicense.Name = "btnReleaseLicense";
            btnReleaseLicense.Size = new Size(56, 53);
            btnReleaseLicense.SizeMode = PictureBoxSizeMode.Zoom;
            btnReleaseLicense.TabIndex = 30;
            btnReleaseLicense.TabStop = false;
            btnReleaseLicense.Click += btnReleaseLicense_Click;
            btnReleaseLicense.MouseDown += btnReleaseLicense_MouseDown;
            btnReleaseLicense.MouseUp += btnReleaseLicense_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 239);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 29;
            label2.Text = "Filter By : ";
            // 
            // tbxFilter
            // 
            tbxFilter.Location = new Point(395, 239);
            tbxFilter.Name = "tbxFilter";
            tbxFilter.Size = new Size(228, 31);
            tbxFilter.TabIndex = 28;
            tbxFilter.TextChanged += tbxFilter_TextChanged;
            // 
            // cbFilters
            // 
            cbFilters.FormattingEnabled = true;
            cbFilters.Items.AddRange(new object[] { "None", "DetainID", "License", "FullName", "NationalNo" });
            cbFilters.Location = new Point(147, 239);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(226, 33);
            cbFilters.TabIndex = 27;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            bigLabel1.Location = new Point(629, 161);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(391, 50);
            bigLabel1.TabIndex = 26;
            bigLabel1.Text = "List Detained Licenses";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(142, 715);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(59, 29);
            lblRecords.TabIndex = 25;
            lblRecords.Text = "[???]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 715);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 24;
            label1.Text = "# Records : ";
            // 
            // dgvDetainedLicenses
            // 
            dgvDetainedLicenses.AllowUserToAddRows = false;
            dgvDetainedLicenses.AllowUserToDeleteRows = false;
            dgvDetainedLicenses.AllowUserToResizeRows = false;
            dgvDetainedLicenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetainedLicenses.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvDetainedLicenses.BorderStyle = BorderStyle.None;
            dgvDetainedLicenses.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDetainedLicenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetainedLicenses.ColumnHeadersHeight = 35;
            dgvDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetainedLicenses.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDetainedLicenses.EnableHeadersVisualStyles = false;
            dgvDetainedLicenses.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvDetainedLicenses.GridColor = Color.FromArgb(255, 255, 255);
            dgvDetainedLicenses.Location = new Point(5, 289);
            dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            dgvDetainedLicenses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetainedLicenses.RowHeadersVisible = false;
            dgvDetainedLicenses.RowHeadersWidth = 51;
            dgvDetainedLicenses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDetainedLicenses.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetainedLicenses.RowTemplate.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
            dgvDetainedLicenses.RowTemplate.Height = 50;
            dgvDetainedLicenses.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvDetainedLicenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetainedLicenses.ShowRowErrors = false;
            dgvDetainedLicenses.Size = new Size(1528, 385);
            dgvDetainedLicenses.TabIndex = 23;
            dgvDetainedLicenses.CellMouseDown += dgvDetainedLicenses_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, releaseLicenseToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(361, 156);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.persondetailsicon;
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(360, 38);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.LicenseInfos32px;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(360, 38);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.License_History;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(360, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // releaseLicenseToolStripMenuItem
            // 
            releaseLicenseToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            releaseLicenseToolStripMenuItem.Image = Properties.Resources.ReleaseLicense32px;
            releaseLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            releaseLicenseToolStripMenuItem.Size = new Size(360, 38);
            releaseLicenseToolStripMenuItem.Text = "Release License";
            releaseLicenseToolStripMenuItem.Click += releaseLicenseToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ManageList;
            pictureBox1.Location = new Point(690, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnDetainLicense
            // 
            btnDetainLicense.BackColor = Color.Transparent;
            btnDetainLicense.BackgroundImageLayout = ImageLayout.None;
            btnDetainLicense.BorderStyle = BorderStyle.FixedSingle;
            btnDetainLicense.Cursor = Cursors.Hand;
            btnDetainLicense.Image = Properties.Resources.DetainLicense64px;
            btnDetainLicense.Location = new Point(1450, 230);
            btnDetainLicense.Name = "btnDetainLicense";
            btnDetainLicense.Size = new Size(56, 53);
            btnDetainLicense.SizeMode = PictureBoxSizeMode.Zoom;
            btnDetainLicense.TabIndex = 31;
            btnDetainLicense.TabStop = false;
            btnDetainLicense.Click += btnDetainLicense_Click;
            btnDetainLicense.MouseDown += btnDetainLicense_MouseDown;
            btnDetainLicense.MouseUp += btnDetainLicense_MouseUp;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmManageDetainedLicenses
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1562, 764);
            Controls.Add(btnDetainLicense);
            Controls.Add(btnReleaseLicense);
            Controls.Add(label2);
            Controls.Add(tbxFilter);
            Controls.Add(cbFilters);
            Controls.Add(bigLabel1);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(dgvDetainedLicenses);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageDetainedLicenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detained Licenses";
            Load += frmManageDetainedLicenses_Load;
            ((System.ComponentModel.ISupportInitialize)btnReleaseLicense).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDetainLicense).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnReleaseLicense;
        private Label label2;
        private TextBox tbxFilter;
        private ComboBox cbFilters;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label lblRecords;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvDetainedLicenses;
        private PictureBox pictureBox1;
        private PictureBox btnDetainLicense;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem releaseLicenseToolStripMenuItem;
        private ErrorProvider errorProvider1;
    }
}