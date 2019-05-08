namespace FarmVille
{
    partial class CharCreaterFirst
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
            this.picBoxChar = new System.Windows.Forms.PictureBox();
            this.lblOutfitLable = new System.Windows.Forms.Label();
            this.lblBackdrop = new System.Windows.Forms.Label();
            this.lblBackdropText = new System.Windows.Forms.Label();
            this.lblOutfitText = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbChar = new System.Windows.Forms.ComboBox();
            this.btnOutfitNext = new System.Windows.Forms.Button();
            this.btnOutfitPrev = new System.Windows.Forms.Button();
            this.btnBackPrev = new System.Windows.Forms.Button();
            this.btnBackNest = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChar)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxChar
            // 
            this.picBoxChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxChar.Image = global::FarmVille.Properties.Resources.F1CB;
            this.picBoxChar.Location = new System.Drawing.Point(238, 19);
            this.picBoxChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxChar.Name = "picBoxChar";
            this.picBoxChar.Size = new System.Drawing.Size(276, 322);
            this.picBoxChar.TabIndex = 0;
            this.picBoxChar.TabStop = false;
            // 
            // lblOutfitLable
            // 
            this.lblOutfitLable.AutoSize = true;
            this.lblOutfitLable.Location = new System.Drawing.Point(92, 185);
            this.lblOutfitLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutfitLable.Name = "lblOutfitLable";
            this.lblOutfitLable.Size = new System.Drawing.Size(32, 13);
            this.lblOutfitLable.TabIndex = 1;
            this.lblOutfitLable.Text = "Outfit";
            // 
            // lblBackdrop
            // 
            this.lblBackdrop.AutoSize = true;
            this.lblBackdrop.Location = new System.Drawing.Point(92, 248);
            this.lblBackdrop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackdrop.Name = "lblBackdrop";
            this.lblBackdrop.Size = new System.Drawing.Size(30, 13);
            this.lblBackdrop.TabIndex = 2;
            this.lblBackdrop.Text = "Farm";
            this.lblBackdrop.Visible = false;
            // 
            // lblBackdropText
            // 
            this.lblBackdropText.AutoSize = true;
            this.lblBackdropText.Location = new System.Drawing.Point(71, 275);
            this.lblBackdropText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackdropText.Name = "lblBackdropText";
            this.lblBackdropText.Size = new System.Drawing.Size(64, 13);
            this.lblBackdropText.TabIndex = 3;
            this.lblBackdropText.Text = "Desert Farm";
            this.lblBackdropText.Visible = false;
            this.lblBackdropText.Click += new System.EventHandler(this.lblBackdropText_Click);
            // 
            // lblOutfitText
            // 
            this.lblOutfitText.AutoSize = true;
            this.lblOutfitText.Location = new System.Drawing.Point(92, 211);
            this.lblOutfitText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutfitText.Name = "lblOutfitText";
            this.lblOutfitText.Size = new System.Drawing.Size(28, 13);
            this.lblOutfitText.TabIndex = 4;
            this.lblOutfitText.Text = "Blue";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Location = new System.Drawing.Point(83, 120);
            this.lblCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(53, 13);
            this.lblCharacter.TabIndex = 5;
            this.lblCharacter.Text = "Character";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(92, 58);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(62, 75);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(92, 21);
            this.cmbGender.TabIndex = 9;
            this.cmbGender.Text = "Male";
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // cmbChar
            // 
            this.cmbChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbChar.FormattingEnabled = true;
            this.cmbChar.Items.AddRange(new object[] {
            "Ou Piet",
            "Young John"});
            this.cmbChar.Location = new System.Drawing.Point(62, 136);
            this.cmbChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbChar.Name = "cmbChar";
            this.cmbChar.Size = new System.Drawing.Size(92, 21);
            this.cmbChar.TabIndex = 10;
            this.cmbChar.Text = "Ou Piet";
            this.cmbChar.SelectedIndexChanged += new System.EventHandler(this.cmbChar_SelectedIndexChanged);
            // 
            // btnOutfitNext
            // 
            this.btnOutfitNext.Location = new System.Drawing.Point(152, 206);
            this.btnOutfitNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOutfitNext.Name = "btnOutfitNext";
            this.btnOutfitNext.Size = new System.Drawing.Size(25, 24);
            this.btnOutfitNext.TabIndex = 11;
            this.btnOutfitNext.Text = ">";
            this.btnOutfitNext.UseVisualStyleBackColor = true;
            this.btnOutfitNext.Click += new System.EventHandler(this.btnOutfitNext_Click);
            // 
            // btnOutfitPrev
            // 
            this.btnOutfitPrev.Location = new System.Drawing.Point(31, 206);
            this.btnOutfitPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOutfitPrev.Name = "btnOutfitPrev";
            this.btnOutfitPrev.Size = new System.Drawing.Size(25, 24);
            this.btnOutfitPrev.TabIndex = 12;
            this.btnOutfitPrev.Text = "<";
            this.btnOutfitPrev.UseVisualStyleBackColor = true;
            this.btnOutfitPrev.Click += new System.EventHandler(this.btnOutfitPrev_Click);
            // 
            // btnBackPrev
            // 
            this.btnBackPrev.Location = new System.Drawing.Point(31, 269);
            this.btnBackPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackPrev.Name = "btnBackPrev";
            this.btnBackPrev.Size = new System.Drawing.Size(25, 24);
            this.btnBackPrev.TabIndex = 14;
            this.btnBackPrev.Text = "<";
            this.btnBackPrev.UseVisualStyleBackColor = true;
            this.btnBackPrev.Visible = false;
            // 
            // btnBackNest
            // 
            this.btnBackNest.Location = new System.Drawing.Point(152, 269);
            this.btnBackNest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackNest.Name = "btnBackNest";
            this.btnBackNest.Size = new System.Drawing.Size(25, 24);
            this.btnBackNest.TabIndex = 13;
            this.btnBackNest.Text = ">";
            this.btnBackNest.UseVisualStyleBackColor = true;
            this.btnBackNest.Visible = false;
            this.btnBackNest.Click += new System.EventHandler(this.btnBackNest_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(80, 322);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(56, 19);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // CharCreaterFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnBackPrev);
            this.Controls.Add(this.btnBackNest);
            this.Controls.Add(this.btnOutfitPrev);
            this.Controls.Add(this.btnOutfitNext);
            this.Controls.Add(this.cmbChar);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.lblOutfitText);
            this.Controls.Add(this.lblBackdropText);
            this.Controls.Add(this.lblBackdrop);
            this.Controls.Add(this.lblOutfitLable);
            this.Controls.Add(this.picBoxChar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CharCreaterFirst";
            this.Text = "CharCreaterFirst";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxChar;
        private System.Windows.Forms.Label lblOutfitLable;
        private System.Windows.Forms.Label lblBackdrop;
        private System.Windows.Forms.Label lblBackdropText;
        private System.Windows.Forms.Label lblOutfitText;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbChar;
        private System.Windows.Forms.Button btnOutfitNext;
        private System.Windows.Forms.Button btnOutfitPrev;
        private System.Windows.Forms.Button btnBackPrev;
        private System.Windows.Forms.Button btnBackNest;
        private System.Windows.Forms.Button btnAccept;
    }
}