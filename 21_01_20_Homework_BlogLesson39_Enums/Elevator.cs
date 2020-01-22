using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_01_20_Homework_BlogLesson39_Enums
{
    [Flags]
    public enum ElevatorState
    {
        GoingUp = 1,
        GoingDown = 2,
        DoorsOpen = 4,
        Resting = 16
    }





    class Elevator: PictureBase, IElevator
    {
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        private int _currentFloor;
        private ElevatorState _currentElevatorState;
        public ElevatorState ElevatorState
        {
            get => _currentElevatorState;
            set
            {
                if (value == ElevatorState.DoorsOpen) { this.BackgroundImage = Properties.Resources.elevator_doorOpen; CloseDoors(); }
                else this.BackgroundImage = Properties.Resources.elevator_doorClose;
                _currentElevatorState = value;
            }
        }
        private int _gotoFloor;     
        public Elevator(int currentFloor, ElevatorState currentElevatorState, Bitmap thisBackgroundImage): base(thisBackgroundImage)
        {
            _currentFloor = currentFloor;
            _currentElevatorState = currentElevatorState;

            _timer.Interval = 10;
            _timer.Enabled = false;
        }
        public bool GoToFloor(int newFloor, ElevatorEngine engine)
        {
            _gotoFloor = newFloor;
            bool toReturn = false;
            if (ElevatorState == ElevatorState.Resting)
            {
                if (_currentFloor == newFloor) ElevatorState = ElevatorState.DoorsOpen;
                else
                {
                    if (_currentFloor < newFloor) ElevatorState = ElevatorState.GoingUp;
                    if (_currentFloor > newFloor) ElevatorState = ElevatorState.GoingDown;
                }


                _timer.Tick += (object sender, EventArgs e) =>
                {
                    engine.moveElevator();                    
                };
                _timer.Start();


                toReturn = true;
            }            
            return toReturn;
        }
        public bool FloorReached(int floorReached)
        {
            _currentFloor = floorReached;
            if (floorReached == _gotoFloor && ElevatorState == ElevatorState.GoingUp | ElevatorState == ElevatorState.GoingDown)
            {
                _currentFloor = _gotoFloor;
                ElevatorState = ElevatorState.DoorsOpen;
                return true;
            }
            else  return false; 
        }
        public bool CloseDoors()
        {
            bool toReturn = false;
            Timer localTimer = new Timer();
            localTimer.Interval = 2000;
            localTimer.Enabled = false;

            

            localTimer.Tick += (object sender, EventArgs e) =>
                {                    
                    if (ElevatorState == ElevatorState.DoorsOpen)
                    {
                        ElevatorState = ElevatorState.Resting;                        
                    }
                    toReturn = true;
                    localTimer.Stop();
                    localTimer.Dispose();

                    toReturn = false;
                };
            localTimer.Start();
            return toReturn;
        }

        public void test()
        {
            
        }


    }
}
