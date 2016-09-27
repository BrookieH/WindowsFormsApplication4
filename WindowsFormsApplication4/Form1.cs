using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openButton.Hide();
            
            
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.Black);
            Pen drawPen = new Pen(Color.White, 5);
            SolidBrush drawBrush = new SolidBrush(Color.WhiteSmoke);
            drawBrush.Color = Color.White;
            Font drawFont = new Font("New Times Roman", 12, FontStyle.Italic);
            formGraphics.DrawString("Virgo Zodiac", drawFont, drawBrush, 200, 230);

            //Stars
            formGraphics.FillEllipse(drawBrush, 30, 100, 10, 10);
            formGraphics.FillEllipse(drawBrush, 100, 120, 10, 10);
            formGraphics.FillEllipse(drawBrush, 160, 170, 10, 10);
            formGraphics.FillEllipse(drawBrush, 120, 230, 10, 10);
            formGraphics.FillEllipse(drawBrush, 190, 5, 10, 10);
            formGraphics.FillEllipse(drawBrush, 205, 75, 10, 10);
            formGraphics.FillEllipse(drawBrush, 280, 100, 10, 10);
            formGraphics.FillEllipse(drawBrush, 230, 130, 10, 10);
            formGraphics.FillEllipse(drawBrush, 290, 70, 10, 10);

            Thread.Sleep(1000);
           
            //connecting dots and change color of dots
            formGraphics.DrawLine(drawPen, 32, 102, 102, 122);
            drawBrush.Color = Color.Yellow;
            formGraphics.FillEllipse(drawBrush, 30, 100, 10, 10);
            formGraphics.FillEllipse(drawBrush, 100, 120, 10, 10);

            Thread.Sleep(1000);

            //Connecting Dots and Change color
            formGraphics.DrawLine(drawPen, 106, 123, 162, 172);
            formGraphics.FillEllipse(drawBrush, 160, 170, 10, 10);

            Thread.Sleep(1000);

            //Connecting Dots and Change color
           formGraphics.DrawLine(drawPen, 162, 172, 125, 230);
           formGraphics.FillEllipse(drawBrush, 120, 230, 10, 10);

            Thread.Sleep(1000);
           
            //Connecting Dots and Change color
            formGraphics.DrawLine(drawPen, 162, 173, 234, 137);
            formGraphics.FillEllipse(drawBrush, 230, 130, 10, 10);

            Thread.Sleep(1000);

            formGraphics.DrawLine(drawPen, 232, 131, 206, 78);
            formGraphics.FillEllipse(drawBrush, 205, 75, 10, 10);

            Thread.Sleep(1000);

            formGraphics.DrawLine(drawPen, 205, 76, 192, 6);
            formGraphics.FillEllipse(drawBrush, 190, 5, 10, 10);

            Thread.Sleep(1000);

            

















        }
    }
}
