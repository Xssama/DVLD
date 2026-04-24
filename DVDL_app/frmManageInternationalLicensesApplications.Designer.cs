namespace DVDL_app
{
    partial class frmManageInternationalLicensesApplications
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
            label2 = new Label();
            tbxFilter = new TextBox();
            cbFilters = new ComboBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            lblRecords = new Label();
            label1 = new Label();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonInfosToolStripMenuItem = new ToolStripMenuItem();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pbIssueNewInterLiense = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIssueNewInterLiense).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 234);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 20;
            label2.Text = "Filter By : ";
            // 
            // tbxFilter
            // 
            tbxFilter.Location = new Point(402, 234);
            tbxFilter.Name = "tbxFilter";
            tbxFilter.Size = new Size(228, 31);
            tbxFilter.TabIndex = 19;
            // 
            // cbFilters
            // 
            cbFilters.FormattingEnabled = true;
            cbFilters.Items.AddRange(new object[] { "None" });
            cbFilters.Location = new Point(154, 234);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(226, 33);
            cbFilters.TabIndex = 18;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            bigLabel1.Location = new Point(439, 156);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(724, 50);
            bigLabel1.TabIndex = 17;
            bigLabel1.Text = "International Driving License Applications";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(149, 710);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(59, 29);
            lblRecords.TabIndex = 16;
            lblRecords.Text = "[???]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 710);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 15;
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
            poisonDataGridView1.Location = new Point(12, 284);
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
            poisonDataGridView1.Size = new Size(1423, 423);
            poisonDataGridView1.TabIndex = 14;
            poisonDataGridView1.CellMouseDown += poisonDataGridView1_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonInfosToolStripMenuItem, showLicenseToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(361, 118);
            // 
            // showPersonInfosToolStripMenuItem
            // 
            showPersonInfosToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            showPersonInfosToolStripMenuItem.Image = Properties.Resources.persondetailsicon;
            showPersonInfosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonInfosToolStripMenuItem.Name = "showPersonInfosToolStripMenuItem";
            showPersonInfosToolStripMenuItem.Size = new Size(360, 38);
            showPersonInfosToolStripMenuItem.Text = "Show Person Details";
            showPersonInfosToolStripMenuItem.Click += showPersonInfosToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            showLicenseToolStripMenuItem.Image = Properties.Resources.LicenseInfos32px;
            showLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(360, 38);
            showLicenseToolStripMenuItem.Text = "Show License Details";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ManageInterLicensesApp3;
            pictureBox1.Location = new Point(658, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pbIssueNewInterLiense
            // 
            pbIssueNewInterLiense.BackColor = Color.Transparent;
            pbIssueNewInterLiense.BackgroundImageLayout = ImageLayout.None;
            pbIssueNewInterLiense.BorderStyle = BorderStyle.FixedSingle;
            pbIssueNewInterLiense.Cursor = Cursors.Hand;
            pbIssueNewInterLiense.Image = Properties.Resources.AddNewInterLicenseApplication;
            pbIssueNewInterLiense.Location = new Point(1360, 225);
            pbIssueNewInterLiense.Name = "pbIssueNewInterLiense";
            pbIssueNewInterLiense.Size = new Size(56, 53);
            pbIssueNewInterLiense.SizeMode = PictureBoxSizeMode.Zoom;
            pbIssueNewInterLiense.TabIndex = 21;
            pbIssueNewInterLiense.TabStop = false;
            pbIssueNewInterLiense.Click += pbIssueNewInterLiense_Click;
            pbIssueNewInterLiense.MouseDown += pbIssueNewInterLiense_MouseDown;
            pbIssueNewInterLiense.MouseUp += pbIssueNewInterLiense_MouseUp;
            // 
            // frmManageInternationalLicensesApplications
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 752);
            Controls.Add(pbIssueNewInterLiense);
            Controls.Add(label2);
            Controls.Add(tbxFilter);
            Controls.Add(cbFilters);
            Controls.Add(bigLabel1);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(poisonDataGridView1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmManageInternationalLicensesApplications";
            Text = "International Licenses Applications";
            Load += frmManageInternationalLicensesApplications_Load;
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIssueNewInterLiense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox tbxFilter;
        private ComboBox cbFilters;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label lblRecords;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pbIssueNewInterLiense;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonInfosToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}