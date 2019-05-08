using DAL;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class Farm
    {
        #region Fields
        private string farmName;
        private int size;
        #endregion

        #region Constructor
        public Farm(string farmNamePrm, int sizePrm)
        {
            this.FarmName = farmNamePrm;
            this.Size = sizePrm;
        }
        public Farm(string farmNamePrm)
        {
            this.FarmName = farmNamePrm;
        }
        public Farm()
        {

        }
        #endregion

        #region Properties
        
        public string FarmName { get => farmName; set => farmName = value; }
        public int Size { get => size; set => size = value; }
        #endregion

        #region override
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
            return this.FarmName;
        }
        #endregion

        #region methods
        public void InsertFarm(string UserName)
        {
            ArrayList userParams = new ArrayList();

            userParams.Add(this.FarmName);
            userParams.Add(this.Size);
            userParams.Add(UserName);

            Datahandler handler = new Datahandler();
            handler.InsertFarm(userParams);
        }
        public List<Farm> GetUserFarms(string userName)
        {
            List<Farm> dataList = new List<Farm>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.GetUserFarms(userName);

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(new Farm(dataItem["FarmName"].ToString()));
            }

            return dataList;
        }
        public List<Farm> GetUserFarmSize(string farmName)
        {
            this.FarmName = farmName;
            List<Farm> dataList = new List<Farm>();
            Datahandler handler = new Datahandler();
            DataTable dataRaw = handler.GetUserFarmSize(FarmName);

            foreach (DataRow dataItem in dataRaw.Rows)
            {
                dataList.Add(new Farm(dataItem["FarmSize"].ToString()));
            }

            return dataList;
        }
        #endregion

    }
}
