using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12F_2021_Toth_Gravitacio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 
            Bitmap kep = new Bitmap(palya.Width, palya.Height);
            Graphics gr = Graphics.FromImage(kep);
            Pen toll = new Pen(Color.White);
            gr.DrawLine(toll, new Point(0, 0), new Point(100, 100));
            palya.Image = kep;
            palya.Refresh();

        }

        private void start_Click(object sender, EventArgs e)
        {

        }

        private void palya_Click(object sender, EventArgs e)
        {
            Bolygo b1 = new Bolygo("Hektor", Color.Green, 100, new Vektor(200,300), new Vektor(1.2,0.5), monitorpanel);
            Bolygo b2 = new Bolygo("Kepler", Color.Blue, 1000, new Vektor(300,400), new Vektor(-1.2,0.2), monitorpanel);
        }
    }
}
