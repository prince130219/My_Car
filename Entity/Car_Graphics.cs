using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Entity
{
    public class Car_Graphics
    {
        public void carRight(Graphics g)
        {
            
            Pen p = new Pen(Color.Blue, 2);

            g.DrawLine(p, 25, 10, 100, 10);
            g.DrawLine(p, 12, 30, 25, 10);
            g.DrawLine(p, 12, 30, 2, 30);
            g.DrawLine(p, 2, 45, 2, 30);
            g.DrawLine(p, 115, 30, 100, 10);
            g.DrawLine(p, 115, 30, 135, 30);
            g.DrawLine(p, 135, 45, 135, 30);
            g.DrawLine(p, 2, 45, 25, 45);

            g.DrawLine(p, 70, 15, 95, 15);
            g.DrawLine(p, 104, 27, 95, 15);
            g.DrawLine(p, 70, 15, 70, 27);
            g.DrawLine(p, 104, 27, 70, 27);
            g.DrawLine(p, 30, 15, 60, 15);
            g.DrawLine(p, 60, 27, 60, 15);
            g.DrawLine(p, 30, 15, 23, 27);
            g.DrawLine(p, 60, 27, 23, 27);

            g.FillEllipse(Brushes.Red, 23, 35, 20, 20);
            //g.DrawEllipse(p, 23, 35, 20, 20);
            g.DrawLine(p, 42, 45, 90, 45);
            //g.DrawEllipse(p, 88, 35, 20, 20);

            g.FillEllipse(Brushes.Red, 88, 35, 20, 20);

            g.DrawLine(p, 135, 45, 107, 45);




        }
        public void carLeft(Graphics g)
        {
            
            Pen p = new Pen(Color.Blue, 2);

            g.DrawLine(p, 2, 30, 2, 45);
            g.DrawLine(p, 2, 30, 22, 30);
            g.DrawLine(p, 37, 10, 22, 30);
            g.DrawLine(p, 37, 10, 112, 10);
            g.DrawLine(p, 125, 30, 112, 10);
            g.DrawLine(p, 125, 30, 135, 30);
            g.DrawLine(p, 135, 45, 135, 30);
            g.DrawLine(p, 135, 45, 112, 45);
            g.DrawLine(p, 95, 45, 47, 45);
            g.DrawLine(p, 2, 45, 30, 45);
            // g.DrawEllipse(p, 28, 35, 20, 20);
            // g.DrawEllipse(p, 93, 35, 20, 20);

            g.FillEllipse(Brushes.Red, 28, 35, 20, 20);

            g.FillEllipse(Brushes.Red, 93, 35, 20, 20);

            g.DrawLine(p, 42, 15, 67, 15);
            g.DrawLine(p, 67, 27, 67, 15);
            g.DrawLine(p, 33, 27, 67, 27);
            g.DrawLine(p, 42, 15, 33, 27);

            g.DrawLine(p, 107, 15, 77, 15);
            g.DrawLine(p, 77, 27, 77, 15);
            g.DrawLine(p, 77, 27, 114, 27);
            g.DrawLine(p, 107, 15, 114, 27);
        }
        public void carUp(Graphics g)
        {
           

            Pen p = new Pen(Color.Blue, 2);

            g.DrawLine(p, 26, 0, 54, 0);
            g.DrawLine(p, 57, 8, 54, 0);
            g.DrawLine(p, 26, 0, 23, 8);


            g.DrawLine(p, 23, 8, 57, 8);
            g.DrawLine(p, 23, 8, 20, 20);
            g.DrawLine(p, 60, 20, 57, 8);

            g.DrawLine(p, 20, 20, 20, 80);
            g.DrawLine(p, 60, 80, 20, 80);
            g.DrawLine(p, 60, 80, 60, 20);
            g.DrawLine(p, 20, 20, 60, 20);

            g.DrawLine(p, 23, 75, 57, 75);
            g.DrawLine(p, 23, 25, 57, 25);
            g.DrawLine(p, 23, 75, 23, 25);
            g.DrawLine(p, 57, 25, 57, 75);

            g.DrawLine(p, 23, 90, 20, 80);
            g.DrawLine(p, 57, 90, 60, 80);
            g.DrawLine(p, 23, 90, 57, 90);

        }

        public void carDown(Graphics g)
        {

            Pen p = new Pen(Color.Blue, 2);

            g.DrawLine(p, 13, 0, 47, 0);
            g.DrawLine(p, 10, 10, 50, 10);
            g.DrawLine(p, 10, 10, 13, 0);
            g.DrawLine(p, 50, 10, 47, 0);

            g.DrawLine(p, 10, 10, 10, 70);
            g.DrawLine(p, 50, 10, 50, 70);
            g.DrawLine(p, 10, 70, 50, 70);

            g.DrawLine(p, 10, 70, 13, 82);
            g.DrawLine(p, 47, 82, 13, 82);
            g.DrawLine(p, 47, 82, 50, 70);

            g.DrawLine(p, 13, 82, 16, 90);
            g.DrawLine(p, 16, 90, 44, 90);
            g.DrawLine(p, 47, 82, 44, 90);

            g.DrawLine(p, 13, 15, 47, 15);
            g.DrawLine(p, 13, 15, 13, 65);
            g.DrawLine(p, 47, 65, 13, 65);
            g.DrawLine(p, 47, 65, 47, 15);

        }
        
    }
}
