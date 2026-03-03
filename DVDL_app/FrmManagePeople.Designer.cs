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
            plTopPanel = new Panel();
            label1 = new Label();
            btnClose = new Button();
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
            bsPeopleList = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            plTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).BeginInit();
            plBody.SuspendLayout();
            plDataGridtable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeopleList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPeopleList).BeginInit();
            SuspendLayout();
            // 
            // plTopPanel
            // 
            plTopPanel.BackgroundImageLayout = ImageLayout.Zoom;
            plTopPanel.Controls.Add(label1);
            plTopPanel.Controls.Add(btnClose);
            plTopPanel.Dock = DockStyle.Top;
            plTopPanel.Location = new Point(0, 0);
            plTopPanel.Margin = new Padding(2);
            plTopPanel.Name = "plTopPanel";
            plTopPanel.Size = new Size(1581, 51);
            plTopPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 1;
            label1.Text = "Manage People";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1532, 0);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(49, 51);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            plBody.Location = new Point(0, 51);
            plBody.Name = "plBody";
            plBody.Size = new Size(1581, 756);
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
            plDataGridtable.Size = new Size(1557, 335);
            plDataGridtable.TabIndex = 3;
            // 
            // dgvPeopleList
            // 
            dgvPeopleList.AutoGenerateColumns = false;
            dgvPeopleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeopleList.DataSource = bsPeopleList;
            dgvPeopleList.Dock = DockStyle.Fill;
            dgvPeopleList.Location = new Point(0, 0);
            dgvPeopleList.Name = "dgvPeopleList";
            dgvPeopleList.RowHeadersWidth = 51;
            dgvPeopleList.Size = new Size(1557, 335);
            dgvPeopleList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FrmManagePeople
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 807);
            Controls.Add(plBody);
            Controls.Add(plTopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmManagePeople";
            Text = "Manage People";
            Load += FrmManagePeople_Load;
            plTopPanel.ResumeLayout(false);
            plTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).EndInit();
            plBody.ResumeLayout(false);
            plBody.PerformLayout();
            plDataGridtable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPeopleList).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPeopleList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plTopPanel;
        private Button btnClose;
        private Label label1;
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
    }
}