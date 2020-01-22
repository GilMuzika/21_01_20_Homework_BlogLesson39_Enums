using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_01_20_Homework_BlogLesson39_Enums
{    
    class ElevatorEngine
    {
        private Elevator _currentElevator;
        private readonly int _shaftheight;
        private int _elevatorStep = 0;
        private int _elevatorSpeed = 1;
        private int _deepness;
        private List<int> _floors = new List<int>();
        private Dictionary<int, int> _florNumber = new System.Collections.Generic.Dictionary<int, int>();
        public int FloorsNumber { get => _floors.Count; }
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        public delegate bool TheFloorReached(int FloorReached);
        public event TheFloorReached TheFloorReachedNow;
        public ElevatorEngine(Elevator currentElevator, int shaftheight)
        {
            _currentElevator = currentElevator;
            _shaftheight = shaftheight;
            _deepness = _shaftheight;
            Initialize();
            InitializeFloors();
        }
        private void Initialize()
        {
            _timer.Interval = 10;
            _timer.Enabled = false;
            _timer.Start();
            _timer.Tick += (object sender, EventArgs e) =>
            {
                switch (_currentElevator.ElevatorState)
                {
                    case ElevatorState.GoingDown:
                        _currentElevator.LocationOfThisY += _elevatorStep;
                        if (_currentElevator.LocationOfThisY >= _shaftheight - _currentElevator.Height / 2) _elevatorSpeed = 0;
                        break;
                    case ElevatorState.GoingUp:                        
                        _currentElevator.LocationOfThisY += _elevatorStep;
                        if (_currentElevator.LocationOfThisY <= _currentElevator.Height / 2) _elevatorSpeed = 0; 
                        break;
                    default:
                        //_elevatorSpeed = 5;
                        break;

                }
                
            };            
        }
     
        private void InitializeFloors()
        {
            int shaftheightCopy = _shaftheight;           
            while (_deepness > _currentElevator.Height / 2)
            {
                _deepness = shaftheightCopy -= _currentElevator.Height;
                if (_deepness > 0) { _florNumber.Add(_deepness, floorCount); _floors.Add(_deepness); floorCount++; }                                
            }            

            /*string str = string.Empty;
            foreach(KeyValuePair<int, int> s in _florNumber)
            {
                str += $"{s.Key}, {s.Value}\n";
            }
            MessageBox.Show(str);*/
        }


        private int floorCount = 1;
        public int moveElevator()
        {   
            switch(_currentElevator.ElevatorState)
            {
                case ElevatorState.GoingUp:                
                    _elevatorStep = 0 - _elevatorSpeed;
                    break;
                case ElevatorState.GoingDown:
                    _elevatorStep = _elevatorSpeed;
                    break;
                default: _elevatorStep = 0; break;

            }
            if (_floors.Contains(_currentElevator.LocationOfThisY)) {  TheFloorReachedNow?.Invoke(_florNumber[_currentElevator.LocationOfThisY]); }

            return _currentElevator.LocationOfThisY;
        }
        public void ExtremetyReached()
        {
            if (_currentElevator.Location.Y == 0 || _currentElevator.Location.Y + _currentElevator.Height == _shaftheight)
            {
                _currentElevator.ElevatorState = ElevatorState.DoorsOpen;
            }
            
        }



    }
}
