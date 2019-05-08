namespace FarmVille
{
    partial class Register
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBrithDate = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsernameConfirm = new System.Windows.Forms.TextBox();
            this.lblUserConfirm = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblPassConfirm = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblUsernameNoMatch = new System.Windows.Forms.Label();
            this.lblPasswordNoMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 17);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(92, 20);
            this.txtName.TabIndex = 0;
            // 
            // dtpBrithDate
            // 
            this.dtpBrithDate.Location = new System.Drawing.Point(66, 85);
            this.dtpBrithDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBrithDate.Name = "dtpBrithDate";
            this.dtpBrithDate.Size = new System.Drawing.Size(192, 20);
            this.dtpBrithDate.TabIndex = 1;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(66, 62);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(92, 21);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.Text = "Male";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 17);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 63);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(17, 89);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(51, 13);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "BirthDate";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(275, 63);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(371, 61);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(92, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(371, 38);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(92, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(274, 40);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsernameConfirm
            // 
            this.txtUsernameConfirm.Location = new System.Drawing.Point(371, 107);
            this.txtUsernameConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsernameConfirm.Name = "txtUsernameConfirm";
            this.txtUsernameConfirm.Size = new System.Drawing.Size(92, 20);
            this.txtUsernameConfirm.TabIndex = 13;
            // 
            // lblUserConfirm
            // 
            this.lblUserConfirm.AutoSize = true;
            this.lblUserConfirm.Location = new System.Drawing.Point(274, 110);
            this.lblUserConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserConfirm.Name = "lblUserConfirm";
            this.lblUserConfirm.Size = new System.Drawing.Size(96, 13);
            this.lblUserConfirm.TabIndex = 12;
            this.lblUserConfirm.Text = "Confirm Username:";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(371, 130);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(92, 20);
            this.txtPasswordConfirm.TabIndex = 11;
            // 
            // lblPassConfirm
            // 
            this.lblPassConfirm.AutoSize = true;
            this.lblPassConfirm.Location = new System.Drawing.Point(274, 132);
            this.lblPassConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassConfirm.Name = "lblPassConfirm";
            this.lblPassConfirm.Size = new System.Drawing.Size(94, 13);
            this.lblPassConfirm.TabIndex = 10;
            this.lblPassConfirm.Text = "Confirm Password:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(17, 40);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(66, 40);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(92, 20);
            this.txtSurname.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(405, 179);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(56, 25);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblUsernameNoMatch
            // 
            this.lblUsernameNoMatch.AutoSize = true;
            this.lblUsernameNoMatch.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameNoMatch.Location = new System.Drawing.Point(277, 162);
            this.lblUsernameNoMatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameNoMatch.Name = "lblUsernameNoMatch";
            this.lblUsernameNoMatch.Size = new System.Drawing.Size(129, 13);
            this.lblUsernameNoMatch.TabIndex = 17;
            this.lblUsernameNoMatch.Text = "*Usernames do not match";
            this.lblUsernameNoMatch.Visible = false;
            // 
            // lblPasswordNoMatch
            // 
            this.lblPasswordNoMatch.AutoSize = true;
            this.lblPasswordNoMatch.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordNoMatch.Location = new System.Drawing.Point(277, 150);
            this.lblPasswordNoMatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordNoMatch.Name = "lblPasswordNoMatch";
            this.lblPasswordNoMatch.Size = new System.Drawing.Size(127, 13);
            this.lblPasswordNoMatch.TabIndex = 18;
            this.lblPasswordNoMatch.Text = "*Passwords do not match";
            this.lblPasswordNoMatch.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(526, 240);
            this.Controls.Add(this.lblPasswordNoMatch);
            this.Controls.Add(this.lblUsernameNoMatch);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtUsernameConfirm);
            this.Controls.Add(this.lblUserConfirm);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.lblPassConfirm);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dtpBrithDate);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBrithDate;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsernameConfirm;
        private System.Windows.Forms.Label lblUserConfirm;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label lblPassConfirm;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUsernameNoMatch;
        private System.Windows.Forms.Label lblPasswordNoMatch;
    }
}