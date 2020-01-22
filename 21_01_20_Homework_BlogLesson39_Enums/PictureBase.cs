using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_01_20_Homework_BlogLesson39_Enums
{
    public class PictureBase: PictureBox
    {    
        protected int _locationOfThisX;
        protected int _locationOfThisY;
        public int LocationOfThisX
        {
            get => _locationOfThisX;
            set
            {
                _locationOfThisX = value;
                LocationOfThis = new Point(_locationOfThisX, _locationOfThisY);
            }
        }
        public int LocationOfThisY
        {
            get => _locationOfThisY;
            set
            {
                _locationOfThisY = value;
                LocationOfThis = new Point(_locationOfThisX, _locationOfThisY);
            }
        }
        protected Point LocationOfThis
        {
            get { return new Point(this.Location.X - this.Width / 2, this.Location.Y - this.Height / 2); }

            set 
            {
                if(this.InvokeRequired)
                {
                    this.Invoke((Action)delegate { this.Location = new Point(value.X - this.Width / 2, value.Y - this.Height / 2); } );
                }
                else this.Location = new Point(value.X - this.Width / 2, value.Y - this.Height / 2); 
            }

        }

        public PictureBase(Bitmap thisBackImage)
        {
            this.BackgroundImage = thisBackImage;
            this.Size = thisBackImage.Size;
            this.BackgroundImageChanged += (object sender, EventArgs e) => 
                {
                    this.Width = this.BackgroundImage.Width;
                    this.Height = this.BackgroundImage.Height;
                };
        }
    }
}
