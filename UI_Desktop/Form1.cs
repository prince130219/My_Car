using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using Entity;

namespace UI_Desktop
{
    public partial class UIlyear : Form
    {
        bologic da = new bologic();
        Car_Graphics cg = new Car_Graphics();
        backtree bg = new backtree();

        Graphics car;
        Graphics t1, t2, t3;
        Graphics l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17, l18, l19, l20, l21, l22, l23, l24, l25, l26, l27, l28;

        Char keyPress;


        public UIlyear()
        {
            InitializeComponent();
            int x = da.x;
            int y = da.y;
            keyPress = 'r';

        }

        public void ATstart()
        {
            car = car_panel.CreateGraphics();
            cg.carRight(car);

            /*t1 = tree1.CreateGraphics();
            t2 = tree2.CreateGraphics();
            t3 = tree3.CreateGraphics();
            bg.drawtree(t1);
            bg.drawtree(t2);
            bg.drawtree(t3);*/

            l1 = lamp1.CreateGraphics();
            l2 = lamp2.CreateGraphics();
            l3 = lamp3.CreateGraphics();
            bg.drawlamppost(l1);
            bg.drawlamppost(l2);
            bg.drawlamppost(l3);

            /*l4 = lamp4.CreateGraphics();
            l5 = lamp5.CreateGraphics();
            l6 = lamp6.CreateGraphics();
            l7 = lamp7.CreateGraphics();
            l8 = lamp8.CreateGraphics();
            l9 = lamp9.CreateGraphics();
            l10 = lamp10.CreateGraphics();
            l11 = lamp11.CreateGraphics();
            l12 = lamp12.CreateGraphics();
            l13 = lamp13.CreateGraphics();
            l14 = lamp14.CreateGraphics();
            l15 = lamp15.CreateGraphics();
            l16 = lamp16.CreateGraphics();
            l17 = lamp17.CreateGraphics();
            l18 = lamp18.CreateGraphics();
            l19 = lamp19.CreateGraphics();
            l20 = lamp20.CreateGraphics();
            l21 = lamp21.CreateGraphics();
            l22 = lamp22.CreateGraphics();
            l23 = lamp23.CreateGraphics();
            l24 = lamp24.CreateGraphics();
            l25 = lamp25.CreateGraphics();
            l26 = lamp26.CreateGraphics();
            l27 = lamp27.CreateGraphics();
            l28 = lamp28.CreateGraphics();
            bg.drawsortlamppost(l4);
            bg.drawsortlamppost(l5);
            bg.drawsortlamppost(l6);
            bg.drawsortlamppost(l7);
            bg.drawsortlamppost(l8);
            bg.drawsortlamppost(l9);
            bg.drawsortlamppost(l10);
            bg.drawsortlamppost(l11);
            bg.drawsortlamppost(l12);
            bg.drawsortlamppost(l13);
            bg.drawsortlamppost(l14);
            bg.drawsortlamppost(l15);
            bg.drawsortlamppost(l16);
            bg.drawsortlamppost(l17);
            bg.drawsortlamppost(l18);
            bg.drawsortlamppost(l19);
            bg.drawsortlamppost(l20);
            bg.drawsortlamppost(l21);
            bg.drawsortlamppost(l22);
            bg.drawsortlamppost(l23);
            bg.drawsortlamppost(l24);
            bg.drawsortlamppost(l25);
            bg.drawsortlamppost(l26);
            bg.drawsortlamppost(l27);
            bg.drawsortlamppost(l28);*/
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            notificationlavel.Text = null;
            switch (keyPress)
            {
                case 'u':
                    cg.carUp(car);
                    break;
                case 'd':
                    cg.carDown(car);
                    break;
                case 'r':
                    cg.carRight(car);
                    break;
                case 'l':
                    cg.carLeft(car);
                    break;
            }
            if (da.speedCalculation() !=0 && !String.IsNullOrEmpty(speedbox.Text))
            {
                timer1.Interval = da.speedCalculation();
                timer1.Start();
            }
            else 
            {
                MessageBox.Show("Please Enter speed into 100!!!");
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            ATstart();
            Car c = new Car();
            try
            {
                c.speed = Convert.ToInt32(speedbox.Text);
                notificationlavel.Text = "Now Press the Start Button";
            }
            catch
            {
                notificationlavel.Text = null;
                speedbox.Text = null;
                MessageBox.Show("Enter Only Integer!!!");       
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            da.changeAxes(keyPress);
            car_panel.Location = new Point(da.x, da.y);
        }

        private void UIlyear_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyPress = 'u';
                car.Clear(Color.DimGray);
                cg.carUp(car);
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyPress = 'd';
                car.Clear(Color.DimGray);
                cg.carDown(car);
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyPress = 'l';
                car.Clear(Color.DimGray);
                cg.carLeft(car);
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyPress = 'r';
                car.Clear(Color.DimGray);
                cg.carRight(car);
            }
        }

        private void battonholderpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UIlyear_Load(object sender, EventArgs e)
        {

        }

        private void car_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roadpanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
