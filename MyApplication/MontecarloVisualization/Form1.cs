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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }
    }
}
