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
        //public Color szin;
        public double m;
        public Vektor hely;
        public Vektor v; // speed=sebesség velocity=sebességvektor, egy időegység alatt hova mozdul el

        Label nevcimke;
        Label mcimke;
        Label helycimke;
        Label vcimke;
        public Brush toll;

        const double G = 1;

        
        public Bolygo(string nev, Color szin, double m, Vektor hely, Vektor v, Panel panel)
        {
            this.nev = nev;
            //this.szin = szin;
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
        public static void GravitációsKölcsönhatás(Bolygo a, Bolygo b)
        {
            double tavnegyzet = a.hely.távolságnégyzete(b.hely);
            double alambda = G * b.m / tavnegyzet; // ezt a Wikipédiáról lestük le, elhittük Newtonnak.
            double blambda = G * a.m / tavnegyzet;

            Vektor b_irányvektor = a.hely - b.hely;
            Vektor a_irányvektor = -1*b_irányvektor;

            double tav = Math.Sqrt(tavnegyzet);
            Vektor b_egységvektor = b_irányvektor / tav;
            Vektor a_egységvektor = -1 * b_egységvektor;

            Vektor Fb = b_egységvektor * blambda;
            Vektor Fa = a_egységvektor * alambda;

            a.v += Fa;
            b.v += Fb;
        }

        internal static void Összes_törlése()
        {

        }

        public static void Utolsó_bolygó_sebességének_megadása(Point p)
        {
            Vektor hova = new Vektor(p);
            Bolygo b = Bolygo.lista.Last();
            b.v = (hova - b.hely)/100;
        }

        public static void Gravitáció_alkalmazása()
        {
            for (int honnan = 0; honnan < Bolygo.lista.Count-1; honnan++)
                for (int hova = honnan+1; hova < Bolygo.lista.Count; hova++)
                    GravitációsKölcsönhatás(Bolygo.lista[honnan], Bolygo.lista[hova]);
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
                bolygo.Rajzoldle(rajzolókészlet);
            
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
