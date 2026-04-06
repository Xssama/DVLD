namespace DVDL_app
{
    partial class frmMainScreen
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
            menuStrip1 = new MenuStrip();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            UsersToolStripMenuItem = new ToolStripMenuItem();
            AccountSettingsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationsToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, UsersToolStripMenuItem, AccountSettingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1858, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationsToolStripMenuItem.Image = Properties.Resources.Applications;
            applicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(173, 36);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            peopleToolStripMenuItem.Image = Properties.Resources.people;
            peopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(120, 36);
            peopleToolStripMenuItem.Text = "People";
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            driversToolStripMenuItem.Image = Properties.Resources.drivers;
            driversToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(128, 36);
            driversToolStripMenuItem.Text = "Drivers";
            // 
            // UsersToolStripMenuItem
            // 
            UsersToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsersToolStripMenuItem.Image = Properties.Resources.ManageUsers32;
            UsersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            UsersToolStripMenuItem.Size = new Size(110, 36);
            UsersToolStripMenuItem.Text = "Users";
            // 
            // AccountSettingsToolStripMenuItem
            // 
            AccountSettingsToolStripMenuItem.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountSettingsToolStripMenuItem.Image = Properties.Resources.Accountsettingsicon;
            AccountSettingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem";
            AccountSettingsToolStripMenuItem.Size = new Size(212, 36);
            AccountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1858, 973);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMainScreen";
            Text = "Driving Licenses Management";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem UsersToolStripMenuItem;
        private ToolStripMenuItem AccountSettingsToolStripMenuItem;
    }
}