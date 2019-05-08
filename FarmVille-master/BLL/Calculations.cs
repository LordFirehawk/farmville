using System;
using System.Collections.Generic;


namespace BLL
{
    #region Exstra Math
    public partial class Calculations
    {
       public string CreateGender()
        {
            Random randomGen = new Random();
            if (randomGen.Next(2)==0) return "Female";
            return "Male";
            
        }
        public string CreateDateOfBirth()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.convertDateToStringDDMMYYYY();
        }
    }
    #endregion

    #region Algorithm
    public partial class Calculations
    {
       public List<string> CreateTheFarm(List<string> farmInfoList)
        {
            //   Farm Name   //
            //User Cloths
            //Farm Size
            //Amount of Animals
            //AnimalNameOne/Amount
            //AnimalNameTwo/Amount
            //AnimalNameThree/Amount
            //AnimalNameFour/Amount
            //AnimalNameFive/Amount

            Animal animal = new Animal();
            List<Animal> animalList = animal.GetAnimalInfo();
            List<string> coOrdinateList = new List<string>();

            int currentAnimalSizeCage = 0;
            bool notSpace = true;
            int AnimalSize;
            int amount;
            string predatorORfood;
            string animalInfo=null;
            int tempX, tempY;

            int takenX, takenY, takenSize;


            int farmSize = int.Parse(farmInfoList[1]);
            int amountOfAnimals = int.Parse(farmInfoList[2]);
            int feedingGroundSize = Convert.ToInt32(Math.Round(farmSize*0.3));
            tempX = (farmSize / 2 - (feedingGroundSize/2));
            tempY = (farmSize / 2 - (feedingGroundSize/2));

            string FeedingGroundCoOrdinates = "FeedingGround"+","+tempX+","+tempY+","+feedingGroundSize+","+"Other";
            // Name,X,Y,Size,Type
            coOrdinateList.Add(FeedingGroundCoOrdinates);

            switch (amountOfAnimals)
            {
                case 2:
                    {
                        for (int animalListNumber = 3; animalListNumber <= amountOfAnimals + 2; animalListNumber++)
                        {
                            foreach (Animal item in animalList)
                            {                      //SplitInfo is a ExtentionClass
                                if (farmInfoList[animalListNumber].SplitInfo(0) == item.AnimalSpecies)
                                {
                                    animalInfo = item.ToString();
                                }
                            }
                            predatorORfood = animalInfo.SplitInfo(2);
                            currentAnimalSizeCage = int.Parse(animalInfo.SplitInfo(3)) * 10;

                            if (predatorORfood == "Predator")
                            {
                                tempX = farmSize - currentAnimalSizeCage;
                                tempY = farmSize - currentAnimalSizeCage;
                                amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                string tempCoOrdinates = null;
                                int forLoopCounterCounter = 1;
                                AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                int counter = amount / 10;

                                if (amount % 10 == 0)
                                {
                                    forLoopCounterCounter = 0;
                                    counter--;
                                }


                                for (int i = (amount / 10) + forLoopCounterCounter; i > 0; i--)
                                {


                                    int tempSize;
                                    if (i == 1)
                                    {
                                        tempSize = (amount - counter * 10) * AnimalSize;
                                    }
                                    else
                                    {
                                        tempSize = 10 * AnimalSize;
                                    }


                                    foreach (string coOrdinateItem in coOrdinateList)
                                    {
                                        string[] lines = coOrdinateItem.Split(',');
                                        takenX = int.Parse(lines[1]);
                                        takenY = int.Parse(lines[2]);
                                        takenSize = int.Parse(lines[3]);
                                        if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize))
                                                                                                      || // OR
                                           ((tempX + currentAnimalSizeCage >= takenX) && (tempX <= takenX + takenSize)) && ((tempY + currentAnimalSizeCage >= takenY) && (tempY <= takenY + takenSize)))
                                        {
                                            tempY = takenY - takenSize - 1;
                                            if (tempY - currentAnimalSizeCage < 0)
                                            {
                                                tempY = farmSize - currentAnimalSizeCage;
                                                tempX = takenX - 1 - takenSize;

                                                if (tempX - currentAnimalSizeCage <= 0)
                                                {
                                                    //There is no space
                                                    //Simulation failed
                                                }
                                                else
                                                {
                                                    // Animal Species                                 // Type Prey or Predator
                                                    tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                }
                                            }
                                            else
                                            {
                                                // Animal Species                                 // Type Prey or Predator
                                                tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                            }
                                        }
                                        else
                                        {                                                          // Animal Species                                 // Type Prey or Predator
                                            tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                        }

                                    }
                                    coOrdinateList.Add(tempCoOrdinates);
                                }
                            }// Predator
                            else
                            {
                                if (predatorORfood == "Prey")
                                {
                                    tempX = 0;
                                    tempY = 0;
                                    amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                    string tempCoOrdinates = null;
                                    int forLoopCounterCounter = 1;
                                    AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                    int counter = amount / 10;

                                    if (amount % 10 == 0)
                                    {
                                        forLoopCounterCounter = 0;
                                        counter--;
                                    }


                                    for (int i = (amount / 10) + forLoopCounterCounter; i > 0; i--)
                                    {


                                        int tempSize;
                                        if (i == 1)
                                        {
                                            tempSize = (amount - counter * 10) * AnimalSize;
                                        }
                                        else
                                        {
                                            tempSize = 10 * AnimalSize;
                                        }


                                        foreach (string coOrdinateItem in coOrdinateList)
                                        {
                                            string[] lines = coOrdinateItem.Split(',');
                                            takenX = int.Parse(lines[1]);
                                            takenY = int.Parse(lines[2]);
                                            takenSize = int.Parse(lines[3]);
                                            if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize))
                                                                                                  || // OR
                                            ((tempX + currentAnimalSizeCage >= takenX) && (tempX <= takenX + takenSize)) && ((tempY + currentAnimalSizeCage >= takenY) && (tempY <= takenY + takenSize)))
                                            {
                                                tempY = takenY + takenSize + 1;
                                                if (tempY + currentAnimalSizeCage > farmSize)
                                                {
                                                    tempY = 0;
                                                    tempX = takenX + 10 + takenSize;

                                                    if (tempX + currentAnimalSizeCage >= farmSize)
                                                    {
                                                        //There is no space
                                                        //Simulation failed
                                                    }
                                                    else
                                                    {
                                                        // Animal Species                                 // Type Prey or Predator
                                                        tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                    }
                                                }
                                                else
                                                {
                                                    // Animal Species                                 // Type Prey or Predator
                                                    tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                }
                                            }
                                            else
                                            {                                                          // Animal Species                                 // Type Prey or Predator
                                                tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                            }

                                        }
                                        coOrdinateList.Add(tempCoOrdinates);
                                        tempY++;

                                    }


                                }// Prey IF

                            }
                        }
                    }
                    break;
                case 3:
                    {
                        for (int animalListNumber = 3; animalListNumber <= amountOfAnimals + 2; animalListNumber++)
                        {
                            foreach (Animal item in animalList)
                            {                      //SplitInfo is a ExtentionClass
                                if (farmInfoList[animalListNumber].SplitInfo(0) == item.AnimalSpecies)
                                {
                                    animalInfo = item.ToString();
                                }
                            }
                            predatorORfood = animalInfo.SplitInfo(2);
                            currentAnimalSizeCage = int.Parse(animalInfo.SplitInfo(3)) * 10;

                            if (predatorORfood == "Predator")
                            {
                                tempX = farmSize - currentAnimalSizeCage;
                                tempY = farmSize - currentAnimalSizeCage;
                                amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                string tempCoOrdinates = null;
                                int forLoopCounterCounter = 1;
                                AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                int counter = amount / 10;

                                if (amount % 10 == 0)
                                {
                                    forLoopCounterCounter = 0;
                                    counter--;
                                }


                                for (int i = (amount / 10) + forLoopCounterCounter; i > 0; i--)
                                {


                                    int tempSize;
                                    if (i == 1)
                                    {
                                        tempSize = (amount - counter * 10) * AnimalSize;
                                    }
                                    else
                                    {
                                        tempSize = 10 * AnimalSize;
                                    }


                                    foreach (string coOrdinateItem in coOrdinateList)
                                    {
                                        string[] lines = coOrdinateItem.Split(',');
                                        takenX = int.Parse(lines[1]);
                                        takenY = int.Parse(lines[2]);
                                        takenSize = int.Parse(lines[3]);
                                        if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize))
                                                                                                      || // OR
                                           ((tempX + currentAnimalSizeCage >= takenX) && (tempX <= takenX + takenSize)) && ((tempY + currentAnimalSizeCage >= takenY) && (tempY <= takenY + takenSize)))
                                        {
                                            tempY = takenY - takenSize - 1;
                                            if (tempY - currentAnimalSizeCage < 0)
                                            {
                                                tempY = farmSize - currentAnimalSizeCage;
                                                tempX = takenX - 1 - takenSize;

                                                if (tempX - currentAnimalSizeCage <= 0)
                                                {
                                                    //There is no space
                                                    //Simulation failed
                                                }
                                                else
                                                {
                                                    // Animal Species                                 // Type Prey or Predator
                                                    tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                }
                                            }
                                            else
                                            {
                                                // Animal Species                                 // Type Prey or Predator
                                                tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                            }
                                        }
                                        else
                                        {                                                          // Animal Species                                 // Type Prey or Predator
                                            tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                        }

                                    }
                                    coOrdinateList.Add(tempCoOrdinates);
                                }
                            }// Predator
                            else
                            {
                                if (predatorORfood == "Prey")
                                {
                                    tempX = 0;
                                    tempY = 0;
                                    amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                    string tempCoOrdinates = null;
                                    int forLoopCounterCounter = 1;
                                    AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                    int counter = amount / 10;

                                    if (amount % 10 == 0)
                                    {
                                        forLoopCounterCounter = 0;
                                        counter--;
                                    }


                                    for (int i = (amount / 10) + forLoopCounterCounter; i > 0; i--)
                                    {


                                        int tempSize;
                                        if (i == 1)
                                        {
                                            tempSize = (amount - counter * 10) * AnimalSize;
                                        }
                                        else
                                        {
                                            tempSize = 10 * AnimalSize;
                                        }


                                        foreach (string coOrdinateItem in coOrdinateList)
                                        {
                                            string[] lines = coOrdinateItem.Split(',');
                                            takenX = int.Parse(lines[1]);
                                            takenY = int.Parse(lines[2]);
                                            takenSize = int.Parse(lines[3]);
                                            if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize))
                                                                                                  || // OR
                                            ((tempX + currentAnimalSizeCage >= takenX) && (tempX <= takenX + takenSize)) && ((tempY + currentAnimalSizeCage >= takenY) && (tempY <= takenY + takenSize)))
                                            {
                                                tempY = takenY + takenSize + 1;
                                                if (tempY + currentAnimalSizeCage > farmSize)
                                                {
                                                    tempY = 0;
                                                    tempX = takenX + 10 + takenSize;

                                                    if (tempX + currentAnimalSizeCage >= farmSize)
                                                    {
                                                        //There is no space
                                                        //Simulation failed
                                                    }
                                                    else
                                                    {
                                                        // Animal Species                                 // Type Prey or Predator
                                                        tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                    }
                                                }
                                                else
                                                {
                                                    // Animal Species                                 // Type Prey or Predator
                                                    tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                }
                                            }
                                            else
                                            {                                                          // Animal Species                                 // Type Prey or Predator
                                                tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                            }

                                        }
                                        coOrdinateList.Add(tempCoOrdinates);
                                        tempY++;

                                    }


                                }// Prey IF

                            }
                        }
                    }
                    break;
                case 4:
                    {
                        for (int animalListNumber = 3; animalListNumber <= amountOfAnimals + 2; animalListNumber++)
                        {
                            foreach (Animal item in animalList)
                            {                      //SplitInfo is a ExtentionClass
                                if (farmInfoList[animalListNumber].SplitInfo(0) == item.AnimalSpecies)
                                {
                                    animalInfo = item.ToString();
                                }
                            }
                            predatorORfood = animalInfo.SplitInfo(2);
                            currentAnimalSizeCage = int.Parse(animalInfo.SplitInfo(3)) * 10;

                            if (predatorORfood == "Predator")
                            {
                                tempX = farmSize - currentAnimalSizeCage;
                                tempY = farmSize - currentAnimalSizeCage;
                                amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                string tempCoOrdinates = null;
                                int forLoopCounterCounter = 1;
                                AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                int counter = amount / 10;

                                if (amount % 10 == 0)
                                {
                                    forLoopCounterCounter = 0;
                                    counter--;
                                }


                                for (int i = (amount / 10) + forLoopCounterCounter; i > 0; i--)
                                {


                                    int tempSize;
                                    if (i == 1)
                                    {
                                        tempSize = (amount - counter * 10) * AnimalSize;
                                    }
                                    else
                                    {
                                        tempSize = 10 * AnimalSize;
                                    }


                                    foreach (string coOrdinateItem in coOrdinateList)
                                    {
                                        string[] lines = coOrdinateItem.Split(',');
                                        takenX = int.Parse(lines[1]);
                                        takenY = int.Parse(lines[2]);
                                        takenSize = int.Parse(lines[3]);
                                        if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize))
                                                                                                      || // OR
                                           ((tempX + currentAnimalSizeCage >= takenX) && (tempX <= takenX + takenSize)) && ((tempY + currentAnimalSizeCage >= takenY) && (tempY <= takenY + takenSize)))
                                        {
                                            tempY = takenY - takenSize - 1;
                                            if (tempY - currentAnimalSizeCage < 0)
                                            {
                                                tempY = farmSize - currentAnimalSizeCage;
                                                tempX = takenX - 1 - takenSize;

                                                if (tempX - currentAnimalSizeCage <= 0)
                                                {
                                                    //There is no space
                                                    //Simulation failed
                                                }
                                                else
                                                {
                                                    // Animal Species                                 // Type Prey or Predator
                                                    tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                }
                                            }
                                            else
                                            {
                                                // Animal Species                                 // Type Prey or Predator
                                                tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                            }
                                        }
                                        else
                                        {                                                          // Animal Species                                 // Type Prey or Predator
                                            tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                        }

                                    }
                                    coOrdinateList.Add(tempCoOrdinates);
                                }
                            }// Predator
                            else
                            {
                                if (predatorORfood == "Prey")
                                {
                                    tempX = 0;
                                    tempY = 0;
                                    amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                    string tempCoOrdinates = null;
                                    int forLoopCounterCounter = 1;
                                    AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                    int counter = amount / 10;

                                    if (amount % 10 == 0)
                                    {
                                        forLoopCounterCounter = 0;
                                        counter--;
                                    }


                                    for (int i = (amount / 10) + forLoopCounterCounter; i > 0; i--)
                                    {


                                        int tempSize;
                                        if (i == 1)
                                        {
                                            tempSize = (amount - counter * 10) * AnimalSize;
                                        }
                                        else
                                        {
                                            tempSize = 10 * AnimalSize;
                                        }


                                        foreach (string coOrdinateItem in coOrdinateList)
                                        {
                                            string[] lines = coOrdinateItem.Split(',');
                                            takenX = int.Parse(lines[1]);
                                            takenY = int.Parse(lines[2]);
                                            takenSize = int.Parse(lines[3]);
                                            if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize))
                                                                                                  || // OR
                                            ((tempX + currentAnimalSizeCage >= takenX) && (tempX <= takenX + takenSize)) && ((tempY + currentAnimalSizeCage >= takenY) && (tempY <= takenY + takenSize)))
                                            {
                                                tempY = takenY + takenSize + 1;
                                                if (tempY + currentAnimalSizeCage > farmSize)
                                                {
                                                    tempY = 0;
                                                    tempX = takenX + 10 + takenSize;

                                                    if (tempX + currentAnimalSizeCage >= farmSize)
                                                    {
                                                        //There is no space
                                                        //Simulation failed
                                                    }
                                                    else
                                                    {
                                                        // Animal Species                                 // Type Prey or Predator
                                                        tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                    }
                                                }
                                                else
                                                {
                                                    // Animal Species                                 // Type Prey or Predator
                                                    tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                }
                                            }
                                            else
                                            {                                                          // Animal Species                                 // Type Prey or Predator
                                                tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                            }

                                        }
                                        coOrdinateList.Add(tempCoOrdinates);
                                        tempY++;

                                    }


                                }// Prey IF

                            }
                        }
                    } break;
                case 5:
                    {
                        for (int animalListNumber = 3; animalListNumber <= amountOfAnimals+2; animalListNumber++)
                        {
                            foreach (Animal item in animalList)
                            {                      //SplitInfo is a ExtentionClass
                                if (farmInfoList[animalListNumber].SplitInfo(0) == item.AnimalSpecies)
                                {
                                    animalInfo = item.ToString();
                                }
                            }
                            predatorORfood = animalInfo.SplitInfo(2);
                            currentAnimalSizeCage = int.Parse(animalInfo.SplitInfo(3)) * 10;

                            if (predatorORfood == "Predator")
                            {
                                tempX = farmSize - currentAnimalSizeCage ;
                                tempY = farmSize - currentAnimalSizeCage ;
                                amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                string tempCoOrdinates = null;
                                int forLoopCounterCounter = 1;
                                AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                int counter = amount / 10;

                                if (amount % 10 == 0)
                                {
                                    forLoopCounterCounter = 0;
                                    counter--;
                                }
                                

                                for (int i = (amount / 10) + forLoopCounterCounter; i > 0; i--)
                                {


                                    int tempSize;
                                    if (i == 1)
                                    {
                                        tempSize = (amount - counter*10) * AnimalSize;
                                    }
                                    else
                                    {
                                        tempSize = 10 * AnimalSize;
                                    }


                                    foreach (string coOrdinateItem in coOrdinateList)
                                    {
                                        string[] lines = coOrdinateItem.Split(',');
                                        takenX = int.Parse(lines[1]);
                                        takenY = int.Parse(lines[2]);
                                        takenSize = int.Parse(lines[3]);
                                        if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize))
                                                                                                      || // OR
                                           ((tempX + currentAnimalSizeCage >= takenX) && (tempX <= takenX + takenSize)) && ((tempY + currentAnimalSizeCage >= takenY) && (tempY  <= takenY + takenSize)))
                                        {
                                            tempY = takenY - takenSize - 1;
                                            if (tempY - currentAnimalSizeCage < 0)
                                            {
                                                tempY = farmSize - currentAnimalSizeCage;
                                                tempX = takenX - 1 - takenSize;

                                                if (tempX - currentAnimalSizeCage <= 0)
                                                {
                                                    //There is no space
                                                    //Simulation failed
                                                }
                                                else
                                                {
                                                    // Animal Species                                 // Type Prey or Predator
                                                    tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                }
                                            }
                                            else
                                            {
                                                // Animal Species                                 // Type Prey or Predator
                                                tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                            }
                                        }
                                        else
                                        {                                                          // Animal Species                                 // Type Prey or Predator
                                            tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                        }

                                    }
                                    coOrdinateList.Add(tempCoOrdinates);
                                }
                            }// Predator
                            else
                            {
                               if (predatorORfood == "Prey")
                                {
                                    tempX = 0;
                                    tempY = 0;
                                    amount = int.Parse(farmInfoList[animalListNumber].SplitInfo(1));
                                    string tempCoOrdinates = null;
                                    int forLoopCounterCounter = 1;
                                    AnimalSize = int.Parse(animalInfo.SplitInfo(3));
                                    int counter = amount / 10;

                                    if (amount % 10 == 0)
                                    {
                                        forLoopCounterCounter = 0;
                                        counter--;
                                    }
                                   

                                    for (int i = (amount / 10)+forLoopCounterCounter ; i > 0; i--)
                                    {
                                        
                                            
                                            int tempSize ;
                                            if (i == 1)
                                            {
                                                 tempSize = (amount - counter*10) * AnimalSize;
                                            }
                                            else
                                            {
                                                 tempSize = 10 * AnimalSize;
                                            }
                                             

                                            foreach (string coOrdinateItem in coOrdinateList)
                                            {
                                                string[] lines = coOrdinateItem.Split(',');
                                                takenX = int.Parse(lines[1]);
                                                takenY = int.Parse(lines[2]);
                                                takenSize = int.Parse(lines[3]);
                                                if (((tempX >= takenX) && (tempX <= takenX + takenSize)) && ((tempY >= takenY) && (tempY <= takenY + takenSize)) 
                                                                                                      || // OR
                                                ((tempX+currentAnimalSizeCage >= takenX) && (tempX <= takenX + takenSize)) && ((tempY+currentAnimalSizeCage >= takenY) && (tempY <= takenY + takenSize)))
                                                {
                                                    tempY = takenY + takenSize + 1;
                                                    if (tempY + currentAnimalSizeCage > farmSize)
                                                    {
                                                        tempY = 0;
                                                        tempX = takenX + 10 + takenSize;

                                                        if (tempX + currentAnimalSizeCage >= farmSize)
                                                        {
                                                            //There is no space
                                                            //Simulation failed
                                                        }
                                                        else
                                                        {
                                                                                                                    // Animal Species                                 // Type Prey or Predator
                                                            tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                        }
                                                    }
                                                    else
                                                    {
                                                                                                                // Animal Species                                 // Type Prey or Predator
                                                        tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                    }
                                                }
                                                else
                                                {                                                          // Animal Species                                 // Type Prey or Predator
                                                    tempCoOrdinates = string.Format("{0},{1},{2},{3},{4}", animalInfo.SplitInfo(1), tempX, tempY, tempSize, animalInfo.SplitInfo(2));
                                                }

                                            }
                                        coOrdinateList.Add(tempCoOrdinates);
                                        tempY++;

                                    }
                                   
                                    
                                }// Prey IF
                               
                            }
                        }
                    }
                    break;
                default:
                    { }
                    break;
            }
            return coOrdinateList;
        }

        public void HandleNewAnimals(List<string> farmInfoList, string farmName)
        {

            int amountOfAnimals = int.Parse(farmInfoList[2]);
            switch (amountOfAnimals)
            {
                case 3:
                    {
                        for (int counter = amountOfAnimals; counter <= amountOfAnimals+2; counter++)
                        {
                            for (int i = 0; i <= int.Parse(farmInfoList[counter].SplitInfo(1)); i++)
                            {
                                UserFarm userFarm = new UserFarm(farmName, CreateGender(), CreateDateOfBirth());
                                userFarm.InsertFarmAnimal(farmInfoList[counter].SplitInfo(0));
                            }
                        }
                       
                    } break;
                case 4:
                    {
                        for (int counter = amountOfAnimals; counter <= amountOfAnimals + 2; counter++)
                        {
                            for (int i = 0; i <= int.Parse(farmInfoList[counter].SplitInfo(1)); i++)
                            {
                                UserFarm userFarm = new UserFarm(farmName, CreateGender(), CreateDateOfBirth());
                                userFarm.InsertFarmAnimal(farmInfoList[counter].SplitInfo(0));
                            }
                        }
                    } break;
                case 5:
                    {
                        for (int counter = amountOfAnimals; counter <= amountOfAnimals + 2; counter++)
                        {
                            for (int i = 0; i <= int.Parse(farmInfoList[counter].SplitInfo(1)); i++)
                            {
                                UserFarm userFarm = new UserFarm(farmName, CreateGender(), CreateDateOfBirth());
                                userFarm.InsertFarmAnimal(farmInfoList[counter].SplitInfo(0));
                            }
                        }
                    } break;
                default:
                    break;
            }
            

        }

        public List<string> FeedingTimeTable()
        {
            List<string> theList = new List<string>();
            return theList;
        }
        
    }
    #endregion
}
