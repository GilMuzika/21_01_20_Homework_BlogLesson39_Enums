using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_01_20_Homework_BlogLesson39_Enums
{
    public partial class MainForm : Form    
    {
        private Elevator _currentElevator;
        private Timer _timer = new Timer();
        private ElevatorEngine _currentElevatorEngine;

        private event EventHandler<ElevatorEventArgs> GoToFloorNow;

         




        public MainForm()
        {
            InitializeComponent();            
            InitializeSomeControls();            
            Initialize();
            InitializeElevator();
        }
        private void Initialize()
        {            

          
            
            _currentElevator = new Elevator(1, ElevatorState.Resting, Properties.Resources.elevator_doorClose);
            
            _currentElevatorEngine = new ElevatorEngine(_currentElevator, pnlElevatorPanel.Height);
            _currentElevatorEngine.TheFloorReachedNow += _currentElevator.FloorReached;

            this.GoToFloorNow += (object sender, ElevatorEventArgs e) => { _currentElevator.GoToFloor(e.Floor, e.Engine); };


            this.pnlElevatorPanel.Controls.Add(_currentElevator);

            for (int i = 1; i <= _currentElevatorEngine.FloorsNumber; i++) cmbSelectFloor.Items.Add(i);
            cmbSelectFloor.SelectedIndex = 0;


        }


        private void btnTest_Click_1(object sender, EventArgs e)
        {
            GoToFloorNow?.Invoke(this, new ElevatorEventArgs { Floor = (int)cmbSelectFloor.SelectedItem, Engine = _currentElevatorEngine });
        }
    }
}
