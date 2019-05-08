namespace FarmVille
{
    partial class Create_Farm
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
            this.txtFarmSize = new System.Windows.Forms.TextBox();
            this.cmbAmountOfAnimals = new System.Windows.Forms.ComboBox();
            this.lblFarmzise = new System.Windows.Forms.Label();
            this.lblDiffrentTypesAnimals = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblFArnName = new System.Windows.Forms.Label();
            this.txtFarmName = new System.Windows.Forms.TextBox();
            this.btnCheckAvability = new System.Windows.Forms.Button();
            this.txtAnimalAmountFive = new System.Windows.Forms.TextBox();
            this.txtAnimalAmountFour = new System.Windows.Forms.TextBox();
            this.txtAnimalAmountThree = new System.Windows.Forms.TextBox();
            this.txtAnimalAmountTwo = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.txtAnimalAmountOne = new System.Windows.Forms.TextBox();
            this.lblAvalible = new System.Windows.Forms.Label();
            this.lblNotAvalible = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbAnimalFour = new System.Windows.Forms.ComboBox();
            this.cmbAnimalThree = new System.Windows.Forms.ComboBox();
            this.cmbAnimalTwo = new System.Windows.Forms.ComboBox();
            this.cmbAnimalFive = new System.Windows.Forms.ComboBox();
            this.cmbAnimalOne = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFarmSize
            // 
            this.txtFarmSize.Location = new System.Drawing.Point(76, 37);
            this.txtFarmSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtFarmSize.Name = "txtFarmSize";
            this.txtFarmSize.Size = new System.Drawing.Size(60, 20);
            this.txtFarmSize.TabIndex = 0;
            // 
            // cmbAmountOfAnimals
            // 
            this.cmbAmountOfAnimals.FormattingEnabled = true;
            this.cmbAmountOfAnimals.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cmbAmountOfAnimals.Location = new System.Drawing.Point(315, 37);
            this.cmbAmountOfAnimals.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAmountOfAnimals.Name = "cmbAmountOfAnimals";
            this.cmbAmountOfAnimals.Size = new System.Drawing.Size(92, 21);
            this.cmbAmountOfAnimals.TabIndex = 1;
            this.cmbAmountOfAnimals.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFarmzise
            // 
            this.lblFarmzise.AutoSize = true;
            this.lblFarmzise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFarmzise.Location = new System.Drawing.Point(8, 37);
            this.lblFarmzise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFarmzise.Name = "lblFarmzise";
            this.lblFarmzise.Size = new System.Drawing.Size(56, 13);
            this.lblFarmzise.TabIndex = 2;
            this.lblFarmzise.Text = "Farm Size:";
            // 
            // lblDiffrentTypesAnimals
            // 
            this.lblDiffrentTypesAnimals.AutoSize = true;
            this.lblDiffrentTypesAnimals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDiffrentTypesAnimals.Location = new System.Drawing.Point(142, 40);
            this.lblDiffrentTypesAnimals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiffrentTypesAnimals.Name = "lblDiffrentTypesAnimals";
            this.lblDiffrentTypesAnimals.Size = new System.Drawing.Size(157, 13);
            this.lblDiffrentTypesAnimals.TabIndex = 3;
            this.lblDiffrentTypesAnimals.Text = "Number diffrent types of animals";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(15, 334);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 19);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreate.Location = new System.Drawing.Point(271, 334);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(56, 19);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblFArnName
            // 
            this.lblFArnName.AutoSize = true;
            this.lblFArnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFArnName.Location = new System.Drawing.Point(8, 76);
            this.lblFArnName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFArnName.Name = "lblFArnName";
            this.lblFArnName.Size = new System.Drawing.Size(64, 13);
            this.lblFArnName.TabIndex = 6;
            this.lblFArnName.Text = "Farm Name:";
            // 
            // txtFarmName
            // 
            this.txtFarmName.Location = new System.Drawing.Point(76, 72);
            this.txtFarmName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFarmName.Name = "txtFarmName";
            this.txtFarmName.Size = new System.Drawing.Size(116, 20);
            this.txtFarmName.TabIndex = 7;
            // 
            // btnCheckAvability
            // 
            this.btnCheckAvability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCheckAvability.Location = new System.Drawing.Point(196, 69);
            this.btnCheckAvability.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckAvability.Name = "btnCheckAvability";
            this.btnCheckAvability.Size = new System.Drawing.Size(88, 24);
            this.btnCheckAvability.TabIndex = 8;
            this.btnCheckAvability.Text = "Check Avalibility";
            this.btnCheckAvability.UseVisualStyleBackColor = false;
            this.btnCheckAvability.Click += new System.EventHandler(this.btnCheckAvability_Click);
            // 
            // txtAnimalAmountFive
            // 
            this.txtAnimalAmountFive.Enabled = false;
            this.txtAnimalAmountFive.Location = new System.Drawing.Point(228, 248);
            this.txtAnimalAmountFive.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalAmountFive.Name = "txtAnimalAmountFive";
            this.txtAnimalAmountFive.Size = new System.Drawing.Size(76, 20);
            this.txtAnimalAmountFive.TabIndex = 29;
            // 
            // txtAnimalAmountFour
            // 
            this.txtAnimalAmountFour.Enabled = false;
            this.txtAnimalAmountFour.Location = new System.Drawing.Point(228, 225);
            this.txtAnimalAmountFour.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalAmountFour.Name = "txtAnimalAmountFour";
            this.txtAnimalAmountFour.Size = new System.Drawing.Size(76, 20);
            this.txtAnimalAmountFour.TabIndex = 28;
            // 
            // txtAnimalAmountThree
            // 
            this.txtAnimalAmountThree.Enabled = false;
            this.txtAnimalAmountThree.Location = new System.Drawing.Point(228, 202);
            this.txtAnimalAmountThree.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalAmountThree.Name = "txtAnimalAmountThree";
            this.txtAnimalAmountThree.Size = new System.Drawing.Size(76, 20);
            this.txtAnimalAmountThree.TabIndex = 27;
            // 
            // txtAnimalAmountTwo
            // 
            this.txtAnimalAmountTwo.Enabled = false;
            this.txtAnimalAmountTwo.Location = new System.Drawing.Point(228, 180);
            this.txtAnimalAmountTwo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalAmountTwo.Name = "txtAnimalAmountTwo";
            this.txtAnimalAmountTwo.Size = new System.Drawing.Size(76, 20);
            this.txtAnimalAmountTwo.TabIndex = 26;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAmount.Location = new System.Drawing.Point(226, 133);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 25;
            this.lblAmount.Text = "Amount:";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAnimal.Location = new System.Drawing.Point(49, 133);
            this.lblAnimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(41, 13);
            this.lblAnimal.TabIndex = 24;
            this.lblAnimal.Text = "Animal:";
            // 
            // txtAnimalAmountOne
            // 
            this.txtAnimalAmountOne.Enabled = false;
            this.txtAnimalAmountOne.Location = new System.Drawing.Point(228, 157);
            this.txtAnimalAmountOne.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnimalAmountOne.Name = "txtAnimalAmountOne";
            this.txtAnimalAmountOne.Size = new System.Drawing.Size(76, 20);
            this.txtAnimalAmountOne.TabIndex = 23;
            // 
            // lblAvalible
            // 
            this.lblAvalible.AutoSize = true;
            this.lblAvalible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAvalible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAvalible.Location = new System.Drawing.Point(294, 76);
            this.lblAvalible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvalible.Name = "lblAvalible";
            this.lblAvalible.Size = new System.Drawing.Size(44, 13);
            this.lblAvalible.TabIndex = 30;
            this.lblAvalible.Text = "Avalible";
            this.lblAvalible.Visible = false;
            // 
            // lblNotAvalible
            // 
            this.lblNotAvalible.AutoSize = true;
            this.lblNotAvalible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNotAvalible.ForeColor = System.Drawing.Color.Red;
            this.lblNotAvalible.Location = new System.Drawing.Point(292, 75);
            this.lblNotAvalible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotAvalible.Name = "lblNotAvalible";
            this.lblNotAvalible.Size = new System.Drawing.Size(57, 13);
            this.lblNotAvalible.TabIndex = 31;
            this.lblNotAvalible.Text = "Unavalible";
            this.lblNotAvalible.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cmbAnimalFour
            // 
            this.cmbAnimalFour.FormattingEnabled = true;
            this.cmbAnimalFour.Location = new System.Drawing.Point(52, 226);
            this.cmbAnimalFour.Name = "cmbAnimalFour";
            this.cmbAnimalFour.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimalFour.TabIndex = 33;
            // 
            // cmbAnimalThree
            // 
            this.cmbAnimalThree.FormattingEnabled = true;
            this.cmbAnimalThree.Location = new System.Drawing.Point(52, 203);
            this.cmbAnimalThree.Name = "cmbAnimalThree";
            this.cmbAnimalThree.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimalThree.TabIndex = 34;
            // 
            // cmbAnimalTwo
            // 
            this.cmbAnimalTwo.FormattingEnabled = true;
            this.cmbAnimalTwo.Location = new System.Drawing.Point(52, 180);
            this.cmbAnimalTwo.Name = "cmbAnimalTwo";
            this.cmbAnimalTwo.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimalTwo.TabIndex = 35;
            // 
            // cmbAnimalFive
            // 
            this.cmbAnimalFive.FormattingEnabled = true;
            this.cmbAnimalFive.Location = new System.Drawing.Point(53, 249);
            this.cmbAnimalFive.Name = "cmbAnimalFive";
            this.cmbAnimalFive.Size = new System.Drawing.Size(120, 21);
            this.cmbAnimalFive.TabIndex = 36;
            // 
            // cmbAnimalOne
            // 
            this.cmbAnimalOne.FormattingEnabled = true;
            this.cmbAnimalOne.Location = new System.Drawing.Point(52, 157);
            this.cmbAnimalOne.Name = "cmbAnimalOne";
            this.cmbAnimalOne.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimalOne.TabIndex = 37;
            // 
            // Create_Farm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmVille.Properties.Resources.Create;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 366);
            this.Controls.Add(this.cmbAnimalOne);
            this.Controls.Add(this.cmbAnimalFive);
            this.Controls.Add(this.cmbAnimalTwo);
            this.Controls.Add(this.cmbAnimalThree);
            this.Controls.Add(this.cmbAnimalFour);
            this.Controls.Add(this.lblNotAvalible);
            this.Controls.Add(this.lblAvalible);
            this.Controls.Add(this.txtAnimalAmountFive);
            this.Controls.Add(this.txtAnimalAmountFour);
            this.Controls.Add(this.txtAnimalAmountThree);
            this.Controls.Add(this.txtAnimalAmountTwo);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.txtAnimalAmountOne);
            this.Controls.Add(this.btnCheckAvability);
            this.Controls.Add(this.txtFarmName);
            this.Controls.Add(this.lblFArnName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDiffrentTypesAnimals);
            this.Controls.Add(this.lblFarmzise);
            this.Controls.Add(this.cmbAmountOfAnimals);
            this.Controls.Add(this.txtFarmSize);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Create_Farm";
            this.Text = "Create Farm";
            this.Load += new System.EventHandler(this.Create_Farm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFarmSize;
        private System.Windows.Forms.ComboBox cmbAmountOfAnimals;
        private System.Windows.Forms.Label lblFarmzise;
        private System.Windows.Forms.Label lblDiffrentTypesAnimals;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblFArnName;
        private System.Windows.Forms.TextBox txtFarmName;
        private System.Windows.Forms.Button btnCheckAvability;
        private System.Windows.Forms.TextBox txtAnimalAmountFive;
        private System.Windows.Forms.TextBox txtAnimalAmountFour;
        private System.Windows.Forms.TextBox txtAnimalAmountThree;
        private System.Windows.Forms.TextBox txtAnimalAmountTwo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.TextBox txtAnimalAmountOne;
        private System.Windows.Forms.Label lblAvalible;
        private System.Windows.Forms.Label lblNotAvalible;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbAnimalFour;
        private System.Windows.Forms.ComboBox cmbAnimalThree;
        private System.Windows.Forms.ComboBox cmbAnimalTwo;
        private System.Windows.Forms.ComboBox cmbAnimalFive;
        private System.Windows.Forms.ComboBox cmbAnimalOne;
    }
}