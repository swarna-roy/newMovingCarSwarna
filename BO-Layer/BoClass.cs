using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using ENTITY_Layer;
using DAL_Layer;
namespace BO_Layer
{
    public class BoClass
    {
        DalClass dl = new DalClass();
        public char Prevkey = 'x';

        public int preX, preY;
        public int x = 12;
        public int y = 12;
        public char key = 'r';
        public int a = 65;
        public int b = 69;
        public int c = 65;
        public int d = 102;

        public int e = 48;
        public int f =85 ;
        public int g = 82;
        public int h = 85 ;


        public int a1 = 220;
        public int b1 = 68;
        public int c1 = 220;
        public int d1 = 103;

        public int e1 = 203;
        public int f1 =85;
        public int g1 = 237;
        public int h1 = 85;

        int q = 1, w = 1;

        public bool saveSpeed(Car c)
        {
            return dl.save(Convert.ToString(c.speed));
        }
        public int getData()
        {
            Car c = dl.getData();
            int speed = c.speed;
            return speed;
        }
        
        public int speedCalculation()
        {
            Car  c = dl.getData();
            if (c.speed == 10)
                return 300;
            else if (c.speed == 20)
                return 275;
            else if (c.speed == 30)
                return 250;
            else if (c.speed == 40)
                return 225;
            else if (c.speed == 50)
                return 200;
            else if (c.speed == 60)
                return 175;
            else if (c.speed == 70)
                return 150;
            else if (c.speed == 80)
                return 125;
            else if (c.speed == 90)
                return 50;
            else if (c.speed == 100)
                return 25;
            else
                return 67;
        }
        public void changeAxes(char key)
        {

            if (key == 'u')
            {
                y = y - 3;
                //if (y < 60 || (y < 347 && (x > 281 && x < 820)))
                //{
                //    dl.save("0");
                //}
            }
            else if (key == 'd')
            {
                y = y + 3;
                if ((y > 210 && (x >=100 && x <=  300)) || (y > 364&& (x >= 375 && x <= 660)))
                {
                    dl.save("0");
                }
            }
            else if (key == 'l')
            {
               
                x = x - 3;
                //if (x <61  || (x<869&& (y>150 && y<330)) )
                //{
                //    dl.save("0");
                //}
            }
            else if (key == 'r')
            {
                x = x + 3;
                if ((x > 225 && (y >= 136 && y <= 420)) || (x > 800 && (y >= 400 && y <= 592)))
                {
                    dl.save("0");
                }
            }
        }
      
        public void setKey(char c)
        {
            Prevkey = key;
            key = c;
        }
        public char getKey()
        {
            return key;
        }
        public void CarStartposition(Graphics g)
        {
            Car c = new Car();
            c.task(key, g);
        }

        public void rotateBackChaka()
        {
            a = a -11 * q;
            b = b + 31 * q;
            c = c  +11 * q;
            d = d - 32 * q;
            e = e + 6 * q;
            f = f -15 * q;
            g = g -6  * q;
            h = h  + 15 * q;
            q = q * -1;
        }
        public void rotateFrontChaka()
        {
            a1 = a1 -11 * w;
            b1 = b1 +2 * w;
            c1 = c1 +11 * w;
            d1 = d1 - 3 * w;
            
            e1 = e1 +6 * w;
            f1= f1 +15  * w;
            g1 = g1 -6  * w;
            h1 = h1 - 15 * w;
             w = w * -1;
        }

        public void SetXY( int x , int y)
        {
            this.x = x ;
            this.y= y;

        }

    }
}
