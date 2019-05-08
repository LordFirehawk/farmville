using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BLL;

namespace FarmVille
{
    public partial class Create_Farm : Form
    {
        Farmer farmerWorkingWith;

        public Create_Farm(Farmer farmerRecieved)
        {
            
            InitializeComponent();

            farmerWorkingWith = farmerRecieved;

            cmbAnimalOne.Enabled = false;
            txtAnimalAmountOne.Enabled = false;

            cmbAnimalTwo.Enabled = false;
            txtAnimalAmountTwo.Enabled = false;

            cmbAnimalThree.Enabled = false;
            txtAnimalAmountThree.Enabled = false;

            cmbAnimalFour.Enabled = false;
            txtAnimalAmountFour.Enabled = false;

            cmbAnimalFive.Enabled = false;
            txtAnimalAmountFive.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            List<Animal> animalList = animal.GetAnimalsNameAndType();
            List<string> animalInfoList = new List<string>();

            List<string> animalOne   = new List<string>();
            List<string> animalTwo   = new List<string>();
            List<string> animalThree = new List<string>();
            List<string> animalFour  = new List<string>();
            List<string> animalFive  = new List<string>();

            foreach (Animal item in animalList)
            {
                if (item.AnimalType.Equals("Prey")) animalOne.Add(item.AnimalSpecies);
                if (item.AnimalType.Equals("Predator")) animalTwo.Add(item.AnimalSpecies);


                animalThree.Add(item.AnimalSpecies);
                animalFour.Add(item.AnimalSpecies);
                animalFive.Add(item.AnimalSpecies);
            }

            


            int a = Convert.ToInt32(cmbAmountOfAnimals.SelectedItem);
            switch(a)
            {
                case 2:
                    cmbAnimalOne.Enabled = true;
                    txtAnimalAmountOne.Enabled = true;
                    cmbAnimalOne.DataSource = animalOne;

                    cmbAnimalTwo.Enabled = true;
                    txtAnimalAmountTwo.Enabled = true;
                    cmbAnimalTwo.DataSource = animalTwo;

                    cmbAnimalThree.Enabled = false;
                    txtAnimalAmountThree.Enabled = false;

                    cmbAnimalFour.Enabled = false;
                    txtAnimalAmountFour.Enabled = false;

                    cmbAnimalFive.Enabled = false;
                    txtAnimalAmountFive.Enabled = false;

                    break;
                case 3:
                    cmbAnimalOne.Enabled = true;
                    txtAnimalAmountOne.Enabled = true;
                    cmbAnimalOne.DataSource = animalOne;

                    cmbAnimalTwo.Enabled = true;
                    txtAnimalAmountTwo.Enabled = true;
                    cmbAnimalTwo.DataSource = animalTwo;

                    cmbAnimalThree.Enabled = true;
                    txtAnimalAmountThree.Enabled = true;
                    cmbAnimalThree.DataSource = animalThree;

                    cmbAnimalFour.Enabled = false;
                    txtAnimalAmountFour.Enabled = false;

                    cmbAnimalFive.Enabled = false;
                    txtAnimalAmountFive.Enabled = false;
                    break;
                case 4:
                    cmbAnimalOne.Enabled = true;
                    txtAnimalAmountOne.Enabled = true;
                    cmbAnimalOne.DataSource = animalOne;

                    cmbAnimalTwo.Enabled = true;
                    txtAnimalAmountTwo.Enabled = true;
                    cmbAnimalTwo.DataSource = animalTwo;

                    cmbAnimalThree.Enabled = true;
                    txtAnimalAmountThree.Enabled = true;
                    cmbAnimalThree.DataSource = animalThree;

                    cmbAnimalFour.Enabled = true;
                    txtAnimalAmountFour.Enabled = true;
                    cmbAnimalFour.DataSource = animalFour;

                    cmbAnimalFive.Enabled = false;
                    txtAnimalAmountFive.Enabled = false;
                    break;
                case 5:
                    cmbAnimalOne.Enabled = true;
                    txtAnimalAmountOne.Enabled = true;
                    cmbAnimalOne.DataSource = animalOne;

                    cmbAnimalTwo.Enabled = true;
                    txtAnimalAmountTwo.Enabled = true;
                    cmbAnimalTwo.DataSource = animalTwo;

                    cmbAnimalThree.Enabled = true;
                    txtAnimalAmountThree.Enabled = true;
                    cmbAnimalThree.DataSource = animalThree;

                    cmbAnimalFour.Enabled = true;
                    txtAnimalAmountFour.Enabled = true;
                    cmbAnimalFour.DataSource = animalFour;

                    cmbAnimalFive.Enabled = true;
                    txtAnimalAmountFive.Enabled = true;
                    cmbAnimalFive.DataSource = animalFive;
                    break;
            }
            
            


        }

        private void Create_Farm_Load(object sender, EventArgs e)
        {

        }


        //Create Farm
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtFarmSize.Text == "" || txtFarmName.Text == "" || cmbAmountOfAnimals.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
            }
            
            else
            {
                bool shouldIRun = true;
                switch (int.Parse(cmbAmountOfAnimals.Text))
                {
                    case 2:
                        if (txtAnimalAmountOne.Text == "" || txtAnimalAmountTwo.Text == "") shouldIRun = false;
                        break;

                    case 3:
                        if (txtAnimalAmountOne.Text == "" || txtAnimalAmountTwo.Text == "" || txtAnimalAmountThree.Text == "") shouldIRun = false;
                        break;

                    case 4:
                        if (txtAnimalAmountOne.Text == "" || txtAnimalAmountTwo.Text == "" || txtAnimalAmountThree.Text == ""
                                || txtAnimalAmountFour.Text == "") shouldIRun = false;
                        break;

                    case 5:
                        if (txtAnimalAmountOne.Text == "" || txtAnimalAmountTwo.Text == "" || txtAnimalAmountThree.Text == ""
                                || txtAnimalAmountFour.Text == "" || txtAnimalAmountFive.Text == "") shouldIRun = false;
                        break;
                    default:

                        break;
                }
                if(shouldIRun)
                {
                    List<string> dataToSave = new List<string>();

                    Farm farmToSave = new Farm(txtFarmName.Text, int.Parse(txtFarmSize.Text));

                    //dataToSave.Add(txtFarmName.Text + Changebles.splitOn + txtFarmSize.Text);
                    SaveLoad save = new SaveLoad();
                    dataToSave.Add(cmbAmountOfAnimals.Text);
                    switch (int.Parse(cmbAmountOfAnimals.Text))
                    {
                        case 2:

                            dataToSave.Add(cmbAnimalOne.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountOne.Text);
                            dataToSave.Add(cmbAnimalTwo.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountTwo.Text);

                            break;

                        case 3:
                            dataToSave.Add(cmbAnimalOne.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountOne.Text);
                            dataToSave.Add(cmbAnimalTwo.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountTwo.Text);
                            dataToSave.Add(cmbAnimalThree.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountThree.Text);
                            break;

                        case 4:
                            dataToSave.Add(cmbAnimalOne.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountOne.Text);
                            dataToSave.Add(cmbAnimalTwo.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountTwo.Text);
                            dataToSave.Add(cmbAnimalThree.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountThree.Text);
                            dataToSave.Add(cmbAnimalFour.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountFour.Text);
                            break;

                        case 5:
                            dataToSave.Add(cmbAnimalOne.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountOne.Text);
                            dataToSave.Add(cmbAnimalTwo.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountTwo.Text);
                            dataToSave.Add(cmbAnimalThree.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountThree.Text);
                            dataToSave.Add(cmbAnimalFour.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountFour.Text);
                            dataToSave.Add(cmbAnimalFive.Text.SplitInfo(0) + Changebles.splitOn + txtAnimalAmountFive.Text);
                            break;

                        default:
                            break;
                    }
                    save.SaveThis(dataToSave, farmToSave, farmerWorkingWith);
                    farmToSave.InsertFarm(farmerWorkingWith.UserUsername.ToString());

                    LoggedIn frmLogged = new LoggedIn(farmerWorkingWith);
                    frmLogged.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill in all fields!");
                }
                
            }
            
        }

        private void btnCheckAvability_Click(object sender, EventArgs e)
        {
            List<Farm> farms = new List<Farm>();
            Farm farm = new Farm();
            //farms = farm.GetAllFarmers();
            var farmTest = from farmList
                             in farms
                             where farm.FarmName.Equals(txtFarmName.Text.ToString())
                             select farmList;
            if (farmTest != null) NameAvalible();
            if (farmTest == null) NotNameAvalible();
            if (txtFarmName == null) NotNameAvalible();
        }

        private void NameAvalible()
        {
            lblNotAvalible.Visible = false;
            lblAvalible.Visible = true;
        }

        private void NotNameAvalible()
        {
            lblNotAvalible.Visible = true;
            lblAvalible.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoggedIn frmLog = new LoggedIn(farmerWorkingWith);
            frmLog.Show();
            this.Close();
        }

        private void cmbAnimalOne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
