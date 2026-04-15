namespace DVDL_app
{
    partial class frmManageAppointments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            plShowAppInfosHandler = new Panel();
            groupBox1 = new GroupBox();
            lblRecords = new Label();
            label1 = new Label();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // plShowAppInfosHandler
            // 
            plShowAppInfosHandler.Location = new Point(12, 103);
            plShowAppInfosHandler.Name = "plShowAppInfosHandler";
            plShowAppInfosHandler.Size = new Size(1029, 472);
            plShowAppInfosHandler.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblRecords);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(poisonDataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 721);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1055, 399);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointments";
            // 
            // lblRecords
            // 
            lblRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(134, 344);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(59, 29);
            lblRecords.TabIndex = 9;
            lblRecords.Text = "[???]";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 344);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 8;
            label1.Text = "# Records : ";
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            poisonDataGridView1.Dock = DockStyle.Top;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(3, 32);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            poisonDataGridView1.RowHeadersWidth = 51;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(1049, 300);
            poisonDataGridView1.TabIndex = 0;
            // 
            // frmManageAppointments
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1055, 1120);
            Controls.Add(groupBox1);
            Controls.Add(plShowAppInfosHandler);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1073, 1138);
            Name = "frmManageAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmManageAppointments";
            Load += frmManageAppointments_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plShowAppInfosHandler;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private Label lblRecords;
        private Label label1;
    }
}