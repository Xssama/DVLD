namespace DVDL_app
{
    partial class FrmManagePeople
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
            pbManagePeople = new PictureBox();
            plBody = new Panel();
            btnAddPerson = new Button();
            tbFilterBy = new TextBox();
            lblRecordsCount = new Label();
            label3 = new Label();
            label2 = new Label();
            cbFilters = new ComboBox();
            plDataGridtable = new Panel();
            dgvPeopleList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneToolStripMenuItem = new ToolStripMenuItem();
            bsPeopleList = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).BeginInit();
            plBody.SuspendLayout();
            plDataGridtable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeopleList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsPeopleList).BeginInit();
            SuspendLayout();
            // 
            // pbManagePeople
            // 
            pbManagePeople.BackColor = Color.Transparent;
            pbManagePeople.BackgroundImage = Properties.Resources.team_management_4168988;
            pbManagePeople.BackgroundImageLayout = ImageLayout.Zoom;
            pbManagePeople.Location = new Point(630, 29);
            pbManagePeople.Margin = new Padding(2);
            pbManagePeople.Name = "pbManagePeople";
            pbManagePeople.Size = new Size(288, 156);
            pbManagePeople.TabIndex = 1;
            pbManagePeople.TabStop = false;
            // 
            // plBody
            // 
            plBody.Controls.Add(btnAddPerson);
            plBody.Controls.Add(tbFilterBy);
            plBody.Controls.Add(lblRecordsCount);
            plBody.Controls.Add(label3);
            plBody.Controls.Add(label2);
            plBody.Controls.Add(cbFilters);
            plBody.Controls.Add(plDataGridtable);
            plBody.Controls.Add(pbManagePeople);
            plBody.Dock = DockStyle.Fill;
            plBody.Location = new Point(0, 0);
            plBody.Name = "plBody";
            plBody.Size = new Size(1576, 807);
            plBody.TabIndex = 2;
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = Color.Transparent;
            btnAddPerson.FlatAppearance.BorderSize = 0;
            btnAddPerson.FlatStyle = FlatStyle.Flat;
            btnAddPerson.Image = Properties.Resources.add_user_Icon;
            btnAddPerson.Location = new Point(1433, 254);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(59, 54);
            btnAddPerson.TabIndex = 8;
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // tbFilterBy
            // 
            tbFilterBy.Location = new Point(412, 269);
            tbFilterBy.Name = "tbFilterBy";
            tbFilterBy.Size = new Size(251, 31);
            tbFilterBy.TabIndex = 7;
            tbFilterBy.Visible = false;
            tbFilterBy.TextChanged += tbFilterBy_TextChanged;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(120, 682);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(51, 28);
            lblRecordsCount.TabIndex = 6;
            lblRecordsCount.Text = "[???]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 682);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 5;
            label3.Text = "#Records :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 267);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 4;
            label2.Text = "Filter By:";
            // 
            // cbFilters
            // 
            cbFilters.FormattingEnabled = true;
            cbFilters.Items.AddRange(new object[] { "None" });
            cbFilters.Location = new Point(130, 267);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(254, 33);
            cbFilters.TabIndex = 3;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // plDataGridtable
            // 
            plDataGridtable.Controls.Add(dgvPeopleList);
            plDataGridtable.Location = new Point(12, 325);
            plDataGridtable.Name = "plDataGridtable";
            plDataGridtable.Size = new Size(1537, 335);
            plDataGridtable.TabIndex = 3;
            // 
            // dgvPeopleList
            // 
            dgvPeopleList.AutoGenerateColumns = false;
            dgvPeopleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeopleList.ContextMenuStrip = contextMenuStrip1;
            dgvPeopleList.DataSource = bsPeopleList;
            dgvPeopleList.Dock = DockStyle.Fill;
            dgvPeopleList.Location = new Point(0, 0);
            dgvPeopleList.Name = "dgvPeopleList";
            dgvPeopleList.RowHeadersVisible = false;
            dgvPeopleList.RowHeadersWidth = 51;
            dgvPeopleList.Size = new Size(1537, 335);
            dgvPeopleList.TabIndex = 2;
            dgvPeopleList.CellMouseDown += dgvPeopleList_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, addToolStripMenuItem, editToolStripMenuItem, updateToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, phoneToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(254, 244);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showDetailsToolStripMenuItem.Image = Properties.Resources.persondetailsicon;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(253, 38);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(250, 6);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addToolStripMenuItem.Image = Properties.Resources.newPersonIcon;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(253, 38);
            addToolStripMenuItem.Text = "Add New Person";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editToolStripMenuItem.Image = Properties.Resources.EditPerson;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(253, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            updateToolStripMenuItem.Image = Properties.Resources.DeletePerson;
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(253, 38);
            updateToolStripMenuItem.Text = "Delete";
            updateToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(250, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            sendEmailToolStripMenuItem.Image = Properties.Resources.mailsend;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(253, 38);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneToolStripMenuItem
            // 
            phoneToolStripMenuItem.Font = new Font("Palatino Linotype", 12F);
            phoneToolStripMenuItem.Image = Properties.Resources.phonecall;
            phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            phoneToolStripMenuItem.Size = new Size(253, 38);
            phoneToolStripMenuItem.Text = "Phone Call";
            // 
            // FrmManagePeople
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 807);
            Controls.Add(plBody);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "FrmManagePeople";
            Text = "Manage People";
            Load += FrmManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).EndInit();
            plBody.ResumeLayout(false);
            plBody.PerformLayout();
            plDataGridtable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPeopleList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsPeopleList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbManagePeople;
        private Panel plBody;
        private DataGridView dgvPeopleList;
        private Panel plDataGridtable;
        private ComboBox cbFilters;
        private Label label2;
        private Label lblRecordsCount;
        private Label label3;
        private TextBox tbFilterBy;
        private BindingSource bsPeopleList;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnAddPerson;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneToolStripMenuItem;
    }
}