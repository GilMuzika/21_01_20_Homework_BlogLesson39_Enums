using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_20_Homework_BlogLesson39_Enums
{
    class ElevatorEventArgs: EventArgs
    {
        public int Floor { get; set; }
        public ElevatorEngine Engine { get; set; }
    }
}
