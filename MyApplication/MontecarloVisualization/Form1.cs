using MontecarloAlgorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontecarloVisualization
{
    public partial class Form1 : Form
    {
        MonteCarloPI montecarlo;

        public Form1()
        {
            montecarlo = new MonteCarloPI();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            montecarlo.GeneratePoint();

            this.Text = $"PI : {montecarlo.GetPI()} ({montecarlo.Points.Count})";

            this.picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawAll(e.Graphics);
        }

        private void DrawAll(Graphics graphics)
        {
            int w = this.picCanvas.Width;
            int h = this.picCanvas.Height;

            graphics.DrawEllipse(Pens.Red, 0, 0, w, h);

            for (int i = 0; i < montecarlo.Points.Count; i++)
            {
                var cPoint = montecarlo.Points[i];

                float drawX = w / 2 + cPoint.X * w;
                float drawY = h / 2 + cPoint.Y * h;

                graphics.DrawEllipse(Pens.Blue, drawX - 1, drawY - 1, 2, 2);
            }
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }
    }
}
