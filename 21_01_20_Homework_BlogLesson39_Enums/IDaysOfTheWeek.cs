using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_20_Homework_BlogLesson39_Enums
{
    interface IDaysOfTheWeek
    {
        bool IsIncluded(Days days, Days day);
        Days AddToEnum(Days days, Days day);
        Days RemoveFromEnum(Days days, Days day);
        string PrintAllWichNotIncluded(Days days);
    }
}
