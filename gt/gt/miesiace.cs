using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt
{
    public class Miesiace
    {
        //abba radar 
        public char GetCharacter(string candidate, int position)
        {
            // candidate = Tomek position = 0 => 

            if (position > candidate.Length - 1) //6  Tomek length = 5
            {
                //
                return char.MinValue;
            }
            else
            {
                return candidate[position];
            }
        }

        public string GetMonth(string pesel)
        {
            //8406318213435
            string month = pesel.Substring(2, 2); //02 03
            string day = pesel.Substring(4, 2);
            int dayN = 0;
            int.TryParse(day, out dayN);
            Console.WriteLine(month);

            string monthText = string.Empty;

            if (month == "04" || month == "06" || month == "09" || month == "11")
            {
                if (dayN < 1 || dayN > 30)
                {
                    Console.WriteLine("Date invalid");
                }
            }

            if (month == "01" || month == "03" || month == "05" || month == "07" || month == "08" || month == "10" || month == "12")
            {
                if (dayN < 1 || dayN > 31)
                {
                    Console.WriteLine("Date invalid");
                }
            }

            //02?

            // ??
            if (month == "04")
            {
                monthText = "kwiecień";
            }

            if (month == "05")
            { 
                monthText = "maj"; 
            }

            if (month== "06")
            {
                monthText = "czerwiec";
            }
            if (month =="08")
            {
                monthText = "sierpień";
            }
            if (month == "09")
            { monthText = "wrzesień"; }

            if (month == "10")
            { monthText = "październik"; }

            if (month == "12")
            { monthText = "grudzień"; }

            if (month == "01")
            { monthText = "styczeń"; }

            if (month == "02")
            { monthText = "luty"; }

            if (month == "03")
            { monthText = "marzec";
                Console.WriteLine("Tomek");
            }

            if (month == "07")
            {
                monthText = "lipiec";
            }
            Console.WriteLine(monthText);
            return monthText;
        }
    }
}
