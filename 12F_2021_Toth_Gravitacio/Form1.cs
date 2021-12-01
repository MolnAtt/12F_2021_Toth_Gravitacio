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
            
        }

        bool fut = false;
        private void start_Click(object sender, EventArgs e)
        {
            if (fut)
            {
                metronom.Stop();
                start.Text="START";
                
            }
            else
            {
                metronom.Start();
                start.Text="STOP";
                Bolygo.OsszesMonitor();
            }            
            fut = !fut;
        }

        private void palya_Click(object sender, EventArgs e)
        {
            Bolygo b1 = new Bolygo("Hektor", Color.Green, 100, new Vektor(200,300), new Vektor(1.2,0.5), monitorpanel);
            Bolygo b2 = new Bolygo("Kepler", Color.Blue, 1000, new Vektor(300,400), new Vektor(-1.2,0.2), monitorpanel);
        }

        private void metronom_Tick(object sender, EventArgs e)
        {
            Bolygo.Összes_léptetése();
            Bolygo.Rajzold_le_mind_ide(palya);
        }
    }
}
