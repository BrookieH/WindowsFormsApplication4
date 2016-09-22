using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SolidBrush drawBrush = new SolidBrush(Color.White);
            drawBrush.Color = Color.White;
            Font drawFont = new Font("New Times Roman", 12, FontStyle.Italic);
            formGraphics.DrawString("Virgo Zodiac", drawFont, drawBrush, 30, 200);

            //Stars
            formGraphics.FillEllipse(drawBrush, 40, 50, 10, 10);
            formGraphics.FillEllipse(drawBrush, 50, 50, 10, 10);
            formGraphics.FillEllipse(drawBrush, 8, 100, 10, 10);
            formGraphics.FillEllipse(drawBrush, 20, 25, 10, 10);
            formGraphics.FillEllipse(drawBrush, 90, 15, 10, 10);
            formGraphics.FillEllipse(drawBrush, 90, 90, 10, 10);
            formGraphics.FillEllipse(drawBrush, 75, 60, 10, 10);
            formGraphics.FillEllipse(drawBrush, 50, 90, 10, 10);
            





        }
    }
}
