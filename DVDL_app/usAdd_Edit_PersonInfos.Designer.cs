namespace DVDL_app
{
    partial class usAdd_Edit_PersonInfos
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            tbFirstName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tbSecondName = new TextBox();
            label6 = new Label();
            tbxThirdName = new TextBox();
            label7 = new Label();
            tbLastName = new TextBox();
            tbNationalNo = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            gbGendor = new GroupBox();
            pictureBox4 = new PictureBox();
            cbFemale = new CheckBox();
            pictureBox3 = new PictureBox();
            cbMale = new CheckBox();
            tbEmail = new TextBox();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            tbAddress = new TextBox();
            pictureBox6 = new PictureBox();
            label9 = new Label();
            pictureBox7 = new PictureBox();
            label10 = new Label();
            tbPhone = new TextBox();
            pictureBox8 = new PictureBox();
            label11 = new Label();
            pictureBox9 = new PictureBox();
            label12 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            cbCountry = new ComboBox();
            pbPersonImage = new PictureBox();
            btnSetImage = new Button();
            ofdPersonPic = new OpenFileDialog();
            btnSave = new Button();
            btnRemove = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbGendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.PersonNameIcon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(163, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 34);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 119);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 2;
            label2.Text = "National No :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 52);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 3;
            label3.Text = "Name           :";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(214, 50);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(193, 31);
            tbFirstName.TabIndex = 4;
            tbFirstName.Tag = "FirstName";
            tbFirstName.Validating += ValiditingControlsAtFocusChange;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(269, 9);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 5;
            label4.Text = "First";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(473, 9);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 7;
            label5.Text = "Second";
            // 
            // tbSecondName
            // 
            tbSecondName.Location = new Point(423, 50);
            tbSecondName.Name = "tbSecondName";
            tbSecondName.Size = new Size(193, 31);
            tbSecondName.TabIndex = 6;
            tbSecondName.Tag = "SecondName";
            tbSecondName.Validating += ValiditingControlsAtFocusChange;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(690, 9);
            label6.Name = "label6";
            label6.Size = new Size(57, 28);
            label6.TabIndex = 9;
            label6.Text = "Third";
            // 
            // tbxThirdName
            // 
            tbxThirdName.Location = new Point(631, 50);
            tbxThirdName.Name = "tbxThirdName";
            tbxThirdName.Size = new Size(193, 31);
            tbxThirdName.TabIndex = 8;
            tbxThirdName.Tag = "ThirdName";
            tbxThirdName.Validating += ValiditingControlsAtFocusChange;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(913, 9);
            label7.Name = "label7";
            label7.Size = new Size(46, 28);
            label7.TabIndex = 11;
            label7.Text = "Last";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(840, 50);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(193, 31);
            tbLastName.TabIndex = 10;
            tbLastName.Tag = "LastName";
            tbLastName.Validating += ValiditingControlsAtFocusChange;
            // 
            // tbNationalNo
            // 
            tbNationalNo.Location = new Point(214, 113);
            tbNationalNo.Name = "tbNationalNo";
            tbNationalNo.Size = new Size(193, 31);
            tbNationalNo.TabIndex = 13;
            tbNationalNo.Tag = "NationalNo";
            tbNationalNo.Validating += ValiditingControlsAtFocusChange;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.NationalNoIcon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(163, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 32);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 176);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 14;
            label1.Text = "Gendor        :";
            // 
            // gbGendor
            // 
            gbGendor.Controls.Add(pictureBox4);
            gbGendor.Controls.Add(cbFemale);
            gbGendor.Controls.Add(pictureBox3);
            gbGendor.Controls.Add(cbMale);
            gbGendor.FlatStyle = FlatStyle.Flat;
            gbGendor.Location = new Point(149, 159);
            gbGendor.Name = "gbGendor";
            gbGendor.Size = new Size(258, 50);
            gbGendor.TabIndex = 15;
            gbGendor.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.girlIcon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(123, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 30);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // cbFemale
            // 
            cbFemale.AutoSize = true;
            cbFemale.Location = new Point(162, 16);
            cbFemale.Name = "cbFemale";
            cbFemale.Size = new Size(90, 29);
            cbFemale.TabIndex = 17;
            cbFemale.Text = "Female";
            cbFemale.UseVisualStyleBackColor = true;
            cbFemale.CheckedChanged += cbFemale_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.boyIcon;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(6, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // cbMale
            // 
            cbMale.AutoSize = true;
            cbMale.Location = new Point(45, 17);
            cbMale.Name = "cbMale";
            cbMale.Size = new Size(72, 29);
            cbMale.TabIndex = 0;
            cbMale.Text = "Male";
            cbMale.UseVisualStyleBackColor = true;
            cbMale.CheckedChanged += cbMale_CheckedChanged;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(204, 235);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(203, 31);
            tbEmail.TabIndex = 18;
            tbEmail.Validating += tbEmail_Validating;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.emailIcon;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(153, 235);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 32);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 241);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 16;
            label8.Text = "Email            :";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(204, 289);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(620, 124);
            tbAddress.TabIndex = 21;
            tbAddress.Tag = "Address";
            tbAddress.Validating += ValiditingControlsAtFocusChange;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.AddressIcon;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(153, 289);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 32);
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 295);
            label9.Name = "label9";
            label9.Size = new Size(115, 25);
            label9.TabIndex = 19;
            label9.Text = "Address       :";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources.DateOfBirthIcon;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(555, 113);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 32);
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(412, 119);
            label10.Name = "label10";
            label10.Size = new Size(128, 25);
            label10.TabIndex = 22;
            label10.Text = "Date Of Birth :";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(606, 174);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(203, 31);
            tbPhone.TabIndex = 27;
            tbPhone.Tag = "Phone";
            tbPhone.Validating += tbPhone_Validating;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = Properties.Resources.PhoneIcon;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(555, 174);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(33, 32);
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(434, 181);
            label11.Name = "label11";
            label11.Size = new Size(106, 25);
            label11.TabIndex = 25;
            label11.Text = "Phone        :";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = Properties.Resources.COuntryIcon;
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(555, 235);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(33, 32);
            pictureBox9.TabIndex = 29;
            pictureBox9.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(434, 238);
            label12.Name = "label12";
            label12.Size = new Size(104, 25);
            label12.TabIndex = 28;
            label12.Text = "Country     :";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(606, 114);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(203, 31);
            dtpDateOfBirth.TabIndex = 30;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(606, 230);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(203, 33);
            cbCountry.TabIndex = 31;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Location = new Point(840, 113);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(193, 150);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 32;
            pbPersonImage.TabStop = false;
            // 
            // btnSetImage
            // 
            btnSetImage.BackgroundImageLayout = ImageLayout.None;
            btnSetImage.FlatAppearance.BorderSize = 0;
            btnSetImage.FlatStyle = FlatStyle.Flat;
            btnSetImage.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSetImage.ForeColor = Color.Green;
            btnSetImage.Location = new Point(877, 287);
            btnSetImage.Name = "btnSetImage";
            btnSetImage.Size = new Size(121, 39);
            btnSetImage.TabIndex = 33;
            btnSetImage.Text = "Set Image";
            btnSetImage.UseVisualStyleBackColor = true;
            btnSetImage.Click += btnSetImage_Click;
            // 
            // ofdPersonPic
            // 
            ofdPersonPic.FileName = "Pic";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.SteelBlue;
            btnSave.Image = Properties.Resources.save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(448, 439);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 43);
            btnSave.TabIndex = 34;
            btnSave.Text = " Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackgroundImageLayout = ImageLayout.None;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Green;
            btnRemove.Location = new Point(877, 332);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(121, 39);
            btnRemove.TabIndex = 36;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Visible = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // usAdd_Edit_PersonInfos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRemove);
            Controls.Add(btnSave);
            Controls.Add(btnSetImage);
            Controls.Add(pbPersonImage);
            Controls.Add(cbCountry);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(pictureBox9);
            Controls.Add(label12);
            Controls.Add(tbPhone);
            Controls.Add(pictureBox8);
            Controls.Add(label11);
            Controls.Add(pictureBox7);
            Controls.Add(label10);
            Controls.Add(tbAddress);
            Controls.Add(pictureBox6);
            Controls.Add(label9);
            Controls.Add(tbEmail);
            Controls.Add(pictureBox5);
            Controls.Add(label8);
            Controls.Add(gbGendor);
            Controls.Add(label1);
            Controls.Add(tbNationalNo);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(tbLastName);
            Controls.Add(label6);
            Controls.Add(tbxThirdName);
            Controls.Add(label5);
            Controls.Add(tbSecondName);
            Controls.Add(label4);
            Controls.Add(tbFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "usAdd_Edit_PersonInfos";
            Size = new Size(1059, 509);
            Load += usAdd_Edit_PersonInfos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbGendor.ResumeLayout(false);
            gbGendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox tbFirstName;
        private Label label4;
        private Label label5;
        private TextBox tbSecondName;
        private Label label6;
        private TextBox tbxThirdName;
        private Label label7;
        private TextBox tbLastName;
        private TextBox tbNationalNo;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox gbGendor;
        private CheckBox cbMale;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private CheckBox cbFemale;
        private TextBox tbEmail;
        private PictureBox pictureBox5;
        private Label label8;
        private TextBox tbAddress;
        private PictureBox pictureBox6;
        private Label label9;
        private PictureBox pictureBox7;
        private Label label10;
        private TextBox tbPhone;
        private PictureBox pictureBox8;
        private Label label11;
        private PictureBox pictureBox9;
        private Label label12;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbCountry;
        private PictureBox pbPersonImage;
        private Button btnSetImage;
        private OpenFileDialog ofdPersonPic;
        private Button btnSave;
        private Button btnRemove;
        private ErrorProvider errorProvider1;
    }
}
