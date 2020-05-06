using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class Avion
    {
        double cena;
        int brputnika;
        int brstjuardesa;
        int brpilota;
        double maksdist;
        Dimenzije dim;
        public Avion(double c, int pu, int s, int pi, double m, double v,double š, double d)
        {
            cena = c;
            brputnika = pu;
            brstjuardesa =s;
            brpilota =  pi;
            maksdist = m;
            dim = new Dimenzije(v,š,d);
        }
        public Avion(Avion a)
        {
            cena = a.cena;
            brputnika = a.brputnika;
            brstjuardesa = a.brstjuardesa;
            brpilota = a.brpilota;
            maksdist = a.maksdist;
            dim = a.dim;
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

    }
}
