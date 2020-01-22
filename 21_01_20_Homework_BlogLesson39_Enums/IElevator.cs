using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_20_Homework_BlogLesson39_Enums
{
    interface IElevator
    {
        bool GoToFloor(int newFloor, ElevatorEngine engine);
        bool FloorReached(int floorReached);
        bool CloseDoors();
    }
}
