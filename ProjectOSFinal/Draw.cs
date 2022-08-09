using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectOSFinal
{
    public partial class Draw : Form
    {
        Bitmap off;
        public Draw()
        {
            this.Paint += Draw_Paint;
           this.WindowState= FormWindowState.Maximized;
        }

        private void Draw_Paint(object sender, PaintEventArgs e)
        {
            DrawScene(e.Graphics);
        }

        private void Draw_Load(object sender, EventArgs e)
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
        }
        Font drawfont = new Font("Arial", 16);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        StringFormat drawFormat = new StringFormat();
        void DrawScene(Graphics g)
        {
            g.Clear(Color.Gray);
            g.DrawString("C-SCAN", drawfont, drawBrush, 700, 10, drawFormat);
            g.DrawLine(Pens.Blue, 600, 150, 400, 100);
            g.FillEllipse(Brushes.Black, 400, 95, 10, 10);
            g.DrawLine(Pens.Blue, 800, 200, 600, 150);
            g.FillEllipse(Brushes.Black, 600, 145, 10, 10);
            g.DrawLine(Pens.Blue, 1000, 250, 800, 200);
            g.FillEllipse(Brushes.Black, 800, 195, 10, 10);
            g.DrawLine(Pens.Blue, 1200, 300, 1000, 250);
            g.FillEllipse(Brushes.Black, 1000, 245, 10, 10);
            g.DrawLine(Pens.Blue, 1400, 350, 1200, 300);
            g.FillEllipse(Brushes.Black, 1200, 295, 10, 10);
            g.DrawLine(Pens.Blue, 1500, 400, 1400, 350);
            g.FillEllipse(Brushes.Black, 1400, 345, 10, 10);
            g.FillEllipse(Brushes.Black, 1500, 395, 10, 10);
            g.DrawLine(Pens.Blue, 1500, 400, 10, 400);
            g.FillEllipse(Brushes.Black, 10, 395, 10, 10);
            g.DrawLine(Pens.Blue, 10, 400, 100, 500);
            g.DrawLine(Pens.Blue, 100, 500, 200, 550);
            g.FillEllipse(Brushes.Black, 100, 495, 10, 10);
            g.DrawLine(Pens.Blue, 200, 550, 300, 600);
            g.FillEllipse(Brushes.Black, 200, 545, 10, 10);
            g.FillEllipse(Brushes.Black, 300, 595, 10, 10);

        }
    }
}
