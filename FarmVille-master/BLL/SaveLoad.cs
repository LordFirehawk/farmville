using BLL;
using System;
using System.Collections.Generic;

namespace FarmVille
{
    public class SaveLoad
	{

        //FarmName
        //FarmMetaData

        //UserCloths
        //Farms size


        //Animal+Amount
        #region MainSave
        public void SaveThis(List<string> animals, Farm farm, Farmer farmer)
        {
            List<string> dataToSave = new List<string>();

            string fileDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + farmer.UserUsername + "#";
            string filePath = fileDirectory + farm.FarmName + "Save.txt";
            FileHandler saveData = new FileHandler(filePath);

            dataToSave.Add(farm.FarmName);
            dataToSave.Add(farm.Size.ToString());
            foreach (string a in animals)
            {
                dataToSave.Add(a);
            }

            saveData.WriteDataToTXT(dataToSave);

        }

        public List<string> LoadThis(string farmName, Farmer farmer)
        {


            string fileDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + farmer.UserUsername + "#";
            string filePath = fileDirectory + farmName + "Save.txt";
            FileHandler retriveData = new FileHandler(filePath);



            return retriveData.ReadDataFromTXT();

        }
        #endregion

        #region CharSave
        public void SaveThisChar(string save, Farmer farmer)
        {
            string fileDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + farmer.UserUsername + "#";
            string filePath = fileDirectory + farmer.UserUsername + "Save.txt";
            FileHandler saveData = new FileHandler(filePath);
            List<string> saveThisLine = new List<string> { save };
            saveData.WriteDataToTXT(saveThisLine);


        }

        public string LoadThisChar(Farmer farmer)
        {
            string fileDirectory =
            //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Farmville\\" + farmer.UserUsername + "\\";

            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + farmer.UserUsername + "#";
            string filePath = fileDirectory + farmer.UserUsername + "Save.txt";
            FileHandler readData = new FileHandler(filePath);

            List<string> dataReadFromSaveFile = readData.ReadDataFromTXT();

            string thisString = null;

            try
            {
                return dataReadFromSaveFile[0].ToString();
            }
            catch (ArgumentOutOfRangeException)
            {

                return thisString;
            }
        }
        #endregion








    }
}