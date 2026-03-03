namespace DVDL_app
{
    partial class frmAddEditPerson
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
            lblHeader = new Label();
            plAddEditUSContainer = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblPersonID = new Label();
            menuStrip1 = new MenuStrip();
            button1 = new Button();
            plAddEditUSContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.OrangeRed;
            lblHeader.Location = new Point(433, 31);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(300, 38);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Add/Edit Person Infos";
            // 
            // plAddEditUSContainer
            // 
            plAddEditUSContainer.Controls.Add(menuStrip1);
            plAddEditUSContainer.Location = new Point(14, 155);
            plAddEditUSContainer.Name = "plAddEditUSContainer";
            plAddEditUSContainer.Size = new Size(1124, 530);
            plAddEditUSContainer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 115);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Person ID : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.personidIcon;
            pictureBox1.Location = new Point(133, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(201, 115);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(45, 25);
            lblPersonID.TabIndex = 4;
            lblPersonID.Text = "N/A";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1124, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            button1.Location = new Point(1020, 113);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmAddEditPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 697);
            Controls.Add(button1);
            Controls.Add(lblPersonID);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(plAddEditUSContainer);
            Controls.Add(lblHeader);
            MainMenuStrip = menuStrip1;
            Name = "frmAddEditPerson";
            Text = "Add/Edit Person";
            Load += frmAddEditPerson_Load;
            plAddEditUSContainer.ResumeLayout(false);
            plAddEditUSContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Panel plAddEditUSContainer;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblPersonID;
        private MenuStrip menuStrip1;
        private Button button1;
    }
}