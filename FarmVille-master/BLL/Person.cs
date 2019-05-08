using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Person
    {
        #region Fields
        private int userID;
        private string userName;
        private string userSurname;
        private string gender;
        private DateTime birthDate;

        



        #endregion

        #region Constructor
        public Person(int userIDPrm = 1, string userNamePrm = "Micheal", string userSurnamePrm = "Knight", string genderPrm = "Male", string birthDatePrm = "17-06-1952")
        {
            this.UserID = userIDPrm;
            this.UserName = userNamePrm;
            this.UserSurname = userSurnamePrm;
            this.Gender = genderPrm;
            this.BirthDate = birthDatePrm.ToDateTime();
        }

        public Person(string userNamePrm, string userSurnamePrm, string genderPrm , string birthDatePrm)
        {
            
            this.UserName = userNamePrm;
            this.UserSurname = userSurnamePrm;
            this.Gender = genderPrm;
            this.BirthDate = birthDatePrm.ToDateTime();
        }
        public Person(string userNamePrm, string userSurnamePrm, string genderPrm)
        {

            this.UserName = userNamePrm;
            this.UserSurname = userSurnamePrm;
            this.Gender = genderPrm;
        }

        public Person(string userNamePrm = "Micheal", string userSurnamePrm = "Knight")
        {
           // this.UserID = userIDPrm;
            this.UserName = UserName;
            this.UserSurname = UserSurname;
        }

        public Person()
        {

        }
        #endregion

        #region Properties
        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserSurname { get => userSurname; set => userSurname = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        #endregion

        #region Override
        //public override bool EqualsUserName() { }
        #endregion

        #region Method

        #endregion





    }
}
