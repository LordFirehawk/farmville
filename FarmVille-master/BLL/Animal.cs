using DAL;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class Animal
    {
        #region Fields
        private int animalID;
        private string animalSpecies;
        private string animalType;
        private int animalSize;
        private int animalLifespan;
        private int animalBreedingRate;
        #endregion

        #region Constructor
        public Animal()
        {

        }
        public Animal(int animalIDPrm, string animalSpeciesPrm, string animalTypePrm, int animalSizePrm,  int animalLifespanPrm, int animalBreedingRatePrm)
        {
            this.AnimalID = animalIDPrm;
            this.AnimalSpecies = animalSpeciesPrm;
            this.AnimalType = animalTypePrm;
            this.AnimalSize = animalSizePrm;
            this.AnimalLifespan = animalLifespanPrm;
            this.AnimalBreedingRate = animalBreedingRatePrm;
        }
        public Animal(string animalSpeciesPrm, string animalTypePrm, int animalSizePrm, int animalLifespanPrm, int animalBreedingRatePrm)
        {
            this.AnimalSpecies = animalSpeciesPrm;
            this.AnimalType = animalTypePrm;
            this.AnimalSize = animalSizePrm;
            this.AnimalLifespan = animalLifespanPrm;
            this.AnimalBreedingRate = animalBreedingRatePrm;
        }
        public Animal(string animalSpeciesPrm, string animalTypePrm)
        {
            this.AnimalSpecies = animalSpeciesPrm;
            this.AnimalType = animalTypePrm;
        }
        #endregion

        #region Properties

        public int AnimalID1 { get => animalID; set => animalID = value; }
        public string AnimalSpecies { get => animalSpecies; set => animalSpecies = value; }
        public string AnimalType { get => animalType; set => animalType = value; }
        public int AnimalSize { get => animalSize; set => animalSize = value; }
        public int AnimalLifespan { get => animalLifespan; set => animalLifespan = value; }
        public int AnimalBreedingRate { get => animalBreedingRate; set => animalBreedingRate = value; }
        


        public int AnimalID
        {
            get { return AnimalID1; }
            set { AnimalID1 = value; }
        }

        
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return this.AnimalID+","+this.AnimalSpecies+","+this.AnimalType+","+this.AnimalSize+","+this.AnimalLifespan+","+this.AnimalBreedingRate;
        }
        #endregion

        #region Methods
        public List<Animal> GetAnimalsNameAndType()
        {
            List<Animal> dataList = new List<Animal>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.GetAnimalsNameAndType();

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(new Animal(dataItem["AnimalSpecies"].ToString(),dataItem["AnimalType"].ToString()));
            }

            return dataList;
        }

        public List<Animal> GetAnimalInfo()
        {
            List<Animal> dataList = new List<Animal>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.GetAnimalInfo(AnimalID1);
            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(new Animal(dataItem["AnimalSpecies"].ToString(), 
                                        dataItem["AnimalType"].ToString(),
                                        int.Parse(dataItem["AnimalSize"].ToString()),
                                        int.Parse(dataItem["AnimalLifespan"].ToString()),
                                        int.Parse(dataItem["AnimalPregnancyTime"].ToString())));
                //hey
            }
            return dataList;
        }
        #endregion

        //WonderWorld
        //Another one added
        //hello

    }
}
