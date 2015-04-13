using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UI_Desktop
{
    public class backtree
    {
        public void drawtree(Graphics tree)
        {
        }

        public void drawlamppost(Graphics lamppost)
        {
            lamppost.FillEllipse(Brushes.DarkSlateBlue, 1, 72, 15, 12);
            lamppost.FillRectangle(Brushes.DarkSlateBlue, 5, 25, 8, 50);
            lamppost.FillEllipse(Brushes.DarkOrange, 0, 20, 18, 5);
            lamppost.FillEllipse(Brushes.Orange, 2, 8, 13, 13);

        }

        public void drawsortlamppost(Graphics lamppost)
        {
            /*lamppost.FillEllipse(Brushes.DarkSlateBlue, 1, 25, 15, 12);
            lamppost.FillRectangle(Brushes.DarkSlateBlue, 5, 17, 8, 14);
            lamppost.FillEllipse(Brushes.DarkOrange, 0, 12, 18, 5);
            lamppost.FillEllipse(Brushes.Orange, 2, 2, 13, 13);*/

        }
    }
}
