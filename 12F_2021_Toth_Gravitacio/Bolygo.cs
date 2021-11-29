using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Windows.Forms;

namespace _12F_2021_Toth_Gravitacio
{
    class Bolygo
    {
        static List<Bolygo> lista = new List<Bolygo>();
        public string nev;
        public Color szin;
        public double m;
        public Vektor hely;
        public Vektor v; // speed=sebesség velocity=sebességvektor, egy időegység alatt hova mozdul el

        Label nevcimke;
        Label mcimke;
        Label helycimke;
        Label vcimke;
        


        public Bolygo(string nev, Color szin, double m, Vektor hely, Vektor v, Panel panel)
        {
            this.nev = nev;
            this.szin = szin;
            this.m = m;
            this.hely = hely;
            this.v = v;

            int letolas = Bolygo.lista.Count * 100;

            this.nevcimke = new Label();
            this.nevcimke.Text = this.nev;
            this.nevcimke.Location = new Point(0,10 + letolas);
            this.nevcimke.ForeColor = szin;
            this.nevcimke.AutoSize = true;
            panel.Controls.Add(nevcimke);


            this.mcimke = new Label();
            mcimke.Text = $"{this.m} Mt";
            this.mcimke.Location = new Point(80,10 + letolas);
            panel.Controls.Add(mcimke);

            this.helycimke = new Label();
            helycimke.Text = $"hely = ({hely.X};{hely.Y})";
            this.helycimke.Location = new Point(10,35 + letolas);
            panel.Controls.Add(helycimke);

            this.vcimke = new Label();
            vcimke.Text = $"v = ({v.X};{v.Y})";
            this.vcimke.Location = new Point(10,60 + letolas);
            panel.Controls.Add(vcimke);

            Bolygo.lista.Add(this);

            Rajzoldle();

        }

        void Rajzoldle()
        { 

        }


    }
}
