namespace DVDL_app
{
    partial class FrmUsersList
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
            pictureBox1 = new PictureBox();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            label1 = new Label();
            lblRecords = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editUserToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            cbFilters = new ComboBox();
            tbxFilter = new TextBox();
            label2 = new Label();
            pbAddNewUser = new PictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddNewUser).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.team_6036017;
            pictureBox1.Location = new Point(602, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToAddRows = false;
            poisonDataGridView1.AllowUserToDeleteRows = false;
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.BorderStyle = BorderStyle.Fixed3D;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            poisonDataGridView1.ColumnHeadersHeight = 25;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.Padding = new Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(33, 382);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Padding = new Padding(20, 0, 20, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            poisonDataGridView1.RowHeadersVisible = false;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            poisonDataGridView1.RowTemplate.Height = 50;
            poisonDataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(1310, 337);
            poisonDataGridView1.TabIndex = 1;
            poisonDataGridView1.CellMouseDown += poisonDataGridView1_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 747);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 2;
            label1.Text = "# Records : ";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(181, 747);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(62, 28);
            lblRecords.TabIndex = 3;
            lblRecords.Text = "[????]";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, deleteToolStripMenuItem, editUserToolStripMenuItem, addUserToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(226, 244);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showDetailsToolStripMenuItem.Image = Properties.Resources.persondetailsicon;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(225, 38);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(222, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteToolStripMenuItem.Image = Properties.Resources.add_user_Icon;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(225, 38);
            deleteToolStripMenuItem.Text = "Add New User";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // editUserToolStripMenuItem
            // 
            editUserToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editUserToolStripMenuItem.Image = Properties.Resources.EditPerson;
            editUserToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            editUserToolStripMenuItem.Size = new Size(225, 38);
            editUserToolStripMenuItem.Text = "Edit";
            editUserToolStripMenuItem.Click += editUserToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUserToolStripMenuItem.Image = Properties.Resources.DeletePerson;
            addUserToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(225, 38);
            addUserToolStripMenuItem.Text = "Delete";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(222, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendEmailToolStripMenuItem.Image = Properties.Resources.mail_7286139;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(225, 38);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneCallToolStripMenuItem.Image = Properties.Resources.phonecall;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(225, 38);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // cbFilters
            // 
            cbFilters.FormattingEnabled = true;
            cbFilters.Items.AddRange(new object[] { "None", "UserID", "PersonID", "FullName", "UserName" });
            cbFilters.Location = new Point(218, 332);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(226, 33);
            cbFilters.TabIndex = 5;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // tbxFilter
            // 
            tbxFilter.Location = new Point(466, 332);
            tbxFilter.Name = "tbxFilter";
            tbxFilter.Size = new Size(228, 31);
            tbxFilter.TabIndex = 6;
            tbxFilter.TextChanged += tbxFilter_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 332);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 7;
            label2.Text = "Filter By : ";
            // 
            // pbAddNewUser
            // 
            pbAddNewUser.BackColor = Color.Transparent;
            pbAddNewUser.BackgroundImageLayout = ImageLayout.None;
            pbAddNewUser.BorderStyle = BorderStyle.FixedSingle;
            pbAddNewUser.Cursor = Cursors.Hand;
            pbAddNewUser.Image = Properties.Resources.add_user_9506027;
            pbAddNewUser.Location = new Point(1263, 323);
            pbAddNewUser.Name = "pbAddNewUser";
            pbAddNewUser.Size = new Size(56, 53);
            pbAddNewUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNewUser.TabIndex = 9;
            pbAddNewUser.TabStop = false;
            pbAddNewUser.Click += pbAddNewUser_Click;
            pbAddNewUser.MouseDown += pbAddNewUser_MouseDown;
            pbAddNewUser.MouseUp += pbAddNewUser_MouseUp;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            bigLabel1.Location = new Point(582, 238);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(254, 50);
            bigLabel1.TabIndex = 10;
            bigLabel1.Text = "Manage Users";
            // 
            // FrmUsersList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 806);
            Controls.Add(bigLabel1);
            Controls.Add(pbAddNewUser);
            Controls.Add(label2);
            Controls.Add(tbxFilter);
            Controls.Add(cbFilters);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(poisonDataGridView1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmUsersList";
            Text = "Users";
            Load += FrmUsersList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAddNewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private Label label1;
        private Label lblRecords;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cbFilters;
        private TextBox tbxFilter;
        private Label label2;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private PictureBox pbAddNewUser;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editUserToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}