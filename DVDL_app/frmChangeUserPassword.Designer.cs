namespace DVDL_app
{
    partial class frmChangeUserPassword
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
            gbPersonInfos = new GroupBox();
            gbLoginInfos = new GroupBox();
            label1 = new Label();
            tbxCurentPassword = new TextBox();
            tbxNewPass = new TextBox();
            label2 = new Label();
            tbxConfirmPass = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbPersonInfos
            // 
            gbPersonInfos.Location = new Point(24, 41);
            gbPersonInfos.Name = "gbPersonInfos";
            gbPersonInfos.Size = new Size(1089, 414);
            gbPersonInfos.TabIndex = 0;
            gbPersonInfos.TabStop = false;
            gbPersonInfos.Text = "Person Information";
            // 
            // gbLoginInfos
            // 
            gbLoginInfos.Location = new Point(24, 470);
            gbLoginInfos.Name = "gbLoginInfos";
            gbLoginInfos.Size = new Size(1089, 108);
            gbLoginInfos.TabIndex = 1;
            gbLoginInfos.TabStop = false;
            gbLoginInfos.Text = "Login Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 639);
            label1.Name = "label1";
            label1.Size = new Size(208, 29);
            label1.TabIndex = 2;
            label1.Text = "Current Password: ";
            // 
            // tbxCurentPassword
            // 
            tbxCurentPassword.Location = new Point(238, 639);
            tbxCurentPassword.Name = "tbxCurentPassword";
            tbxCurentPassword.Size = new Size(288, 31);
            tbxCurentPassword.TabIndex = 3;
            tbxCurentPassword.Validating += tbxCurentPassword_Validating;
            // 
            // tbxNewPass
            // 
            tbxNewPass.Location = new Point(238, 695);
            tbxNewPass.Name = "tbxNewPass";
            tbxNewPass.Size = new Size(288, 31);
            tbxNewPass.TabIndex = 5;
            tbxNewPass.Validating += tbxNewPass_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 695);
            label2.Name = "label2";
            label2.Size = new Size(175, 29);
            label2.TabIndex = 4;
            label2.Text = "New Password: ";
            // 
            // tbxConfirmPass
            // 
            tbxConfirmPass.Location = new Point(238, 752);
            tbxConfirmPass.Name = "tbxConfirmPass";
            tbxConfirmPass.Size = new Size(288, 31);
            tbxConfirmPass.TabIndex = 7;
            tbxConfirmPass.Validating += tbxConfrimPass_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 752);
            label3.Name = "label3";
            label3.Size = new Size(213, 29);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.DarkSlateGray;
            errorProvider1.SetIconAlignment(btnSave, ErrorIconAlignment.MiddleLeft);
            btnSave.Image = Properties.Resources.save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(944, 789);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 49);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmChangeUserPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 867);
            Controls.Add(btnSave);
            Controls.Add(tbxConfirmPass);
            Controls.Add(label3);
            Controls.Add(tbxNewPass);
            Controls.Add(label2);
            Controls.Add(tbxCurentPassword);
            Controls.Add(label1);
            Controls.Add(gbLoginInfos);
            Controls.Add(gbPersonInfos);
            Name = "frmChangeUserPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += frmChangeUserPassword_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbPersonInfos;
        private GroupBox gbLoginInfos;
        private Label label1;
        private TextBox tbxCurentPassword;
        private TextBox tbxNewPass;
        private Label label2;
        private TextBox tbxConfirmPass;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Button btnSave;
    }
}