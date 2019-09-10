using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoDeclanFeore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //my graphics objects
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 100);
            Pen drawPen2 = new Pen(Color.White, 1);
            Pen drawPen3 = new Pen(Color.Gray, 1);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            SolidBrush drawBrush2 = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial", 30, FontStyle.Bold);

            //all the shapes in the logo
            g.DrawEllipse(drawPen, 90, 90, 210, 210);
            g.FillEllipse(drawBrush, 90, 90, 210, 210);
            g.DrawEllipse(drawPen3, 90, 90, 210, 210);
            g.DrawEllipse(drawPen3, 39, 39, 311, 311);
            g.DrawPie(drawPen2, 90, 90, 210, 210, 0, 90);
            g.FillPie(drawBrush2, 90, 90, 210, 210, 0, 90);
            g.DrawPie(drawPen2, 90, 90, 210, 210, 180, 90);
            g.FillPie(drawBrush2, 90, 90, 210, 210, 180, 90);

            //all the text in the logo
            g.TranslateTransform(80, 90);
            g.RotateTransform(320);
            g.DrawString("B", drawFont, drawBrush2, new Rectangle());
            g.ResetTransform();
            g.TranslateTransform(275, 65);
            g.RotateTransform(40);
            g.DrawString("W", drawFont, drawBrush2, new Rectangle());
            g.ResetTransform();
            g.DrawString("M", drawFont, drawBrush2, 170, 40);
        }
    }
}
