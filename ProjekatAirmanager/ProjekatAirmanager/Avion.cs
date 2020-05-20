using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class Avion
    {
        string vrsta;
        double cena;
        int brputnika;
        int brstjuardesa;
        int brpilota;
        double maksdist;
        Dimenzije dim;
        double brzina;
        public Avion(){}
        public Avion(string vr,double c, int pu, int s, int pi, double m, double v,double š, double d, double b)
        {
            vrsta = vr;
            cena = c;
            brputnika = pu;
            brstjuardesa =s;
            brpilota =  pi;
            maksdist = m;
            dim = new Dimenzije(v,š,d);
            brzina = b;
        }
        public Avion(Avion a)
        {
            vrsta = a.vrsta;
            cena = a.cena;
            brputnika = a.brputnika;
            brstjuardesa = a.brstjuardesa;
            brpilota = a.brpilota;
            maksdist = a.maksdist;
            dim = a.dim;
            brzina = a.brzina;
        }
        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public Dimenzije Dim
        {
            get { return dim; }
        }
        public int BrPutnika
        {
            get{return brputnika;}
        }
        public int BrStjuardesa
        {
            get { return brstjuardesa; }
        }
        public int BrPilota
        {
            get { return brpilota; }
        }
        public double MaksDist
        {
            get { return maksdist; }
            set { maksdist = value; }
        }
        public double Brzina
        {
            get { return brzina; }
        }
    }
}
