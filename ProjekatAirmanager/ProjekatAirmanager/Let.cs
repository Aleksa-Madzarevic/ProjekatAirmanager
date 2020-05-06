using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class Let
    {
        double duzinaTrajanja;
        double zarada;
        int brojPutnika;
        Putnik[] nizPutnika;
        Avion airplane;
        bool desioSeIncident;

        public Let(Let l)
        {
            duzinaTrajanja = l.duzinaTrajanja;
            zarada = l.zarada;
            brojPutnika = l.brojPutnika;
            airplane = l.airplane;
            desioSeIncident = l.desioSeIncident;

            nizPutnika = new Putnik[l.brojPutnika + 10];
            for (int i = 0; i < l.brojPutnika; i++)
            {
                nizPutnika[i] = new Putnik(l.nizPutnika[i]);
            }
        }

        public Let(double duztr, double zar, int brput, Avion a, bool inc, Putnik[] niz)
        {
            duzinaTrajanja = duztr;
            zarada = zar;
            brojPutnika = brput;
            airplane = a;
            desioSeIncident = inc;

            nizPutnika = new Putnik[niz.Length];
            for (int i = 0; i < niz.Length; i++)
            {
                nizPutnika[i] = new Putnik(niz[i]);
            }
        }

        public double DuzinaTrajanja
        {
            get { return duzinaTrajanja; }
            set { duzinaTrajanja = value; }
        }

        public double Zarada
        {
            get { return zarada; }
            set { zarada = value; }
        }

        public int BrojPutnika
        {
            get { return brojPutnika; }
            set { brojPutnika = value; }
        }

        public Avion Airplane
        {
            get { return airplane; }
            set { airplane = value; }
        }

        public bool DesioSeIncident
        {
            get { return desioSeIncident; }
            set { desioSeIncident = value; }
        }

        public Putnik this[int i]
        {
            get { if (i < brojPutnika) return nizPutnika[i]; else return null; }
            set { nizPutnika[i] = value; }
        }

    }
}