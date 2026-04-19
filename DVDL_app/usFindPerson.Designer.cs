namespace DVDL_app
{
    partial class usFindPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gpPersonalInfos = new GroupBox();
            gbFilter = new GroupBox();
            btnAddPerson = new ReaLTaiizor.Controls.Button();
            btnSearch = new ReaLTaiizor.Controls.Button();
            tbxfilterby = new TextBox();
            label1 = new Label();
            cbFilterBy = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gpPersonalInfos
            // 
            gpPersonalInfos.Location = new Point(11, 140);
            gpPersonalInfos.Name = "gpPersonalInfos";
            gpPersonalInfos.Size = new Size(1084, 467);
            gpPersonalInfos.TabIndex = 4;
            gpPersonalInfos.TabStop = false;
            gpPersonalInfos.Text = "Personal Infos";
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddPerson);
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(tbxfilterby);
            gbFilter.Controls.Add(label1);
            gbFilter.Controls.Add(cbFilterBy);
            gbFilter.Location = new Point(11, 22);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1076, 102);
            gbFilter.TabIndex = 3;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = Color.Transparent;
            btnAddPerson.BackgroundImageLayout = ImageLayout.None;
            btnAddPerson.BorderColor = Color.Transparent;
            btnAddPerson.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnAddPerson.EnteredColor = Color.Transparent;
            btnAddPerson.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddPerson.Image = Properties.Resources.user_16382065;
            btnAddPerson.ImageAlign = ContentAlignment.MiddleCenter;
            btnAddPerson.InactiveColor = Color.Transparent;
            btnAddPerson.Location = new Point(856, 33);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.PressedBorderColor = Color.Transparent;
            btnAddPerson.PressedColor = Color.FromArgb(165, 37, 37);
            btnAddPerson.Size = new Size(54, 58);
            btnAddPerson.TabIndex = 4;
            btnAddPerson.TextAlignment = StringAlignment.Center;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.BorderColor = Color.Transparent;
            btnSearch.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSearch.EnteredColor = Color.Transparent;
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F);
            btnSearch.Image = Properties.Resources.searchuser;
            btnSearch.ImageAlign = ContentAlignment.MiddleCenter;
            btnSearch.InactiveColor = Color.Transparent;
            btnSearch.Location = new Point(775, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.PressedBorderColor = Color.Transparent;
            btnSearch.PressedColor = Color.FromArgb(165, 37, 37);
            btnSearch.Size = new Size(54, 58);
            btnSearch.TabIndex = 3;
            btnSearch.TextAlignment = StringAlignment.Center;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxfilterby
            // 
            tbxfilterby.BorderStyle = BorderStyle.FixedSingle;
            tbxfilterby.Location = new Point(445, 40);
            tbxfilterby.Name = "tbxfilterby";
            tbxfilterby.Size = new Size(272, 31);
            tbxfilterby.TabIndex = 2;
            tbxfilterby.Validating += tbxfilterby_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 42);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Find By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FlatStyle = FlatStyle.System;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "PersonID", "NationalNo" });
            cbFilterBy.Location = new Point(120, 39);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(289, 33);
            cbFilterBy.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // usFindPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gpPersonalInfos);
            Controls.Add(gbFilter);
            Name = "usFindPerson";
            Size = new Size(1109, 627);
            Load += usFindPerson_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpPersonalInfos;
        private GroupBox gbFilter;
        private ReaLTaiizor.Controls.Button btnAddPerson;
        private ReaLTaiizor.Controls.Button btnSearch;
        private TextBox tbxfilterby;
        private Label label1;
        private ComboBox cbFilterBy;
        private ErrorProvider errorProvider1;
    }
}
