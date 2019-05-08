using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BLL;

namespace FarmVille
{
    public partial class Login : Form
    {
        //List of farmers, later to cast into Person
        List<Farmer> farmers = new List<Farmer>();
        Farmer farmerTextLogin = new Farmer();
        //bool allowed = false;


        public Login()
        {
            InitializeComponent();
            farmers = farmerTextLogin.AllUsers();
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnklblAcccount2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNewAccount();
        }

        private void lnklblAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNewAccount();
        }

        public void CreateNewAccount()
        {
            this.Hide();
            Register frmReg = new Register();
            frmReg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            lblIncorrect.Hide();


            farmerTextLogin = new Farmer(txtUsername.Text, txtPassword.Text);

            var FarmerList = from farmersClass
                             in farmers
                             where farmersClass.UserUsername.Equals(txtUsername.Text)
                             select farmersClass;

            foreach (Farmer FarmerItem in FarmerList)
            {
                if (FarmerItem.Equals(farmerTextLogin))
                {
                    LogginSucc(farmerTextLogin);
                    return;
                }

            }
            LogginFail();

        }

        public void LogginSucc(Farmer farmer)
        {
            farmer = farmer.GetUserInformation();
            txtPassword.Clear();
            txtUsername.Clear();

            

            string mes = ("Welcome back " + farmer.UserName + "!");
            MessageBox.Show(mes);
            LoggedIn frmLog = new LoggedIn(farmer);
            this.Hide();
            frmLog.Show();


        }

        public void LogginFail()
        {
            lblIncorrect.Show();
            txtPassword.Clear();
            txtUsername.Clear();
            
            SoundPlayer incorrect = new SoundPlayer("Sounds/Incorrect.wav");
            incorrect.Play();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
