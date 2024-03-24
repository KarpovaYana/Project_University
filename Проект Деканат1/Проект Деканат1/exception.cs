using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Деканат1
{
    static public class exception
    {
        static int actualYear = 2024;
        public enum ExceptionType
        {
            ExceptionName, ExceptionBirth
        }


        static bool checkLengthDate(string str)
        {
            if (str.Length >= 10) return true;
            return false;
        }

        static bool checkPointsDate(string str)
        {
            char[] chars = str.ToCharArray();
            if (chars[2] == '.' && chars[5] == '.') return true;
            return false;
        }

        static bool IsLeap(int year)
        {
            return (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));
        }

        static bool checkDay(int day, int month, int year)
        {
            //finding max day of our month
            int maxDay = 0;
            int[] month31 = new int[] { 1, 3, 5, 7, 8, 10, 12 };      //monthes with max days = 31
            int[] month30 = new int[] { 4, 6, 9, 11 };       //monthes with max days = 30
            for (int i = 0; i < month31.Length; i++) if (month == month31[i]) maxDay = 31;
            for (int i = 0; i < month30.Length; i++) if (month == month30[i]) maxDay = 30;



            //check february
            if (month == 2)
            {
                if (IsLeap(year)) maxDay = 29;   //if year is leap then max days=29
                else maxDay = 28;
            }


            //if day is bigger than max days then DAY is incorrect
            if (day > maxDay) return false;
            else return true;
        }

        static bool checkCorrectnessDate(string str)
        {
            int day, month, year;

            //check is digit
            string STRday = str.Substring(0, 2), STRmonth = str.Substring(3, 2), STRyear = str.Substring(6);
            if (!(int.TryParse(STRday, out day)) ||
                !(int.TryParse(STRmonth, out month)) ||
                !(int.TryParse(STRyear, out year))) return false;
            //check correctness
            if (year <= 0 || year > actualYear) return false;
            if (month < 1 || month > 12) return false;
            if (day < 1 || !checkDay(day, month, year)) return false;
            return true;
        }

        static public string Exception(string str, ExceptionType x)
        {
            if (x == ExceptionType.ExceptionName)
            {
                foreach (var e in str)
                {
                    if (Char.IsDigit(e)) throw new ArgumentException();     //check if str has numbers
                }
            }

            if (x == ExceptionType.ExceptionBirth)
            {
                if (!checkLengthDate(str)) return "1";
                if (!checkPointsDate(str)) return "2";
                if (!checkCorrectnessDate(str)) return "3";
            }

            return str;
        }
    }
}
