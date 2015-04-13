using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ENTITY_Layer
{
    public class Car

    {
         public int speed;
        

        public char task(char c, Graphics g)
        {

            if (c == 'u')
            {

                g.Clear(Color.Black);
                carUp(g);
                return 'u';
            }
            else if (c == 'd')
            {

                g.Clear(Color.Black);
                carDown(g);
                return 'd';
            }
            else if (c == 'l')
            {

                g.Clear(Color.Black);
                carLeft(g);
                return 'l';
            }
            else if (c == 'r')
            {

                g.Clear(Color.Black);
                carRight(g);
                return 'r';
            }
            else
                return 'o';

        }

        private void carRight(Graphics g)
        {


            Pen p = new Pen(Color.Red, 4);
            Pen p2 = new Pen(Color.Green, 4);
            Pen p3 = new Pen(Color.Green, 5);
            Pen p5 = new Pen(Color.Green ,4);

            Pen ph = new Pen(Color.Yellow, 4);
            Pen ph2 = new Pen(Color.Yellow, 16);

            g.DrawLine(p, 100, 5, 200, 5);//Top
            g.DrawLine(p, 100, 5, 60, 45);//left Slop
            g.DrawLine(p, 200, 5, 240, 45);//Right slop
            //1
            g.DrawLine(p, 240, 45, 300, 45);//Right Slop below Straight Line
            g.DrawLine(p, 60, 45, 25, 45);//Left Slop below Straight Line
            g.DrawLine(p, 25, 45, 25, 85);//Left most straight Line Along Y axis
             g.DrawLine(p, 300, 45, 300, 85);//Right most straight Line Along Y axis

            //headlight
           //  g.DrawLine(ph, 301, 80, 320, 65);//Right most straight Line Along Y axis
           //  g.DrawLine(ph, 301, 82, 322,75);//Right most straight Line Along Y axis
           //// g.DrawLine(ph, 301, 84, 325, 80);//Right most straight Line Along Y axis
           //  g.DrawLine(ph, 301, 85, 330, 80);//Right most straight Line Along Y axis
           //g.DrawLine(ph, 301, 88, 325, 90);//Right most straight Line Along Y axis
           //  g.DrawLine(ph, 301, 91, 322, 100);//Right most straight Line Along Y axis
           // g.DrawLine(ph, 301, 92, 320,100 );//Right most straight Line Along Y axis
            g.DrawLine(ph2, 295, 53, 295, 69);





            g.DrawEllipse(p3, 45, 65, 40, 40);//Left Wheel
            g.DrawEllipse(p3, 200, 65, 40, 40); // right Wheel
            g.DrawLine(p, 25, 85, 45, 85);//Lower Left along X - axis
            g.DrawLine(p, 244, 85, 300, 85);//Lower Right along X - axis
            g.DrawLine(p, 88, 85, 196, 85);// Lower middle along X - axis
            g.DrawLine(p, 105, 15, 190, 15 );//below Top
            g.DrawLine(p, 190, 15, 220, 45);//below Top right
            g.DrawLine(p, 105, 15, 75, 45);//below Top Left
            g.DrawLine(p, 75, 45, 220, 45 );// lower line of window
            g.DrawLine(p, 145, 15 , 145, 87);// window divider
            g.DrawLine(p, 75, 45, 75, 65);//below Left window along y axis
            g.DrawLine(p, 220, 45, 220, 63);//below right window along y axis
            g.DrawEllipse(p5, 60, 82, 10, 10);
            g.DrawEllipse(p5, 215, 82, 10, 10);

            g.DrawLine(p5, 54, 100, 76, 70);// Left wheel vertex
            g.DrawLine(p5, 54, 70 , 76, 100);//left wheel horizental

            g.DrawLine(p5, 209, 70, 231, 100);// Right wheel vertex
            g.DrawLine(p5, 209, 100, 231, 70);// Right wheel horizental






        }
        private void carLeft(Graphics g )
        {
            /* g.FillRectangle(Brushes.Chocolate, new Rectangle(52, 12, 70, 40));
             Point[] pts = { new Point(22, 27),new Point(37, 17),new Point(52, 17),   new Point(52, 52), new Point(22, 52) };
             Pen p = new Pen(Color.Black, 1);
             g.FillPolygon(Brushes.Lime, pts);
             g.FillRectangle(Brushes.Black, new Rectangle(62, 25, 10, 10));
             g.FillRectangle(Brushes.Black, new Rectangle(82, 25, 10, 10));
             g.FillRectangle(Brushes.Black, new Rectangle(98, 25, 10, 10));


             g.DrawLine(p, 112, 12, 112, 62);
             g.DrawLine(p, 102, 12, 102, 62);
             g.DrawLine(p, 92, 12, 92, 62);
             g.DrawLine(p, 82, 12, 82, 62);
             g.DrawLine(p, 72, 12, 72, 62);
             g.DrawLine(p, 62, 12, 62, 72);
             g.FillRectangle(Brushes.Black, new Rectangle(37, 22, 12, 10));
             Pen p2 = new Pen(Color.Lime, 2);
             g.DrawEllipse(p2, 32, 50, 20, 20);
             g.DrawEllipse(p2, 62, 50, 20, 20);

             Pen p3 = new Pen(Color.White );
            // g.DrawLine(p3, 42, 50, 42, 70);
             //g.DrawLine(p3, 72, 50, 72, 70);

             g.DrawLine(p3, 32, 60, 52, 60);
                         g.DrawLine(p3, 62, 60, 82, 60);
           */
            Pen p = new Pen(Color.Red, 4);
            Pen p2 = new Pen(Color.Green, 4);
            Pen p3 = new Pen(Color.Green, 5);
            Pen ph = new Pen(Color.Yellow, 4);
            Pen ph2 = new Pen(Color.Yellow, 16);

            g.DrawLine(p, 100, 5, 200, 5);//Top
            g.DrawLine(p, 100, 5, 60, 45);//left Slop
            g.DrawLine(p, 200, 5, 240, 45);//Right slop
            g.DrawLine(p, 240, 45, 270, 45);//Right Slop below Straight Line
            g.DrawLine(p, 60,45, 10, 45);//Left Slop below Straight Line
            g.DrawLine(p, 10, 45, 10,85);//Left most straight Line Along Y axis

           
            ////headlight
            //g.DrawLine(ph, 10, 90, -10, 60);
            //g.DrawLine(ph, 10, 82, -8, 75);
            //g.DrawLine(ph, 10, 85, 1, 80);
            //g.DrawLine(ph, 10, 88, 1, 90);
            //g.DrawLine(ph, 10, 91, 1, 100);
            //g.DrawLine(ph, 10, 92, 1, 110);
            g.DrawLine(ph2, 15, 55, 15, 75);

            g.DrawLine(p, 270, 45, 270, 85);//Right most straight Line Along Y axis
            g.DrawEllipse(p3, 45, 65, 40, 40);//Left Wheel
            g.DrawEllipse(p3, 200, 65, 40, 40); // right Wheel
            g.DrawLine(p, 10, 85, 45, 85);//Lower right along X - axis
            g.DrawLine(p, 243, 85, 270, 85 );//Lower Left along X - axis
            g.DrawLine(p, 88, 85, 197, 85 );// Lower middle along X - axis
            g.DrawLine(p, 105, 15, 190, 15);//below Top
            g.DrawLine(p, 190, 15, 220, 45);//below Top right
            g.DrawLine(p, 105, 15, 75, 45);//below Top Left
            g.DrawLine(p, 75, 45, 220, 45);// lower line of window
            g.DrawLine(p, 145, 15, 145, 87);// window divider

            g.DrawLine(p, 75, 45, 75, 65);//below Left window along y axis
            g.DrawLine(p, 220, 45, 220, 63);//below right window along y axis


            Pen p5 = new Pen(Color.Black, 4);
            g.DrawEllipse(p5, 215, 80, 10, 10);

           // Pen p5 = new Pen(Color.Black, 4);
            g.DrawEllipse(p5, 60, 80, 10, 10);

            g.DrawLine(p2, 65, 69, 65, 102);// Left wheel vertex
            g.DrawLine(p2, 48, 85, 82, 85);//left wheel horizental
            g.DrawLine(p2, 220, 68, 220, 103);// Right wheel vertex
            g.DrawLine(p2, 203, 85, 237, 85);// Right wheel horizental


        }
        
        private void  carUp(Graphics g)
        {
            
            Pen p = new Pen(Color.Red , 4);
            g.DrawRectangle(p, 5, 42, 80, 220);
            g.DrawLine(p, 5, 110, 85, 110);

            g.DrawLine(p, 5, 220, 85, 220);
            //small rec
            g.DrawRectangle(p, 20,130, 50,70);
            //upper small lines
            g.DrawLine(p, 5, 110, 20, 130);
            g.DrawLine(p, 70, 130, 85, 110);

            //lower small lines
            g.DrawLine(p, 5, 220, 20, 200);
            g.DrawLine(p, 70, 200,85 ,220);

            Pen ph = new Pen(Color.Yellow, 4);
            Pen ph2 = new Pen(Color.Yellow, 14);
            g.DrawLine(ph2, 20, 42, 40,42);
            g.DrawLine(ph2, 50, 42, 70, 42);

        }

        private void carDown(Graphics g)
        {
            Pen p = new Pen(Color.Red, 4);
            g.DrawRectangle(p, 5, 12, 80, 220);
            g.DrawLine(p, 5, 50, 85, 50);

            g.DrawLine(p, 5, 160, 85,160);
            //small rec
            g.DrawRectangle(p, 20, 70, 50, 70);
            //upper small lines
            g.DrawLine(p, 5, 50, 20, 70);
            g.DrawLine(p, 70, 70, 85, 50);

            //lower small lines
            g.DrawLine(p, 5, 160, 20, 140);
            g.DrawLine(p, 70, 140, 85, 160);

            Pen ph = new Pen(Color.Yellow, 4);
            Pen ph2 = new Pen(Color.Yellow, 14);
            g.DrawLine(ph2, 15, 232, 35, 232);
            g.DrawLine(ph2, 45, 232, 65, 232);
        }
    }
}
