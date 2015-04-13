using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;


namespace BO
{
    public class bologic
    {
        dataaccess d = new dataaccess();
        public int x = 669;
        public int y = 162;
        public char key = 'r';
        public bool saveSpeed(Car c)
        {
            return d.save(Convert.ToString(c.speed));
        }
        public int speedCalculation()
        {
            Car c = d.getData();
            if (c.speed > 0 && c.speed <= 10)
                return 1000;
            else if (c.speed > 10 && c.speed <= 20)
                return 650;
            else if (c.speed > 20 && c.speed <= 30)
                return 350;
            else if (c.speed > 30 && c.speed <= 40)
                return 250;
            else if (c.speed > 40 && c.speed <= 50)
                return 180;
            else if (c.speed > 50 && c.speed <= 60)
                return 100;
            else if (c.speed > 60 && c.speed <= 70)
                return 65;
            else if (c.speed > 70 && c.speed <= 80)
                return 40;
            else if (c.speed > 80 && c.speed <= 90)
                return 20;
            else if (c.speed > 90 && c.speed <= 100)
                return 1;
            else if (c.speed > 100)
                return 0;
            else
                return 0;
  
        }
        public int getData()
        {
            Car c = d.getData();
            int speed = c.speed;
            return speed;
        }
        public void changeAxes(char key)
        {
            if (key == 'u')
            {
                if ((y <= 155 && y >= 153) && (x >= 651 && x <= 821))
                    y = y+0;
                else if (y == 0 && (x >= 0 && x < 1037))
                    y = y+0;
                else if (y == 310 && (x >= 127 && x < 658))
                    y = y+0;
                else
                    y = y - 2;
            }
            else if (key == 'd')
            {
                if (y == 228 && (x >= 710 && x <= 1060))
                    y = y + 0;
                else if (y == 10 && (x >= 547 && x <= 920))
                    y = y + 0;
                else if ((y >= 421 && y<=419) && (x >= 0 && x <= 1037))
                    y = y + 0;
                else
                    y = y + 2;
            }
            else if (key == 'l')
            {
                if ((x >=0 && x<=1) && (y >= 0 && y <= 425))
                    x = x + 0;
                else
                    x = x - 2;
            }
            else if (key == 'r')
            {
                if (x == 875 && (y >= 1 && y <= 425))
                    x = x + 0;
                else
                    x = x + 2;
            }
        }
        public void setKey(char c)
        {
            key = 'c';
        }
        public char getKey()
        {
            return key;
        }
    }
}
