using System;

namespace BLL
{
    public static class Extensions
    {
        #region SplitExtentions
        public static string SplitInfo(this string info, int chosenArrayPosition)
        {
            string[] lines = info.Split(Changebles.splitOn);
            return lines[chosenArrayPosition];

        }
        #endregion

        #region Conversions
        public static DateTime ToDateTime(this string dateTimeString)
        {
            // 31-01-2012

            string[] date = dateTimeString.Split('-');
            DateTime dateTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
            return dateTime;

        }

        public static DateTime ToDateTimeDTP(this string dateTimeString)
        {
            DateTime dateTime = new DateTime();
            string[] date = dateTimeString.Split(' ');
            if (date[2].Equals("January")) dateTime = new DateTime(int.Parse(date[3]), 1, int.Parse(date[1]));
            if (date[2].Equals("Febuary")) dateTime = new DateTime(int.Parse(date[3]), 2, int.Parse(date[1]));
            if (date[2].Equals("March")) dateTime = new DateTime(int.Parse(date[3]), 3, int.Parse(date[1]));

            if (date[2].Equals("April")) dateTime = new DateTime(int.Parse(date[3]), 4, int.Parse(date[1]));
            if (date[2].Equals("May")) dateTime = new DateTime(int.Parse(date[3]), 5, int.Parse(date[1]));
            if (date[2].Equals("June")) dateTime = new DateTime(int.Parse(date[3]), 6, int.Parse(date[1]));

            if (date[2].Equals("July")) dateTime = new DateTime(int.Parse(date[3]), 7, int.Parse(date[1]));
            if (date[2].Equals("August")) dateTime = new DateTime(int.Parse(date[3]), 8, int.Parse(date[1]));
            if (date[2].Equals("September")) dateTime = new DateTime(int.Parse(date[3]), 9, int.Parse(date[1]));

            if (date[2].Equals("November")) dateTime = new DateTime(int.Parse(date[3]), 10, int.Parse(date[1]));
            if (date[2].Equals("October")) dateTime = new DateTime(int.Parse(date[3]), 11, int.Parse(date[1]));
            if (date[2].Equals("December")) dateTime = new DateTime(int.Parse(date[3]), 12, int.Parse(date[1]));
            return dateTime;


        }

        public static string convertDateToStringDDMMYYYY(this DateTime dateTime)
        {
            string[] YYYYMMDD = dateTime.ToString().Split(' ');
            string[] arrayYYYYMMDD = YYYYMMDD[0].Split('/');

            string year = arrayYYYYMMDD[0];
            string month = arrayYYYYMMDD[1];
            string day = arrayYYYYMMDD[2];

            string newStringDate = string.Format($"{day}-{month}-{year}");
            return newStringDate;
        }

        public static string ToCharFile(this string dataToConvert)
        {
            string charToSave;
            string gender = null;
            string name = null;
            string shirt = null;

            //Gender
            if (dataToConvert.SplitInfo(0).Equals("Male")) gender = null;
            if (dataToConvert.SplitInfo(0).Equals("Female")) gender = "F";

            if (dataToConvert.SplitInfo(1).Equals("Ou Piet") || dataToConvert.SplitInfo(1).Equals("Ms Martha")) name = "1";
            if (dataToConvert.SplitInfo(1).Equals("Young John") || dataToConvert.SplitInfo(1).Equals("Bettie Boob")) name = "2";

            if (dataToConvert.SplitInfo(2).Equals("0")) shirt = "B";
            if (dataToConvert.SplitInfo(2).Equals("1")) shirt = "G";
            if (dataToConvert.SplitInfo(2).Equals("2")) shirt = "R";


            charToSave = string.Format("F" + name + "C" + shirt + gender);





            return charToSave;
        }

        public static string FromCharFile(this string dataToConvert)
        {

            string charToRetreive;
            char[] identifiers = dataToConvert.ToCharArray();
            string gender = null;
            string name = null;
            string shirt = null;
            string colour = null;

            if (dataToConvert.Length == 5)
            {
                gender = "Female";
                if (identifiers[1].Equals('1')) name = "Ms Martha";
                if (identifiers[1].Equals('2')) name = "Bettie Boob";
            }
            else
            {
                gender = "Male";
                if (identifiers[1].Equals('1')) name = "Ou Piet";
                if (identifiers[1].Equals('2')) name = "Young John";
            }

            if (identifiers[3].Equals('B')) { shirt = "0"; colour = " Blue"; }
            if (identifiers[3].Equals('G')) { shirt = "1"; colour = "Green"; }
            if (identifiers[3].Equals('R')) { shirt = "2"; colour = " Red"; }

            charToRetreive = string.Format(gender + Changebles.splitOn + name + Changebles.splitOn +
                shirt + Changebles.splitOn + colour);
            return charToRetreive;
        }
        #endregion

        #region MathExtentions
        public static int SwitchToPositive(this int number)
        {
            if (number < 0)
            {
                return number * -1;
            }
            return number;
        }

        public static bool TestForSpecialChars(this String testSpecials)
        {

            foreach (char stringLetter in testSpecials)
            {
                foreach (char invalids in Changebles.invalidChars)
                {
                    if (stringLetter == invalids) return true;
                }
            }

            return true;


        }
        #endregion








    }

}


/*
Lamda
Delegate
Threading
Sockets
Links
serialization binary XML ++ and theory
FileHander + DataHandler ++
Server 10 marks+
*/

