using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_20_Homework_BlogLesson39_Enums
{
    class EnumEventArgs: EventArgs
    {
        public bool Boolean { get; set; }
        public int Number { get; set; }
        public String Text { get; set; }
    }
}
