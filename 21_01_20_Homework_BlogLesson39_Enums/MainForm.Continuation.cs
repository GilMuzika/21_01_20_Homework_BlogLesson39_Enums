using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_01_20_Homework_BlogLesson39_Enums
{
    partial class MainForm
    {
        private DaysOfTheWeek _currentDaysOfTheWeek = new DaysOfTheWeek();        
        private Days _createdEnum;
        private void InitializeSomeControls()
        {                    
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, 0);
            this.StartPosition = FormStartPosition.Manual;
            
            pnlElevatorPanel.BringToFront();
            pnlElevatorPanel.Height = this.ClientRectangle.Height - 5;
            pnlElevatorPanel.Width = Properties.Resources.elevator_doorClose.Width + 20;
            pnlElevatorPanel.Location = new Point(this.ClientRectangle.Width - pnlElevatorPanel.Width - 50, 2);

            Label lblMaskForPanel = new Label();
            lblMaskForPanel.AutoSize = false;
            lblMaskForPanel.Width = pnlElevatorPanel.Width + 2;
            lblMaskForPanel.Height = pnlElevatorPanel.Height + 2;
            lblMaskForPanel.drawBorder(1, Color.Black);
            //lblMaskForPanel.Visible = false;
            //pnlElevatorPanel.drawBorder(1, Color.Red);
            lblMaskForPanel.Location = new Point(pnlElevatorPanel.Location.X - 1, pnlElevatorPanel.Location.Y - 1);
            lblMaskForPanel.SendToBack();
            this.Controls.Add(lblMaskForPanel);

            lblEnumResult.Text = string.Empty;
            //cmbDaysEnum.Items.AddRange());
            Enum.GetValues(typeof(Days)).Cast<Days>().ToList().ForEach(x => cmbDaysEnum.Items.Add(x));
            cmbDaysEnum.SelectedIndex = 0;
            
        }
        private void InitializeElevator()
        {
            _currentElevator.LocationOfThisX = pnlElevatorPanel.Width / 2;
            _currentElevator.LocationOfThisY = pnlElevatorPanel.Height - _currentElevator.Height / 2;
        }

        private void btnPrintAllNotIncluded_Click(object sender, EventArgs e)
        {
            lblEnumResult.Text = _currentDaysOfTheWeek.PrintAllWichNotIncluded(_createdEnum);            
        }

        private void btnCreateEnumeration_Click(object sender, EventArgs e)
        {
            _createdEnum = _currentDaysOfTheWeek.CreateEnumeration(cmbDaysEnum.SelectedItem.ToString());
            lblEnumResult.Text = _createdEnum.ToString();            
        }
        private void cmbAddvalueToEnum_Click(object sender, EventArgs e)
        {
            _createdEnum = _currentDaysOfTheWeek.AddToEnum(_createdEnum, (Days)cmbDaysEnum.SelectedItem);
            lblEnumResult.Text = _createdEnum.ToString();
        }
        private void btnRemoveValueFromEnum_Click(object sender, EventArgs e)
        {
            _createdEnum = _currentDaysOfTheWeek.RemoveFromEnum(_createdEnum, (Days)cmbDaysEnum.SelectedItem);
            string enumAsString = _createdEnum.ToString();
            if (enumAsString.Equals("0")) enumAsString = "the enumeration gas no values";
            lblEnumResult.Text = enumAsString;
        }
    }
}
