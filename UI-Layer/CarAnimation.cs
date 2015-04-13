using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO_Layer;
using ENTITY_Layer;
namespace UI_Layer
{
    public partial class CarAnimation : Form
    {
        Car cd = new Car();
        
        BoClass bl = new BoClass();
        char k1;
        int x;
        int y;
        public Graphics g , g2;
        public CarAnimation()
        {
           
            InitializeComponent();
            x = bl.x;
            y = bl.y;
            g = carPanel.CreateGraphics();
            k1 = bl.getKey();
        }

        private void CarAnimation_Load(object sender, EventArgs e)
        {
           
            bl.CarStartposition(g);
           CurrentInfo.Text = "Now Press *Start* button";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Speed_comboBox1.Text))
                MessageBox.Show("Please, enter speed correctly.");
            else
            {
                Car c = new Car();
                c.speed = Convert.ToInt32(Speed_comboBox1.Text);
                if (bl.saveSpeed(c))
                {
                    //Info.Text = ;
                    CurrentInfo.Text = "Now, Press *Start*";
                    //currentInfoLabel.Text = Convert.ToString(bl.getData());
                }
                else
                {
                    MessageBox.Show("error");
                    //Info.Text = null;
                }
                

            }
            StopBtn.Focus();
            
        }

        private void carPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Info_Click(object sender, EventArgs e)
        {

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Speed_comboBox1.Enabled = true;
        }
        private  void checkField(){
            if (bl.getData() == 0)
            {
                timer1.Stop();
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Speed_comboBox1.Enabled = false;
            if (bl.speedCalculation() != 0 && !String.IsNullOrEmpty(Speed_comboBox1.Text))
            {
                timer1.Interval = bl.speedCalculation();
                timer1.Start();

            }
        }

        private void CarAnimation_KeyUp(object sender, KeyEventArgs e)
        {

            bl.setKey(k1);
            if (e.KeyCode == Keys.Up)
            {
                this.carPanel.Size = new System.Drawing.Size(94, 269);
                if (bl.Prevkey != 'x')
                {
                    
                    if (bl.Prevkey == 'r')
                    {
                       bl.SetXY(bl.x + 250, bl.y);
                    }
                }
                k1 = cd.task('u', g);
                CurrentInfo.Text = "*The Car is moving* *Direction :  Up * *Speed :" + Speed_comboBox1.Text +"*";
            }
            else if (e.KeyCode == Keys.Down)
            {
                //this.carPanel.Location = new System.Drawing.Point(77, 124);
                this.carPanel.Size = new System.Drawing.Size(94, 269);
                if (bl.Prevkey != 'x')
                {
                    if (bl.Prevkey == 'r')
                    {
                        bl.SetXY(bl.x + 220, bl.y);
                    }
                }
                k1 = cd.task('d', g);
                CurrentInfo.Text = "*The Car is moving* *Direction :  Down * *Speed :" + Speed_comboBox1.Text + "*";

            }
            else if (e.KeyCode == Keys.Left)
            {
                this.carPanel.Size = new System.Drawing.Size(343,110);
                if (bl.Prevkey != 'x')
                {
                    if (bl.Prevkey == 'd')
                    {

                        bl.SetXY(bl.x, bl.y + 120);
                    }
                }
                k1 = cd.task('l', g);
                CurrentInfo.Text = "*The Car is moving* *Direction :  Left * *Speed :" + Speed_comboBox1.Text + "*";

            }
            else if (e.KeyCode == Keys.Right)
            {
                this.carPanel.Size = new System.Drawing.Size(343, 110);
                if (bl.Prevkey != 'x')
                {
                    if (bl.key == 'd')
                    {

                        bl.SetXY(bl.x , bl.y+120);
                    }
                }
                k1 = cd.task('r', g);
                CurrentInfo.Text = "*The Car is moving* *Direction :  Right * *Speed :" + Speed_comboBox1.Text + "*";

            }
            bl.setKey(k1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            bl.changeAxes(k1);
           checkField();
            switch (k1)
            {
                case 'r':
                    Pen p = new Pen(Color.Black , 4);
                    Pen p2 = new Pen(Color.Green,4);
                    Pen p5 = new Pen(Color.Red, 4);

                //Left   
                // wheel r Lines r actual point dia Line draw korbo
                    g.DrawLine(p2, bl.a, bl.b, bl.c, bl.d );
                    g.DrawLine(p2, bl.e, bl.f, bl.g, bl.h);
                    g.DrawEllipse(p5, 60, 82, 10, 10);

                // wheel r Lines r changed point dia Line draw korbo
                    bl.rotateBackChaka();

                    g.DrawLine(p, bl.a, bl.b, bl.c, bl.d );
                    g.DrawLine(p, bl.e, bl.f, bl.g, bl.h);
                    g.DrawEllipse(p5, 60, 82, 10, 10);


                    //Right
                    // wheel r Lines r actual point dia Line draw korbo
                    g.DrawLine(p2, bl.a1, bl.b1, bl.c1, bl.d1);
                    g.DrawLine(p2, bl.e1, bl.f1, bl.g1, bl.h1);
                    g.DrawEllipse(p5, 215, 80, 10, 10);
                    bl.rotateFrontChaka();

                    // wheel r Lines r changed point dia Line draw korbo

                    g.DrawLine(p, bl.a1, bl.b1, bl.c1, bl.d1);
                    g.DrawLine(p, bl.e1, bl.f1, bl.g1, bl.h1);
                    g.DrawEllipse(p5, 215, 80, 10, 10);
                    break;

            }

            switch (k1)
            {
                case 'l':

                      Pen p = new Pen(Color.Black , 4);
                      Pen p5 = new Pen(Color.Red, 4);

                    Pen p2 = new Pen(Color.Green,4);

                    

                //Left   
                // wheel r Lines r actual point dia Line draw korbo
                    g.DrawLine(p2, bl.a, bl.b, bl.c, bl.d );
                    g.DrawLine(p2, bl.e, bl.f, bl.g, bl.h);
                    g.DrawEllipse(p5, 60, 82, 10, 10);

                // wheel r Lines r changed point dia Line draw korbo
                    bl.rotateBackChaka();

                    g.DrawLine(p, bl.a, bl.b, bl.c, bl.d );
                    g.DrawLine(p, bl.e, bl.f, bl.g, bl.h);
                    g.DrawEllipse(p5, 60, 82, 10, 10);


                    //Right
                    // wheel r Lines r actual point dia Line draw korbo
                    g.DrawLine(p2, bl.a1, bl.b1, bl.c1, bl.d1);
                    g.DrawLine(p2, bl.e1, bl.f1, bl.g1, bl.h1);
                    g.DrawEllipse(p5, 215, 80, 10, 10);
                    bl.rotateFrontChaka();

                    // wheel r Lines r changed point dia Line draw korbo

                    g.DrawLine(p, bl.a1, bl.b1, bl.c1, bl.d1);
                    g.DrawLine(p, bl.e1, bl.f1, bl.g1, bl.h1);
                    g.DrawEllipse(p5, 215, 80, 10, 10);
                    break;

            }
            carPanel.Location = new Point(bl.x, bl.y);
        }

        private void Speed_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CurrentInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void CarAnimation_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }
       
    }
}
