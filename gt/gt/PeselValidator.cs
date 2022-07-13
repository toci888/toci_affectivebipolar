using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt
{
    public class PeselValidator
    {
        protected Dictionary<int, int> monthToDaysMap = new Dictionary<int, int>()
        {
            { 1, 31 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 }
        };

        public bool Validate(string peselCandidate)
        {
            string yearT = peselCandidate.Substring(0, 2);
            string monthT = peselCandidate.Substring(2, 2);
            string dayT = peselCandidate.Substring(4, 2);

            int year, month, day;

            int.TryParse(yearT, out year);
            int.TryParse(monthT, out month);
            int.TryParse(dayT, out day);

            if (monthToDaysMap.ContainsKey(month) && monthToDaysMap[month] >= day)
            {
                return true;
            }
            
            return false;
        }
    }
}
