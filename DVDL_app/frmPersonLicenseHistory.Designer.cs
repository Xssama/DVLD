namespace DVDL_app
{
    partial class frmPersonLicenseHistory
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            plFindPerson = new Panel();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tpLocal = new TabPage();
            lblRecords = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvLocalLicensesHistory = new ReaLTaiizor.Controls.PoisonDataGridView();
            cmsLocalDrivingLicenses = new ContextMenuStrip(components);
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            tpInternational = new TabPage();
            lblIntRecords = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvInternationalLicensesHistory = new ReaLTaiizor.Controls.PoisonDataGridView();
            cmsInterLicenses = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            plBody = new Panel();
            pictureBox1 = new PictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicensesHistory).BeginInit();
            cmsLocalDrivingLicenses.SuspendLayout();
            tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicensesHistory).BeginInit();
            cmsInterLicenses.SuspendLayout();
            plBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // plFindPerson
            // 
            plFindPerson.BorderStyle = BorderStyle.FixedSingle;
            plFindPerson.Location = new Point(333, 128);
            plFindPerson.Name = "plFindPerson";
            plFindPerson.Size = new Size(1054, 422);
            plFindPerson.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 703);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1413, 388);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpLocal);
            tabControl1.Controls.Add(tpInternational);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Times New Roman", 13.8F);
            tabControl1.Location = new Point(3, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1407, 357);
            tabControl1.TabIndex = 0;
            // 
            // tpLocal
            // 
            tpLocal.Controls.Add(lblRecords);
            tpLocal.Controls.Add(label2);
            tpLocal.Controls.Add(label1);
            tpLocal.Controls.Add(dgvLocalLicensesHistory);
            tpLocal.Location = new Point(4, 35);
            tpLocal.Name = "tpLocal";
            tpLocal.Padding = new Padding(3);
            tpLocal.Size = new Size(1399, 318);
            tpLocal.TabIndex = 0;
            tpLocal.Text = "Local";
            tpLocal.UseVisualStyleBackColor = true;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new Point(151, 281);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(58, 26);
            lblRecords.TabIndex = 3;
            lblRecords.Text = "[???]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 281);
            label2.Name = "label2";
            label2.Size = new Size(118, 26);
            label2.TabIndex = 2;
            label2.Text = "#Records : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 23);
            label1.Name = "label1";
            label1.Size = new Size(234, 26);
            label1.TabIndex = 1;
            label1.Text = "Local Licenses History :";
            // 
            // dgvLocalLicensesHistory
            // 
            dgvLocalLicensesHistory.AllowUserToAddRows = false;
            dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            dgvLocalLicensesHistory.AllowUserToResizeRows = false;
            dgvLocalLicensesHistory.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvLocalLicensesHistory.BorderStyle = BorderStyle.None;
            dgvLocalLicensesHistory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLocalLicensesHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLocalLicensesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLocalLicensesHistory.ColumnHeadersHeight = 29;
            dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLocalLicensesHistory.ContextMenuStrip = cmsLocalDrivingLicenses;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLocalLicensesHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLocalLicensesHistory.EnableHeadersVisualStyles = false;
            dgvLocalLicensesHistory.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvLocalLicensesHistory.GridColor = Color.FromArgb(255, 255, 255);
            dgvLocalLicensesHistory.Location = new Point(31, 59);
            dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            dgvLocalLicensesHistory.ReadOnly = true;
            dgvLocalLicensesHistory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLocalLicensesHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLocalLicensesHistory.RowHeadersVisible = false;
            dgvLocalLicensesHistory.RowHeadersWidth = 51;
            dgvLocalLicensesHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLocalLicensesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocalLicensesHistory.ShowCellToolTips = false;
            dgvLocalLicensesHistory.ShowRowErrors = false;
            dgvLocalLicensesHistory.Size = new Size(1349, 219);
            dgvLocalLicensesHistory.TabIndex = 0;
            dgvLocalLicensesHistory.CellMouseDown += dgvLocalLicensesHistory_CellMouseDown;
            // 
            // cmsLocalDrivingLicenses
            // 
            cmsLocalDrivingLicenses.ImageScalingSize = new Size(20, 20);
            cmsLocalDrivingLicenses.Items.AddRange(new ToolStripItem[] { showLicenseDetailsToolStripMenuItem });
            cmsLocalDrivingLicenses.Name = "cmsLocalDrivingLicenses";
            cmsLocalDrivingLicenses.Size = new Size(292, 70);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.LicenseInfos32px;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(291, 38);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // tpInternational
            // 
            tpInternational.Controls.Add(lblIntRecords);
            tpInternational.Controls.Add(label4);
            tpInternational.Controls.Add(label5);
            tpInternational.Controls.Add(dgvInternationalLicensesHistory);
            tpInternational.Location = new Point(4, 35);
            tpInternational.Name = "tpInternational";
            tpInternational.Padding = new Padding(3);
            tpInternational.Size = new Size(1399, 318);
            tpInternational.TabIndex = 1;
            tpInternational.Text = "International";
            tpInternational.UseVisualStyleBackColor = true;
            // 
            // lblIntRecords
            // 
            lblIntRecords.AutoSize = true;
            lblIntRecords.Location = new Point(151, 275);
            lblIntRecords.Name = "lblIntRecords";
            lblIntRecords.Size = new Size(58, 26);
            lblIntRecords.TabIndex = 7;
            lblIntRecords.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 275);
            label4.Name = "label4";
            label4.Size = new Size(118, 26);
            label4.TabIndex = 6;
            label4.Text = "#Records : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 22);
            label5.Name = "label5";
            label5.Size = new Size(301, 26);
            label5.TabIndex = 5;
            label5.Text = "International Licenses History :";
            // 
            // dgvInternationalLicensesHistory
            // 
            dgvInternationalLicensesHistory.AllowUserToAddRows = false;
            dgvInternationalLicensesHistory.AllowUserToDeleteRows = false;
            dgvInternationalLicensesHistory.AllowUserToResizeRows = false;
            dgvInternationalLicensesHistory.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvInternationalLicensesHistory.BorderStyle = BorderStyle.None;
            dgvInternationalLicensesHistory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInternationalLicensesHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInternationalLicensesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInternationalLicensesHistory.ColumnHeadersHeight = 29;
            dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInternationalLicensesHistory.ContextMenuStrip = cmsInterLicenses;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvInternationalLicensesHistory.DefaultCellStyle = dataGridViewCellStyle5;
            dgvInternationalLicensesHistory.EnableHeadersVisualStyles = false;
            dgvInternationalLicensesHistory.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvInternationalLicensesHistory.GridColor = Color.FromArgb(255, 255, 255);
            dgvInternationalLicensesHistory.Location = new Point(31, 60);
            dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
            dgvInternationalLicensesHistory.ReadOnly = true;
            dgvInternationalLicensesHistory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvInternationalLicensesHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvInternationalLicensesHistory.RowHeadersVisible = false;
            dgvInternationalLicensesHistory.RowHeadersWidth = 51;
            dgvInternationalLicensesHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInternationalLicensesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInternationalLicensesHistory.ShowCellToolTips = false;
            dgvInternationalLicensesHistory.ShowRowErrors = false;
            dgvInternationalLicensesHistory.Size = new Size(1336, 212);
            dgvInternationalLicensesHistory.TabIndex = 4;
            dgvInternationalLicensesHistory.CellMouseDown += dgvInternationalLicensesHistory_CellMouseDown;
            // 
            // cmsInterLicenses
            // 
            cmsInterLicenses.ImageScalingSize = new Size(20, 20);
            cmsInterLicenses.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            cmsInterLicenses.Name = "cmsLocalDrivingLicenses";
            cmsInterLicenses.Size = new Size(292, 42);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Palatino Linotype", 12F);
            toolStripMenuItem1.Image = Properties.Resources.LicenseInfos32px;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(291, 38);
            toolStripMenuItem1.Text = "Show License Details";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // plBody
            // 
            plBody.Controls.Add(pictureBox1);
            plBody.Controls.Add(bigLabel1);
            plBody.Controls.Add(plFindPerson);
            plBody.Dock = DockStyle.Fill;
            plBody.Location = new Point(0, 0);
            plBody.Name = "plBody";
            plBody.Size = new Size(1413, 703);
            plBody.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PersonLicenseHistory;
            pictureBox1.Location = new Point(25, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Sylfaen", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            bigLabel1.Location = new Point(464, 24);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(444, 55);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Person Licenses History";
            // 
            // frmPersonLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1413, 1091);
            Controls.Add(plBody);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(1431, 1138);
            Name = "frmPersonLicenseHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Licenses History";
            Load += frmPersonLicenseHistory_Load;
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tpLocal.ResumeLayout(false);
            tpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicensesHistory).EndInit();
            cmsLocalDrivingLicenses.ResumeLayout(false);
            tpInternational.ResumeLayout(false);
            tpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicensesHistory).EndInit();
            cmsInterLicenses.ResumeLayout(false);
            plBody.ResumeLayout(false);
            plBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plFindPerson;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tpLocal;
        private TabPage tpInternational;
        private Panel plBody;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvLocalLicensesHistory;
        private Label lblRecords;
        private Label label2;
        private Label lblIntRecords;
        private Label label4;
        private Label label5;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvInternationalLicensesHistory;
        private ContextMenuStrip cmsLocalDrivingLicenses;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ContextMenuStrip cmsInterLicenses;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}