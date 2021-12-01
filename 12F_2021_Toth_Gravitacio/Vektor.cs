using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12F_2021_Toth_Gravitacio
{
    class Vektor
    {
        public double X;
        public double Y;

        public Vektor(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vektor operator +(Vektor a, Vektor b) => new Vektor(a.X + b.X, a.Y + b.Y);
        public static Vektor operator -(Vektor a, Vektor b) => new Vektor(a.X - b.X, a.Y - b.Y);
        public static double operator *(Vektor a, Vektor b) => a.X*b.X+a.Y*b.Y;
        public static Vektor operator *(double lambda, Vektor b) => new Vektor(lambda*b.X, lambda * b.Y);
        public static Vektor operator *(Vektor b, double lambda) => lambda * b;
        public double távolságnégyzete(Vektor b) => (this - b).HosszNégyzet();
        public static Vektor operator /(Vektor b, double lambda) => (1/lambda) * b;
        public double HosszNégyzet() => X*X+Y*Y;
        public double Hossz() => Math.Sqrt(HosszNégyzet());



    }
}
