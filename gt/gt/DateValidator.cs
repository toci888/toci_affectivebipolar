using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt
{
    internal class DateValidator
    // 1984-08-08

    {
        public DateValidator()
        {
                
        }
        public string GetMonth(string datecandidate)
        {
            string month = datecandidate.Substring(5, 2);
            string monthtext = string.Empty;
            if (month == "08")
            {
                monthtext = "sierpień";
            }
            if (month == "01")
            {
                monthtext = "styczeń";
            }
            if (month == "02")
            {
                monthtext = "luty";
            }
            if (month == "03")
            {
                monthtext = "marzec";
            }
            if (month == "04")
            {
                monthtext = "kwiecień";
            }
            if (month == "05")
            {
                monthtext = "maj";
            }
            if (month == "06")

            {
                monthtext = "czerwiec";
            }
            if (month == "07")
            {
                monthtext = "lipiec";
            }
            if (month == "09")
            {
                monthtext = "wrzesień";
            }
            if (month == "10")
            {
                monthtext = "pażdziernik";
            }
            if (month == "11")

            {
                monthtext = "listopad";
            }
            if (month == "12")
            {
                monthtext = "grudzień";
            }
            return monthtext;

        }
        public string Money(int price)
        {
            // 2 => dwa 
            string output = string.Empty;

            if (price == 1)
            {
                output = "jeden";
            }
            if (price == 2)
            {
                output = "dwa";
            }

            if (price == 3)
            {
                output = "trzy";
            }
            if (price == 4)
            {
                output = "cztery";
            }
            if (price == 5)
            {
                output = "pięć";
            }

            if (price == 6)
            {
                output = "sześć";
            }
            if (price == 7)
            {
                output = "siedem";
            }
            if (price == 8)
            {
                output = "osiem";
            }
            if (price == 9)
            {
                output = "dziewięć";
            }
            if (price == 10)
            {
                output = "dziesięć";
            }


            return output;
        }

        public string moneyValue(int price)
        {
            string output = string.Empty;

            if (price == 1)
            {
                output = "złoty";
            }
            if (price>1 && price<5)
             {
                output = "złote";
             }
            if (price == 5 || price == 6 || price == 7 || price == 8 || price == 9 || price == 10)
                    {
                output = "złotych";
            }

            return output;

            }


        }





}
            
            
    
    

