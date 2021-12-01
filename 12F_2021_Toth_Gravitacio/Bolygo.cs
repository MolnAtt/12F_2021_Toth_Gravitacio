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
        public Brush toll;

        const double G = 1;

        public static void GravitációsKölcsönhatás(Bolygo a, Bolygo b)
        {
            // Igazából nem ezzel kéne dolgozni, mert a két bolygóra két különböző erő hat.
            double tav = a.hely.távolságnégyzete(b.hely);
            double Fa = G * b.m / tav;
            double Fb = G * a.m / tav;

            // ez most egy skalármennyiség, tehát ebből iránnyal bíró vektor kell.
            // az irány a másik bolygó fele mutat, venni kell az oda mutató vektort, 
            // el kell osztani a hosszával, és ezt kell megszorozni az F erővel

            // a.v += Fa;
            // b.v += Fb;

        }
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

            toll = new SolidBrush(szin);

            this.mcimke = new Label();
            this.mcimke.Location = new Point(80,10 + letolas);
            panel.Controls.Add(mcimke);

            this.helycimke = new Label();
            this.helycimke.Location = new Point(10,35 + letolas);
            panel.Controls.Add(helycimke);

            this.vcimke = new Label();
            this.vcimke.Location = new Point(10,60 + letolas);
            panel.Controls.Add(vcimke);

            MonitorFrissít();
            Bolygo.lista.Add(this);

           

        }

        internal static void OsszesMonitor()
        {
            foreach (Bolygo bolygo in Bolygo.lista)
                bolygo.MonitorFrissít();
        }

        public static void Összes_léptetése()
        {
            foreach (Bolygo bolygo in Bolygo.lista)
                bolygo.Léptet();
        }

        private void Léptet() => hely += v;
        private void MonitorFrissít()
        {
            helycimke.Text = $"hely = ({hely.X};{hely.Y})";
            vcimke.Text = $"v = ({v.X};{v.Y})";
            mcimke.Text = $"{m} Mt";
        }

        public static void Rajzold_le_mind_ide(PictureBox palya)
        {
            Bitmap kep = new Bitmap(palya.Width, palya.Height);
            Graphics rajzolókészlet = Graphics.FromImage(kep);

            foreach (Bolygo bolygo in Bolygo.lista)
            {
                bolygo.Rajzoldle(rajzolókészlet);
            }
            
            palya.Image = kep;
            palya.Refresh();
        }

        void Rajzoldle(Graphics rajzolókészlet)
        {
            double r = Math.Sqrt(m/10);
            int xp = (int)Math.Round(hely.X - r);
            int yp = (int)Math.Round(hely.Y - r);
            int R = (int)Math.Round(r);

            rajzolókészlet.FillEllipse(this.toll, new Rectangle(xp,yp,2*R, 2*R));
        }


    }
}
