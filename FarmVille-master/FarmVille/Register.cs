using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace FarmVille
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }
        Farmer farmerHandler = new Farmer();
        List<Farmer> farmers = new List<Farmer>();



        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblUsernameNoMatch.Visible = false;
            lblPasswordNoMatch.Visible = false;

            farmers = farmerHandler.GetUsernames();


            bool invalid = false;
            bool taken = false;
            bool match = false;

            if (txtUsername.Text != txtUsernameConfirm.Text)
            {
                lblUsernameNoMatch.Visible = true;
                match = true;
            }
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                lblPasswordNoMatch.Visible = true;
                match = true;

            }

            foreach (Farmer farmerItem in farmers)
            {
                if (farmerItem.UserUsername.Equals(txtUsername.Text)) taken = true;
            }
            if (taken == true) MessageBox.Show("Username Invalid!!!");


            if (!txtUsername.Text.TestForSpecialChars() || !txtPassword.Text.TestForSpecialChars()) { invalid = true; string a = string.Format(@"(Username and password can't contain speciacl characters
Like" + "  \"/\" \"\\\" \"?\" \"!\" \"<\" \">\" "); MessageBox.Show(a); };
            if (taken == false && invalid == false && match == false) { CreateAccount(); };




            //            if ( == true)




        }

        public void CreateAccount()
        {
            DateTime birthDate = dtpBrithDate.Text.ToDateTimeDTP();
            Farmer farmer = new Farmer(txtPassword.Text, txtUsername.Text, txtName.Text, txtSurname.Text, cmbGender.Text, birthDate.convertDateToStringDDMMYYYY());
            farmer.InsertUser();
            MessageBox.Show($"Welcome {farmer.UserName}!!!\nYou are now a Farmer!!!");
            CharCreaterFirst charForm = new CharCreaterFirst(farmer, false);
            charForm.Show();
            this.Close();

        }
    }
}
