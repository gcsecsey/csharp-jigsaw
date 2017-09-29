using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Kepkocka : PictureBox
    {

        int ox, oy;
        bool moving = false;

        public Kepkocka(string kep, int sor, int oszlop)
        {
            MouseDown +=new MouseEventHandler(pbMouseDown);
            MouseUp +=new MouseEventHandler(pbMouseUp);
            MouseMove += new MouseEventHandler(pbMouseMove);

            this.Load(kep);
            this.Height = this.Image.Height;
            this.Width = this.Image.Width;
            this.Top = this.Image.Height * sor;
            this.Left = this.Image.Width * oszlop;

        }

        private void pbMouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            ox = e.X;
            oy = e.Y;
            BringToFront();
        }

        private void pbMouseUp(object sender, MouseEventArgs e)
        {
            moving = false;

            

        }

        private void pbMouseMove(object sender, MouseEventArgs e)
        {

            if (moving)
            {
                ((PictureBox)sender).Left += e.X - ox;
                ((PictureBox)sender).Top+= e.Y - oy;
             
            }

        }

        


    }
}
