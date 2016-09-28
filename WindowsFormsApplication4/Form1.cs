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
using System.Media;

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

            //Sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.Star);
            player.PlayLooping(); 

            Thread.Sleep(600);


            //connecting dots and change color of dots
            formGraphics.DrawLine(drawPen, 32, 102, 102, 122);
            drawBrush.Color = Color.Yellow;
            formGraphics.FillEllipse(drawBrush, 30, 100, 10, 10);
            formGraphics.FillEllipse(drawBrush, 100, 120, 10, 10);

            Thread.Sleep(600);

            //Connecting Dots and Change color
            formGraphics.DrawLine(drawPen, 106, 123, 162, 172);
            formGraphics.FillEllipse(drawBrush, 160, 170, 10, 10);

            Thread.Sleep(600);

            //Connecting Dots and Change color
           formGraphics.DrawLine(drawPen, 163, 172, 126, 230);
           formGraphics.FillEllipse(drawBrush, 120, 230, 10, 10);

            Thread.Sleep(600);
           
            //Connecting Dots and Change color
            formGraphics.DrawLine(drawPen, 162, 173, 234, 137);
            formGraphics.FillEllipse(drawBrush, 230, 130, 10, 10);

            Thread.Sleep(600);

            formGraphics.DrawLine(drawPen, 232, 131, 206, 78);
            formGraphics.FillEllipse(drawBrush, 205, 75, 10, 10);

            Thread.Sleep(600);

            formGraphics.DrawLine(drawPen, 207, 76, 193, 6);
            formGraphics.FillEllipse(drawBrush, 190, 5, 10, 10);

            Thread.Sleep(600);

            formGraphics.DrawLine(drawPen, 234, 137, 286, 100);
            formGraphics.FillEllipse(drawBrush, 280, 100, 10, 10);

            Thread.Sleep(600);

            formGraphics.DrawLine(drawPen, 284, 100, 296, 70);
            formGraphics.FillEllipse(drawBrush, 290, 70, 10, 10);

            player.Stop();

            Thread.Sleep(600);


            formGraphics.Clear(Color.White);
            drawBrush.Color = Color.Red;
            Font drawText = new Font("Ariel", 8, FontStyle.Italic);
            formGraphics.DrawString("Virgo, The Moon is in practical, helpful Virgo all day", drawText, drawBrush, 5, 40);
            formGraphics.DrawString("stimulating our need to organize, tidy, solve problems,", drawText, drawBrush, 5, 60);
            formGraphics.DrawString("and get answers.We may wrestle with expectations with", drawText, drawBrush, 5, 80);
            formGraphics.DrawString("the Moon's square to Saturn and opposition to Neptune.", drawText, drawBrush, 5, 100);
            formGraphics.DrawString("We are instinctively drawn to helping others,", drawText, drawBrush, 5, 120);
            formGraphics.DrawString("and we feel most secure when we are needed. We might", drawText, drawBrush, 5, 140);
            formGraphics.DrawString("be a little more reserved or self-contained than usual. ", drawText, drawBrush, 5, 160);
            formGraphics.DrawString("We pay more attention to details, and we're especially", drawText, drawBrush, 5, 180);
            formGraphics.DrawString("sensitive to criticism.The Moon's trine to Pluto tonight", drawText, drawBrush, 5, 200);
            formGraphics.DrawString("points to productivity, insight, and a sense of purpose.", drawText, drawBrush, 5, 220);



















        }
    }
}
