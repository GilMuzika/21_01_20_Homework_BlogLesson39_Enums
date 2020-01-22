using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_01_20_Homework_BlogLesson39_Enums
{
    [Flags]
    public enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4, 
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64
    }
    class DaysOfTheWeek: IDaysOfTheWeek
    {
        public bool IsIncluded(Days days, Days day)
        {
            bool toReturn = false;
            if (days.HasFlag(day)) toReturn = true;

            return toReturn;
        }
        public Days AddToEnum(Days days, Days day)
        {
            return days | day;
        }
        public string PrintAllWichNotIncluded(Days days)
        {
            string str = string.Empty;
            foreach(Days s in Enum.GetValues(typeof(Days)))
                if (!days.HasFlag(s)) str += $"-= {s} =-\n";
            
            return str;            
        }

        public Days RemoveFromEnum(Days days, Days day)
        {
            return days &= ~day;
        }
        public Days CreateEnumeration(string str)
        {
            Days toReturn = Days.Friday;
            foreach(Days s in Enum.GetValues(typeof(Days)))
            {
                if (s.ToString().Equals(str)) toReturn = s;                
            }
            return toReturn;
        }
        
    }

}
